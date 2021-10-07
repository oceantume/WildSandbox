using System;
using System.IO;
using System.Linq;
using WildSandbox.Common;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Builder;
using Xunit;

namespace WildSandbox.MessageEngine.Tests
{
  public class TestStaticArrays
  {
    [Fact]
    public void EmptyStaticArrayOfInts()
    {
      var initial = new EmptyArrayMessage<int>
      {
        Values = Array.Empty<int>()
      };

      Utils.TestWriteAndRead(initial, 0);
    }

    sealed record EmptyArrayMessage<T>
    {
      public T[]? Values { get; set; }

      public bool Equals(EmptyArrayMessage<T>? obj) => obj != null && Values?.SequenceEqual(obj.Values!) == true;
      public override int GetHashCode() => throw new NotImplementedException();

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<EmptyArrayMessage<T>>()
          .Array(x => x.Values, 0);
      }
    }

    [Fact]
    public void StaticArrayOfStrings()
    {
      var initial = new ArrayMessage<string>
      {
        Values = Enumerable.Range(0, 10).Select(x => $"String {x}").ToArray()
      };

      var expectedLengthEach = 1 + 7 + (uint)("String X".Length * 8);
      Utils.TestWriteAndRead(initial, 10 * expectedLengthEach);
    }

    [Fact]
    public void StaticArrayOfBytes()
    {
      var initial = new ArrayMessage<byte>
      {
        Values = Enumerable.Range(0, 10).Select(x => Convert.ToByte(x)).ToArray()
      };

      var expectedLengthEach = 8u;
      Utils.TestWriteAndRead(initial, 10 * expectedLengthEach);
    }

    [Fact]
    public void StaticArrayOfInts()
    {
      var initial = new ArrayMessage<int>
      {
        Values = Enumerable.Range(0, 10).ToArray()
      };

      var expectedLengthEach = 32u;
      Utils.TestWriteAndRead(initial, 10 * expectedLengthEach);
    }

    [Fact]
    public void StaticArrayOfFloats()
    {
      var initial = new ArrayMessage<float>
      {
        Values = Enumerable.Range(0, 10).Select(x => Convert.ToSingle(x) + 0.25f).ToArray()
      };

      var expectedLengthEach = 32u;
      Utils.TestWriteAndRead(initial, 10 * expectedLengthEach);
    }

    sealed record ArrayMessage<T>
    {
      public T[]? Values { get; set; }

      public bool Equals(ArrayMessage<T>? obj) => obj != null && obj.Values != null && Values?.SequenceEqual(obj.Values) == true;
      public override int GetHashCode() => throw new NotImplementedException();

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<ArrayMessage<T>>()
          .Array(x => x.Values, 10);
      }

    }

    [Fact]
    public void StaticMultiArrays()
    {
      var initial = new MultiArrayMessage
      {
        IntValues = Enumerable.Range(0, 10).ToArray(),
        FloatValues = Enumerable.Range(0, 20).Select(x => Convert.ToSingle(x) + 0.25f).ToArray()
      };

      Utils.TestWriteAndRead(initial, 32u * 10 + 32u * 20);
    }

    sealed record MultiArrayMessage
    {
      public int[]? IntValues { get; set; }
      public float[]? FloatValues { get; set; }

      public bool Equals(MultiArrayMessage? obj) => 
        obj != null
        && IntValues!.SequenceEqual(obj.IntValues!)
        && FloatValues!.SequenceEqual(obj.FloatValues!);
      public override int GetHashCode() => throw new NotImplementedException();

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<MultiArrayMessage>()
          .Array(x => x.IntValues, 10)
          .Array(x => x.FloatValues, 20);
      }
    }

    [Fact]
    public void StaticAlignedArray()
    {
      var initial = new AlignedArrayMessage
      {
        IntValue = 5,
        ByteValues = Enumerable.Range(0, 16).Select(x => (byte)x).ToArray(),
      };

      Utils.TestWriteAndRead(initial, 3 + (8 - 3) + 16 * 8);
    }

    sealed record AlignedArrayMessage
    {
      public int IntValue { get; set; }
      public byte[]? ByteValues { get; set; }

      public bool Equals(AlignedArrayMessage? obj) =>
       obj?.ByteValues != null
       && ByteValues?.SequenceEqual(obj.ByteValues) == true;
      public override int GetHashCode() => throw new NotImplementedException();

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<AlignedArrayMessage>()
          .Integer(x => x.IntValue, 3)
          .Array(x => x.ByteValues, 16).Aligned(true).OfInteger(8);
      }
    }
  }
}
