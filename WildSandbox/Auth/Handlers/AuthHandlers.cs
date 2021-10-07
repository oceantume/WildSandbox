
using WildSandbox.Game.Messages;
using WildSandbox.Messages.Build6072;

namespace WildSandbox.Auth.Handlers
{
  static class AuthHandlers
  {
    [MessageHandler(MessageId.CAuthRequest)]
    public static void HandleAuthRequest(AuthSession session, Message0259 message)
    {
      session.SendMessage(MessageId.SAuthReply, new Message025D
      {
        salt = 1807548302UL,
        random = 18446744073407396780UL
      });
    }

    [MessageHandler(MessageId.CAuthPasswordDigest)]
    public static void HandleAuthPasswordDigest(AuthSession session, Message025C message)
    {
      session.SendMessage(MessageId.SAuthSuccess, new Message025F());

      session.SendMessage(MessageId.SRealmList, new Message035A()
      {
        realmCount = 1,
        realmInfo = new Structure011[]
        {
          new Structure011
          {
            realmId = 1,
            realmName = "WildSandbox",
            flags = 0,
            realmStatus = 1,
          }
        }
      });
    }

    [MessageHandler(MessageId.CSelectRealm)]
    public static void HandleSelectRealm(AuthSession session, Message0372 message)
    {
      var gatewayInfo = new Message0198
      {
        gatewayAddress = new Structure012
        {
          address = 0x7F000001, // 127.0.0.1
          port = 24000,
        },
        gatewayTicket = new byte[16],
        accountId = 440369,
      };
      session.SendMessage(MessageId.SGatewayInfo, gatewayInfo);
    }
  }
}
