using System;
using System.IO;
using System.Net.Sockets;
using WildSandbox.Common;
using WildSandbox.Game.Messages;
using WildSandbox.MessageEngine;

namespace WildSandbox.Networking
{
  abstract class GameSession : TcpSession
  {
    private const int PACKET_SIZE_BITS = 0x18;
    private const int PACKET_ID_BITS = 0xB;
    private const int PACKET_HEADER_BITS = PACKET_SIZE_BITS + PACKET_ID_BITS;
    private const int PACKET_HEADER_BYTES = (PACKET_HEADER_BITS + 7) / 8;

    private static IMessageEngine MessageEngine { get; } = Engine.CreateMessageEngine();

    public GameSession(Socket socket) : base(socket)
    {
      BeginReceivePacket();
    }

    protected object GetMessage(ReceivedPacket packet, Type type)
    {
      return MessageEngine.ReadMessageFrom(packet.Reader, type);
    }

    protected T GetMessage<T>(ReceivedPacket packet) where T : class, new()
    {
      return MessageEngine.ReadMessageFrom<T>(packet.Reader);
    }

    public void SendMessage<T>(uint id, T message) where T : notnull, new()
    {
      SendMessage<T>((MessageId)id, message);
    }

    public void SendMessage<T>(MessageId id, T message) where T : notnull, new()
    {
      var size = MessageEngine.AddMessageSize(PACKET_HEADER_BITS, message) - PACKET_HEADER_BITS;
      var packet = new OutgoingPacket(id, (uint)size);
      MessageEngine.WriteMessageTo(packet.Writer, message);
      Send(packet);
    }

    /// <summary>
    /// Sends the packet's buffer to the game client.
    /// </summary>
    public void Send(OutgoingPacket packet)
    {
      Send(packet.GetBuffer());
    }

    private void BeginReceivePacket()
    {
      var stream = new MemoryStream(1024);
      var reader = new BitPackReader(stream);
      var packet = new ReceivedPacket(stream, reader);

      stream.SetLength(PACKET_HEADER_BYTES);
      Receive(stream, PACKET_HEADER_BYTES, HandleReceiveHeader, packet);
    }

    private void HandleReceiveHeader(object? state)
    {
      if (state == null)
      {
        throw new ArgumentNullException(nameof(state));
      }

      var packet = (ReceivedPacket)state;
      packet.Size = (int)packet.Reader.ReadInteger(PACKET_SIZE_BITS);
      packet.Id = (MessageId)packet.Reader.ReadInteger(PACKET_ID_BITS);
      packet.Stream.SetLength(packet.Size);

      var size = packet.Size - PACKET_HEADER_BYTES;
      if (size > 0)
      {
        Receive(packet.Stream, size, HandleReceiveBody, packet);
      }
      else
      {
        HandleReceivedPacket(packet);
        BeginReceivePacket();
      }
    }

    private void HandleReceiveBody(object? state)
    {
      if (state == null)
      {
        throw new ArgumentNullException(nameof(state));
      }

      var packet = (ReceivedPacket)state;

      Logs.Log(LogType.Network, "Received packet id: 0x{0:X}, size: {1}", // {2}
        packet.Id, packet.Size, Logs.GetBufferString(packet.Stream));

      if (packet.Id == MessageId.SubMessage)
      {
        packet.Reader.Align();
        packet = new ReceivedPacket(packet.Stream, packet.Reader);
        packet.Size = (int)packet.Reader.ReadInteger(0x18);
        packet.Id = (MessageId)packet.Reader.ReadInteger(0xB);
      }

      HandleReceivedPacket(packet);

      BeginReceivePacket();
    }

    protected abstract void HandleReceivedPacket(ReceivedPacket packet);

    protected class ReceivedPacket
    {
      public ReceivedPacket(MemoryStream stream, BitPackReader reader)
      {
        Stream = stream;
        Reader = reader;
      }

      public MessageId Id { get; set; }
      public int Size { get; set; }
      public MemoryStream Stream { get; init; }
      public BitPackReader Reader { get; init; }
    }
  }
}
