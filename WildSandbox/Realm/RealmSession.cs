using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WildSandbox.Game.Messages;
using WildSandbox.Messages.Build6072;
using WildSandbox.Networking;

namespace WildSandbox.Realm
{
  class RealmSession : Networking.GameSession
  {
    private const int PACKET_SIZE_BITS = 0x18;
    private const int PACKET_ID_BITS = 0xB;
    private const int PACKET_HEADER_BITS = PACKET_SIZE_BITS + PACKET_ID_BITS;

    private static GameMessageHandlers<RealmSession> Handlers { get; }
      = GameMessageHandlers<RealmSession>.CreateFromReflection();

    public RealmSession(Socket socket) : base(socket) { }

    public void Initialize()
    {
      SendMessage(MessageId.SHello, new Message0002
      {
        buildNumber = 6072,
        connectionType = 3,
        networkMessageCRC = 0x2229B228
      });
    }

    protected override void HandleReceivedPacket(ReceivedPacket packet)
    {
      if (packet.Id == MessageId.Ping1 || packet.Id == MessageId.Ping2)
      {
        byte index = (byte)packet.Reader.ReadInteger(8);
        var replyPacket = new OutgoingPacket(packet.Id, 8);
        replyPacket.Writer.WriteInteger(index, 8);
        Send(replyPacket);
      }
      else
      {
        if (!Handlers.TryGetHandler(packet.Id, out var handler))
        {
          Logs.Log(LogType.Realm, LogLevel.Warning, "No handler for packet id 0x{0:X} size {1}", (uint)packet.Id, packet.Size);
          return;
        }
        
        var message = GetMessage(packet, handler.MessageType);
        Logs.Log(LogType.Realm, LogLevel.Info, "Handling message id 0x{0:X}: {1}", packet.Id, message);
        handler.Callback(this, message);
      }
    }
  }
}
