using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildSandbox.Common
{
  public class BitPackReader
  {
    private const int FIRST_BIT_IN_BYTE = 0;
    private const int LAST_BIT_IN_BYTE = 7;

    /// <summary>
    /// The underlying stream of the reader.
    /// </summary>
    public Stream BaseStream { get; }

    /// <summary>
    /// The value of the last byte read from the stream.
    /// </summary>
    private byte CurrentByte { get; set; }

    /// <summary>
    /// The position (in bits) of the reader in the current byte.
    /// </summary>
    private byte PositionInCurrentByte { get; set; }

    public BitPackReader(Stream stream)
    {
      BaseStream = stream;
      PositionInCurrentByte = 8;
    }

    /// <summary>
    /// Advances the reader to a full, aligned byte.
    /// If the reader is already aligned, this does nothing.
    /// </summary>
    public void Align()
    {
      while (PositionInCurrentByte % 8 != 0)
        ReadBit();
    }


    public bool ReadBit()
    {
      if (PositionInCurrentByte > LAST_BIT_IN_BYTE)
      {
        var newByte = BaseStream.ReadByte();

        if (newByte == -1)
          throw new ApplicationException("Attempted to read a byte beyond stream end.");

        CurrentByte = (byte)newByte;
        PositionInCurrentByte = 0;
      }

      return ((CurrentByte >> PositionInCurrentByte++) & 1) != 0;
    }

    public long ReadInteger(int bits)
    {
      if (bits < 0 || bits > 64)
        throw new ArgumentOutOfRangeException(nameof(bits));

      long value = 0;

      for (int i = 0; i < bits; i++)
        if (ReadBit())
          value |= 1L << i;

      return value;
    }

    public float ReadFloat()
    {
      int value = (int)ReadInteger(32);
      return BitConverter.Int32BitsToSingle(value);
    }

    public byte[] ReadBytes(int length)
    {
      var bytes = new byte[length];
      for (int i = 0; i < length; i++)
        bytes[i] = (byte)ReadInteger(8);

      return bytes;
    }

    public string ReadString(bool wide)
    {
      var encoding = wide ? Encoding.Unicode : Encoding.ASCII;
      var extended = ReadBit();
      var length = (int)ReadInteger(extended ? 15 : 7);
      var bytes = ReadBytes(length * 2);
      return encoding.GetString(bytes);
    }
  }
}
