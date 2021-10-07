using System;
using System.IO;
using WildSandbox.MessageEngine.Builder;
using WildSandbox.MessageEngine.Tests.Messages;
using Xunit;
using FluentAssertions;
using WildSandbox.Common;

namespace WildSandbox.MessageEngine.Tests
{
  public class TestRealmMessages
  {
    [Fact]
    public void ByteIntegers()
    {
      var message = new SCharacterList
      {
        characterCount = 1,
        characterInfo = new Structure021[]
        {
          new Structure021
          {
            characterId = 1,
            characterName = "Test",
            characterSex = 1,
            characterRace = 4,
            characterClass = 5,
            characterFaction = 167,
            characterLevel = 60,
            bodyCount = 0,
            bodyVisuals = Array.Empty<Structure020>(),
            equipCount = 0,
            equipmentVisuals = Array.Empty<Structure020>(),
            worldId = 4,
            realmId = 107,
            instanceId = 144,
            worldLocation = new Structure014
            {
              location = new Structure015
              {
                x = 1466.926f,
                y = -897.1984f,
                z = 1423.634f,
              },
              yaw = -2.864248f,
              pitch = 0f,
              //TileId = -1, // TODO: Fix negatives. We need to fix ints in general. 
              tileId = 0,
            },
            characterPath = 1,
            boneCustomizationCount = 0,
            boneCustomizations = Array.Empty<float>()
          }
        },
        additionalCount = 2,
        additionalAllowedCharCreations = new uint[2],
      };

      TestWriteAndRead(message);
    }

    private void TestWriteAndRead<T>(T initial) where T : class, new()
    {
      var engine = MessageEngine.Create();

      var stream = new MemoryStream(1024);
      var writer = new BitPackWriter(stream);

      //Assert.Equal(expectedSize, engine.AddMessageSize(0, initial));

      engine.WriteMessageTo(writer, initial);

      stream.Position = 0;
      var reader = new BitPackReader(stream);

      var result = engine.ReadMessageFrom<T>(reader);
      result.Should().BeEquivalentTo(initial);
    }
  }
}
