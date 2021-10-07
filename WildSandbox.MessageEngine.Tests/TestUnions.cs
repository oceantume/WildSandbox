using System;
using System.IO;
using WildSandbox.Common;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Builder;
using Xunit;

namespace WildSandbox.MessageEngine.Tests
{
  public class TestUnions
  {
    [Fact]
    public void Unions()
    { 
      var firstMessage = new TestMessage
      {
        Which = 0,
        Test = new TestUnion
        {
          First = new FirstTestStructure
          {
            FloatValue = 1.25f
          }
        }
      };

      var secondMessage = new TestMessage
      {
        Which = 1,
        Test = new TestUnion
        {
          Second = new SecondTestStructure
          {
            IntValue = -1
          }
        }
      };

      Utils.TestWriteAndRead(firstMessage, 32 + 32);
      Utils.TestWriteAndRead(secondMessage, 32 + 32);
    }

    record TestMessage
    {
      public uint Which { get; set; }
      public TestUnion? Test { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<TestMessage>()
          .Integer(x => x.Which)
          .Union(x => x.Test, x => x.Which, matches =>
            matches
              .Match(x => x.First, 0)
              .Match(x => x.Second, 1));
      }
    }

    record TestUnion
    {
      public FirstTestStructure? First { get; set; }
      public SecondTestStructure? Second { get; set; }
    }

    record FirstTestStructure
    {
      public float FloatValue { get; set; }

      public static void Build(IMessageBuilder builder)
      {
        builder.FieldsOf<FirstTestStructure>()
          .Float(x => x.FloatValue);
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
