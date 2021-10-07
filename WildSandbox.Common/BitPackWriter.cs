using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildSandbox.Common
{
  public class BitPackWriter
  {
    private const int LAST_BIT_IN_BYTE = 7;

    /// <summary>
    /// The underlying stream of the writer.
    /// </summary>
    public Stream BaseStream { get; }

    /// <summary>
    /// The position (in bits) of the writer in the base stream.
    /// </summary>
    public long Position => BaseStream.Position * 8 + PositionInCurrentByte;

    /// <summary>
    /// The value of the byte currently being written to.
    /// </summary>
    private byte CurrentByte { get; set; }

    /// <summary>
    /// The position (in bits) of the writer in the current byte.
    /// </summary>
    private byte PositionInCurrentByte { get; set; }

    public BitPackWriter(Stream stream)
    {
      BaseStream = stream;
      PositionInCurrentByte = 0;
    }

    /// <summary>
    /// Flushes the current byte into the underlying stream and moves to the next byte.
    /// </summary>
    public void FlushByte()
    {
      if (PositionInCurrentByte > 0)
      {
        BaseStream.WriteByte(CurrentByte);
        PositionInCurrentByte = 0;
        CurrentByte = 0;
      }
    }

    public void WriteBit(bool bit)
    {
      if (bit)
        CurrentByte |= (byte)(1 << PositionInCurrentByte);

      if (++PositionInCurrentByte > LAST_BIT_IN_BYTE)
        FlushByte();
    }

    public void WriteInteger(long value, int bits)
    {
      if (bits < 0 || bits > 64)
        throw new ArgumentOutOfRangeException(nameof(bits));

      for (int i = 0; i < bits; i++)
        WriteBit(((value >> i) & 1) != 0);
    }

    public void WriteFloat(float value)
    {
      WriteInteger(BitConverter.SingleToInt32Bits(value), 32);
    }

    public void WriteBytes(byte[] bytes)
    {
      for (int i = 0; i < bytes.Length; i++)
        WriteInteger(bytes[i], 8);
    }

    public void WriteString(string? value, bool wide)
    {
      var encoding = wide ? Encoding.Unicode : Encoding.ASCII;
      var bytes = encoding.GetBytes(value ?? "");
      var length = bytes.Length / 2;
      var extended = length > 0x7F;
      WriteBit(extended);
      WriteInteger(length, extended ? 15 : 7);
      WriteBytes(bytes);
    }
  }
}
