using WildSandbox.Common;
using WildSandbox.MessageEngine;

namespace WildSandbox.OfflineMessageParser.Parser
{
  record Packet(
      int Size,
      int Id,
      byte[] Data,
      BitPackReader Reader,
      PacketSource Source);
}
