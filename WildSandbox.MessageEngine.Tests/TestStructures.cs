using System;
using System.IO;
using WildSandbox.Common;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Builder;
using Xunit;

namespace WildSandbox.MessageEngine.Tests
{
  public class TestStructures
  {
    [Fact]
    public void Structures()
    {
      var message = new TestMessage
      {
        Test = new FirstTestStructure
        {
          IntValue = -1,
          FloatValue = 1.25f,
          StringValue = "Test Value",
          StructValue = new SecondTestStructure
          {
            IntValue = -2
          }
        }
      };

      var stringSize = 1 + 7 + (uint)(message.Test.StringValue.Length * 8);
      Utils.TestWriteAndRead(message, 32 * 3 + stringSize);
    }

    record TestMessage
    {
      public FirstTestStructure? Test { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<TestMessage>()
          .Structure(x => x.Test);
      }
    }

    record FirstTestStructure
    {
      public string? StringValue { get; set; }
      public float FloatValue { get; set; }
      public int IntValue { get; set; }
      public SecondTestStructure? StructValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<FirstTestStructure>()
          .String(x => x.StringValue)
          .Float(x => x.FloatValue)
          .Integer(x => x.IntValue)
          .Structure(x => x.StructValue);
      }
    }

    record SecondTestStructure
    {
      public int IntValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<SecondTestStructure>()
          .Integer(x => x.IntValue);
      }
    }
  }
}
