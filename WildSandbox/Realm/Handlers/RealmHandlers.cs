
using System;
using System.Collections.Generic;
using WildSandbox.Common.Messages;
using WildSandbox.Game.Messages;
using WildSandbox.Messages.Build6072;

namespace WildSandbox.Realm.Handlers
{
  static class AuthHandlers
  {
    [MessageHandler(MessageId.CEnterRealm)]
    public static void HandleEnterRealm(RealmSession session, Message025B message)
    {
      session.SendMessage(MessageId.SCharacterList, new Message0092
      {
        characterCount = 1,
        characterInfo = new Structure01B[]
        {
          new Structure01B
          {
            characterId = 72057594037961000,
            characterName = "Test",
            characterSex = 1,
            characterRace = 4,
            characterClass = 5,
            characterFaction = 167,
            characterLevel = 60,
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
              tileId = unchecked((uint)-1),
            },
            characterPath = 1,
          }
        },
        additionalCount = 2,
        additionalAllowedCharCreations = new uint[2],
      });
    }

    [MessageHandler(MessageId.CSelectCharacter)]
    public static void HandleSelectCharacter(RealmSession session, Message0372 message)
    {
      session.SendMessage(0x0040, new Message0040
      {
        worldId = 426,
        location = new Structure014
        {
          location = new Structure015
          {
            x = 3835.3245f,
            y = -678.81903f,
            z = -5262.3535f
          },
          yaw = -0.52916f,
          pitch = 0f,
          tileId = 0
        }
      });

      var characterCommands = new Structure082[]
        {
          new Structure082
          {
            type = 2,
            data = new Union007
            {
              setPosition = new Structure085
              {
                position = new Structure086
                {
                  x = 3835.3245f,
                  y = -678.81903f,
                  z = -5262.3535f
                },
                blend = 0
              }
            }
          },
          new Structure082
          {
            type = 13,
            data = new Union007
            {
              setRotation = new Structure091
              {
                rotation = new Structure092
                {
                  yaw = -0.52916f,
                  pitch = 0,
                  roll = 0
                },
                blend = 0
              }
            }
          }
        };

      var characerStats = new Structure081[]
      {
        new Structure081 { stat = 0, newValue = 970, data = 0, reason = 0 },
        new Structure081 { stat = 2, newValue = (uint)BitConverter.SingleToInt32Bits(500f), data = 0, reason = 0 },
        new Structure081 { stat = 9, newValue = (uint)BitConverter.SingleToInt32Bits(100f), data = 0, reason = 0 },
      };

      session.SendMessage(0x0143, new Message0143
      {
        unitId = 323704,
        unitType = 19,
        unitInfo = new Union006
        {
          player = new Structure073
          {
            characterId = 72057594037964052,
            realmId = 1,
            name = "Test",
            raceId = 4,
            classId = 5,
            sex = 0,
          }
        },
        statCount = (ushort)characerStats.Length,
        stats = characerStats,
        time = 29481901,
        commandCount = (ushort)characterCommands.Length,
        commands = characterCommands,
        factionId = 167,
        timeSinceDeath = 29481901,
      });

      session.SendMessage(0x00E8, new Message00E8
      {
        unitId = 323704,
        tileId = 0,
      });

      session.SendMessage(0x02AA, new Message02AA
      {
        ticket = 1,
        immediate = 1,
        unitId = 323704
      });

      session.SendMessage(0x0072, new Message0072
      {
        difficulty = 0,
        gameMode = 0,
      });

      session.SendMessage(0x0020, new Message0020());
    }
  }
}
