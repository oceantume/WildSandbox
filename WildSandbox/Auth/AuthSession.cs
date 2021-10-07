using System.Net.Sockets;
using WildSandbox.Game.Messages;
using WildSandbox.Messages.Build6072;
using WildSandbox.Networking;

namespace WildSandbox.Auth
{
  class AuthSession : GameSession
  {
    private static GameMessageHandlers<AuthSession> Handlers { get; }
      = GameMessageHandlers<AuthSession>.CreateFromReflection();

    public AuthSession(Socket socket) : base(socket) { }

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
          Logs.Log(LogType.Auth, LogLevel.Warning, "No handler for packet id 0x{0:X} size {1}", (uint)packet.Id, packet.Size);
          return;
        }
        
        var message = GetMessage(packet, handler.MessageType);
        Logs.Log(LogType.Auth, LogLevel.Info, "Handling message {0}: {1}", packet.Id, message);
        handler.Callback(this, message);
      }
    }
  }
}
