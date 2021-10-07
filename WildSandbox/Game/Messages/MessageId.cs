namespace WildSandbox.Game.Messages
{
  public enum MessageId : int
  {
    Ping1 = 0,
		Ping2 = 1,
		SHello = 2,
		CAuthRequest = 0x259,
		SAuthReply = 0x25D,
		CAuthPasswordDigest = 0x25C,
    SubMessage = 0x194,
		SGatewayInfo = 0x198,
		SAuthSuccess = 0x25F,
		SRealmList = 0x35A,
		CSelectRealm = 0x372,
		CEnterRealm = 0x25B,
		SCharacterList = 0x92,
		CCreateCharacter = 0x13C,
		CSelectCharacter = 0x370,
		SWorldLocation = 0x40,
		SCreateUnit = 0x143,
		SEntryUnitTile = 0xE8, // maybe this is the controlled unit command.
		SGameMode = 0x72,
    CRequestNeighborhoods = 0x0229,
    SEnterWorldUnk1 = 0x0356, // ?
		SEnterWorldUnk2 = 0x0020, // ?
		SEnterWorldChat = 0x0109,
  }
}
