using System;
using System.IO;
using WildSandbox.Common;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Builder;
using Xunit;

namespace WildSandbox.MessageEngine.Tests
{
  public class TestBasicFields
  {
    [Fact]
    public void ByteIntegers()
    {
      var initial = new BytesMessage { ByteValue = byte.MaxValue, SByteValue = sbyte.MinValue };
      Utils.TestWriteAndRead(initial, 16);
    }

    record BytesMessage
    {
      public byte ByteValue { get; set; }
      public sbyte SByteValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<BytesMessage>()
          .Integer(x => x.ByteValue)
          .Integer(x => x.SByteValue);
      }
    }

    [Fact]
    public void SimpleIntegers()
    {
      var initial = new IntsMessage { IntValue = -1, UIntValue = uint.MaxValue };
      Utils.TestWriteAndRead(initial, 64);
    }

    record IntsMessage
    {
      public uint UIntValue { get; set; }
      public int IntValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<IntsMessage>()
          .Integer(x => x.UIntValue)
          .Integer(x => x.IntValue);
      }
    }

    [Fact]
    public void LongIntegers()
    {
      var initial = new LongsIntsMessage { LongValue = -1, ULongValue = ulong.MaxValue };
      Utils.TestWriteAndRead(initial, 128);
    }

    record LongsIntsMessage
    {
      public ulong ULongValue { get; set; }
      public long LongValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<LongsIntsMessage>()
          .Integer(x => x.ULongValue)
          .Integer(x => x.LongValue);
      }
    }

    [Fact]
    public void Float()
    {
      var initial = new FloatMessage { FloatValue = 1.25f };
      Utils.TestWriteAndRead(initial, 32);
    }

    record FloatMessage
    {
      public float FloatValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<FloatMessage>()
          .Float(x => x.FloatValue);
      }
    }

    [Fact]
    public void SmallString()
    {
      var initial = new StringMessage { StringValue = "Test value" };
      Utils.TestWriteAndRead(initial, 1 + 7 + (uint)(initial.StringValue.Length * 2 * 8));
    }

    [Fact]
    public void BigString()
    {
      var bigString = new string('*', 500);
      var initial = new StringMessage { StringValue = bigString };
      Utils.TestWriteAndRead(initial, 1 + 15 + (uint)(initial.StringValue.Length * 2 * 8));
    }

    record StringMessage
    {
      public string? StringValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<StringMessage>()
          .String(x => x.StringValue, true);
      }
    }

    [Fact]
    public void NonWideString()
    {
      var bigString = new string('*', 500);
      var initial = new NonWideStringMessage { StringValue = bigString };
      Utils.TestWriteAndRead(initial, 1 + 15 + (uint)(initial.StringValue.Length * 8));
    }

    record NonWideStringMessage
    {
      public string? StringValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<NonWideStringMessage>()
          .String(x => x.StringValue, false);
      }
    }
  }
}
