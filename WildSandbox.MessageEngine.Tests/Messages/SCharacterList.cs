using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildSandbox.Common.Messages;
using WildSandbox.MessageEngine.Builder;

namespace WildSandbox.MessageEngine.Tests.Messages
{
  public record SCharacterList
  {
    public uint characterCount { get; set; }
    public Structure021[]? characterInfo { get; set; }
    public uint additionalCount { get; set; }
    public uint[]? additionalAllowedCharCreations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<SCharacterList>()
        .Integer(x => x.characterCount, 32)
        .Array(x => x.characterInfo, x => x.characterCount).OfStructure()
        .Integer(x => x.additionalCount, 32)
        .Array(x => x.additionalAllowedCharCreations, x => x.additionalCount).OfInteger(32);
    }
  }

  public record Structure021
  {
    public ulong characterId { get; set; }
    public string? characterName { get; set; }
    public uint characterSex { get; set; }
    public uint characterRace { get; set; }
    public uint characterClass { get; set; }
    public uint characterFaction { get; set; }
    public uint characterLevel { get; set; }
    public uint bodyCount { get; set; }
    public Structure020[]? bodyVisuals { get; set; }
    public uint equipCount { get; set; }
    public Structure020[]? equipmentVisuals { get; set; }
    public uint worldId { get; set; }
    public uint realmId { get; set; }
    public uint instanceId { get; set; }
    public Structure014? worldLocation { get; set; }
    public uint characterPath { get; set; }
    public uint boneCustomizationCount { get; set; }
    public float[]? boneCustomizations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure021>()
        .Integer(x => x.characterId, 64)
        .String(x => x.characterName, true)
        .Integer(x => x.characterSex, 2)
        .Integer(x => x.characterRace, 5)
        .Integer(x => x.characterClass, 5)
        .Integer(x => x.characterFaction, 32)
        .Integer(x => x.characterLevel, 32)
        .Integer(x => x.bodyCount, 32)
        .Array(x => x.bodyVisuals, x => x.bodyCount).OfStructure()
        .Integer(x => x.equipCount, 32)
        .Array(x => x.equipmentVisuals, x => x.equipCount).OfStructure()
        .Integer(x => x.worldId, 32)
        .Integer(x => x.realmId, 32)
        .Integer(x => x.instanceId, 32)
        .Structure(x => x.worldLocation)
        .Integer(x => x.characterPath, 3)
        .Integer(x => x.boneCustomizationCount, 32)
        .Array(x => x.boneCustomizations, x => x.boneCustomizationCount).OfFloat();
    }
  }

  public record Structure020
  {
    public uint itemSlot { get; set; }
    public uint itemDisplayId { get; set; }
    public uint itemColorSetId { get; set; }
    public uint itemDyeData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure020>()
        .Integer(x => x.itemSlot, 6)
        .Integer(x => x.itemDisplayId, 32)
        .Integer(x => x.itemColorSetId, 32)
        .Integer(x => x.itemDyeData, 32);
    }
  }

  public record Structure014
  {
    public Structure015? location { get; set; }
    public float yaw { get; set; }
    public float pitch { get; set; }
    public uint tileId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure014>()
        .Structure(x => x.location)
        .Float(x => x.yaw)
        .Float(x => x.pitch)
        .Integer(x => x.tileId, 32);
    }
  }

  public record Structure015
  {
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure015>()
        .Float(x => x.x)
        .Float(x => x.y)
        .Float(x => x.z);
    }
  }
}
