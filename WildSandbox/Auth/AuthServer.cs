using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WildSandbox.Auth
{
  class AuthServer : Networking.TcpServer<AuthSession>
  {
    public AuthServer(int port) : base(port) { }

    protected override AuthSession InitializeSession(Socket socket)
    {
      var session = new AuthSession(socket);
      session.Initialize();
      return session;
    }
  }
}
