using System;
using System.IO;
using WildSandbox.Common;
using WildSandbox.Game.Messages;
using WildSandbox.MessageEngine;

namespace WildSandbox.Networking
{
  class OutgoingPacket
  {
    private const int PACKET_SIZE_BITS = 0x18;
    private const int PACKET_ID_BITS = 0xB;
    private const int PACKET_HEADER_BITS = PACKET_SIZE_BITS + PACKET_ID_BITS;
    private const int PACKET_HEADER_BYTES = (PACKET_HEADER_BITS + 7) / 8;

    public OutgoingPacket(MessageId id, uint payloadSizeInBits)
    {
      Id = id;
      Size = (PACKET_HEADER_BITS + (int)payloadSizeInBits + 7) / 8;
      Buffer = new byte[Size];
      Writer = new BitPackWriter(new MemoryStream(Buffer, true));

      Writer.WriteInteger(Size, PACKET_SIZE_BITS);
      Writer.WriteInteger((long)Id, PACKET_ID_BITS);
    }

    private byte[] Buffer { get; init; }

    public MessageId Id { get; private init; }
    public int Size { get; private init; }
    public BitPackWriter Writer { get; private init; }

    public byte[] GetBuffer()
    {
      return Buffer;
    }
  }
}
