using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WildSandbox.Realm
{
  class RealmServer : Networking.TcpServer<RealmSession>
  {
    public RealmServer(int port) : base(port) { }

    protected override RealmSession InitializeSession(Socket socket)
    {
      var session = new RealmSession(socket);
      session.Initialize();
      return session;
    }
  }
}
