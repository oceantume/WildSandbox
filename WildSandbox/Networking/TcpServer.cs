using System;
using System.Net;
using System.Net.Sockets;

namespace WildSandbox.Networking
{
  abstract class TcpServer<TSession> where TSession : TcpSession
  {
    private TcpListener m_listener;

    public TcpServer(int port) : this(IPAddress.Any, port) { }

    protected TcpServer(IPAddress ip, int port)
    {
      m_listener = new TcpListener(ip, port);
    }

    public void Start()
    {
      m_listener.Start();
      m_listener.BeginAcceptTcpClient(HandleAsyncConnection, null);
    }

    private void HandleAsyncConnection(IAsyncResult res)
    {
      TcpClient client = m_listener.EndAcceptTcpClient(res);
      m_listener.BeginAcceptTcpClient(HandleAsyncConnection, m_listener);

      Logs.Log("New connection from {0}", client.Client.RemoteEndPoint);

      var socket = client.Client;
      InitializeSession(socket);
    }

    protected abstract TSession InitializeSession(Socket socket);
  }
}
