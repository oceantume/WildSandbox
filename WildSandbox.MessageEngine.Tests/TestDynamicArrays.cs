using System;
using System.IO;
using System.Linq;
using WildSandbox.Common;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Builder;
using Xunit;

namespace WildSandbox.MessageEngine.Tests
{
  public class TestDynamicArrays
  {
    [Fact]
    public void EmptyDynamicArrayOfInts()
    {
      var initial = new ArrayMessage<int>
      {
        ValuesCount = 0,
        Values = Array.Empty<int>()
      };

      Utils.TestWriteAndRead(initial, 32);
    }

    [Fact]
    public void NullDynamicArrayOfInts()
    {
      var initial = new ArrayMessage<int>
      {
        ValuesCount = 0,
        Values = null
      };

      Utils.TestWriteAndRead(initial, 32);
    }

    [Fact]
    public void DynamicArrayOfStrings()
    {
      var initial = new ArrayMessage<string>
      {
        ValuesCount = 10,
        Values = Enumerable.Range(0, 10).Select(x => $"String {x}").ToArray()
      };

      var expectedLengthEach = 1 + 7 + (uint)("String X".Length * 8);
      Utils.TestWriteAndRead(initial, 32 + 10 * expectedLengthEach);
    }

    [Fact]
    public void DynamicArrayOfBytes()
    {
      var initial = new ArrayMessage<byte>
      {
        ValuesCount = 10,
        Values = Enumerable.Range(0, 10).Select(x => Convert.ToByte(x)).ToArray()
      };

      var expectedLengthEach = 8u;
      Utils.TestWriteAndRead(initial, 32 + 10 * expectedLengthEach);
    }

    [Fact]
    public void DynamicArrayOfInts()
    {
      var initial = new ArrayMessage<int>
      {
        ValuesCount = 10,
        Values = Enumerable.Range(0, 10).ToArray()
      };

      var expectedLengthEach = 32u;
      Utils.TestWriteAndRead(initial, 32 + 10 * expectedLengthEach);
    }

    [Fact]
    public void DynamicArrayOfFloats()
    {
      var initial = new ArrayMessage<float>
      {
        ValuesCount = 10,
        Values = Enumerable.Range(0, 10).Select(x => Convert.ToSingle(x)).ToArray()
      };

      var expectedLengthEach = 32u;
      Utils.TestWriteAndRead(initial, 32 + 10 * expectedLengthEach);
    }

    sealed record ArrayMessage<T>
    {
      public uint ValuesCount { get; set; }
      public T[]? Values { get; set; }

      //public bool Equals(ArrayMessage<T>? obj) => obj != null && obj.Values != null && Values?.SequenceEqual(obj.Values) == true;
      public bool Equals(ArrayMessage<T>? obj)
      {
        if (obj == null)
          return false;

        if (obj.Values == null && (Values == null || Values.Length == 0))
          return true;

        if (Values == null && (obj.Values == null || obj.Values.Length == 0))
          return true;

        return obj.Values != null && Values?.SequenceEqual(obj.Values) == true;
      }

      public override int GetHashCode() => throw new NotImplementedException();

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<ArrayMessage<T>>()
          .Integer(x => x.ValuesCount)
          .Array(x => x.Values, x => x.ValuesCount);
      }
    }
  }
}
