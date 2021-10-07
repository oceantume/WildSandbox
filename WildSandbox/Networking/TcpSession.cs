using System;
using System.IO;
using System.Net.Sockets;
using System.Linq;

namespace WildSandbox.Networking
{
  abstract class TcpSession
  {
    protected delegate void ReceiveCallback(object? stream);
    protected Socket Socket { get; private set; }

    protected TcpSession(Socket socket)
    {
      Socket = socket;
    }


    /// <summary>
    /// Initialize receive on the socket. The callback will only be invoked when the specified size has been received from client.
    /// This writes to the memory stream's internal buffer directly at the current Position, without advancing the Position.
    /// </summary>
    protected void Receive(MemoryStream stream, int size, ReceiveCallback callback, object? state)
    {
      BeginAsyncReceive(new AsyncReceiveState(stream, size, callback, state));
    }

    private void BeginAsyncReceive(AsyncReceiveState state)
    {
      var buffer = state.Stream.GetBuffer();
      var offset = (int)state.Stream.Position;
      var size = state.Size - state.Read;

      Socket.BeginReceive(buffer, offset, size, SocketFlags.None, HandleAsyncReceive, state);
    }

    private void HandleAsyncReceive(IAsyncResult result)
    {
      try
      {
        int read = Socket.EndReceive(result);

        if (read > 0)
        {
          var receiveState = (AsyncReceiveState)result.AsyncState!;
          receiveState.Read += read;

          if (receiveState.Size > receiveState.Read)
          {
            BeginAsyncReceive(receiveState);
          }
          else
          {
            receiveState.Callback(receiveState.CallbackState);
          }
        }
        else
        {
          // connection was closed.
          Logs.Log(LogType.Network, "Client closed connection: {0}", Socket.RemoteEndPoint);
          Socket.Close();
        }
      }
      catch (SocketException e)
      {
        switch (e.SocketErrorCode)
        {
          // TODO: More SocketError handling.
          case SocketError.ConnectionReset:
            Logs.Log(LogType.Network, LogLevel.Warning,
                "Client {0} issued a ConnectionReset error.", Socket.RemoteEndPoint);
            Socket.Close();
            break;
          default:
            // Swallow the exception, but make sure a log is created and close the client.
            Logs.Log(LogType.Network, LogLevel.Exception,
                "Unhandled SocketException (Error:{0}) for client {1} while receiving. Closing the client.",
                e.SocketErrorCode, Socket.RemoteEndPoint);
            Socket.Close();
            break;
        }
      }
    }

    private class AsyncReceiveState
    {
      public AsyncReceiveState(MemoryStream stream, int size, ReceiveCallback callback, object? state)
      {
        Stream = stream;
        Size = size;
        Callback = callback;
        CallbackState = state;
      }

      public ReceiveCallback Callback { get; init; }
      public object? CallbackState { get; init; }
      public MemoryStream Stream { get; init; }
      public int Size { get; init; }
      public int Read { get; set; } = 0;
    }

    protected void Send(ReadOnlySpan<byte> buffer)
    {
      byte[] sendBuffer = buffer.ToArray();
      Socket.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, new AsyncCallback(HandleAsyncSend), sendBuffer);
    }

    private void HandleAsyncSend(IAsyncResult res)
    {
      try
      {
        int bytesSent = Socket.EndSend(res);

        byte[] buffer = (byte[])res.AsyncState!;
        Logs.Log(LogType.Network, "Sent {0} bytes to client {1}", // {2}
          bytesSent, Socket.RemoteEndPoint, Logs.GetBufferString(buffer));
      }
      catch (SocketException e)
      {
        // Swallow the exception, but make sure a log is created and close the client.
        Logs.Log(LogType.Network, LogLevel.Exception,
            "Unhandled SocketException (Error:{0}) for client {1} while sending. Closing the client.",
            e.SocketErrorCode, Socket.RemoteEndPoint);
        Socket.Close();
      }
      catch (Exception e)
      {
        Logs.Log(LogType.Network, LogLevel.Exception, "Failed to send message to a client. Exception: {0}\n{1}", e.Message, e.Source);

        // don't swallow, this is a bug.
        throw;
      }
    }
  }
}
