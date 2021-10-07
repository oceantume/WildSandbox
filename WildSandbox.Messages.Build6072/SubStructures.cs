using System;
using WildSandbox.Common.Messages;

namespace WildSandbox.Messages.Build6072
{
  public record Structure001
  {
    public uint unitId { get; set; }
    public uint infoType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure001>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.infoType, 32);
    }
  }

  public record Structure002
  {
    public uint groupId { get; set; }
    public uint tier { get; set; }
    public uint remainingMs { get; set; }
    public uint bundleCount { get; set; }
    public uint requiresOutpost { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure002>()
        .Integer(x => x.groupId, 32)
        .Integer(x => x.tier, 32)
        .Integer(x => x.remainingMs, 32)
        .Integer(x => x.bundleCount, 32)
        .Integer(x => x.requiresOutpost, 1);
    }
  }

  public record Structure003
  {
    public string? name { get; set; }
    public uint tier { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure003>()
        .String(x => x.name, true)
        .Integer(x => x.tier, 32);
    }
  }

  public record Structure004
  {
    public uint status { get; set; }
    public uint count { get; set; }
    public uint dynamicMax { get; set; }
    public float percent { get; set; }
    public uint dataType { get; set; }
    public Union001? objectiveSpecificData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure004>()
        .Integer(x => x.status, 32)
        .Integer(x => x.count, 32)
        .Integer(x => x.dynamicMax, 32)
        .Float(x => x.percent)
        .Integer(x => x.dataType, 3)
        .Union(x => x.objectiveSpecificData, x => x.dataType, matches =>
          matches
            .Match(x => x.empty, 0)
            .Match(x => x.capturePointDefendObjective, 1)
            .Match(x => x.capturePointObjective, 2)
            .Match(x => x.virtualItemDepotObjective, 3));
    }
  }

  public record Structure005
  {
    public byte empty { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure005>()
        .Integer(x => x.empty, 8);
    }
  }

  public record Structure006
  {
    public uint controllingTeam { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure006>()
        .Integer(x => x.controllingTeam, 32);
    }
  }

  public record Structure007
  {
    public uint capturingTeam { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure007>()
        .Integer(x => x.capturingTeam, 32);
    }
  }

  public record Structure008
  {
    public uint itemCount { get; set; }
    public Structure009[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure008>()
        .Integer(x => x.itemCount, 32)
        .Array(x => x.items, x => x.itemCount).OfStructure();
    }
  }

  public record Structure009
  {
    public uint itemId { get; set; }
    public uint count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure009>()
        .Integer(x => x.itemId, 32)
        .Integer(x => x.count, 32);
    }
  }

  public record Structure00A
  {
    public uint objectiveId { get; set; }
    public Structure004? objectiveStatus { get; set; }
    public uint busy { get; set; }
    public uint elapsedTimeMs { get; set; }
    public uint notificationMode { get; set; }
    public uint locationCount { get; set; }
    public uint[]? locations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure00A>()
        .Integer(x => x.objectiveId, 32)
        .Structure(x => x.objectiveStatus)
        .Integer(x => x.busy, 1)
        .Integer(x => x.elapsedTimeMs, 32)
        .Integer(x => x.notificationMode, 32)
        .Integer(x => x.locationCount, 32)
        .Array(x => x.locations, x => x.locationCount).OfInteger(32);
    }
  }

  public record Structure00B
  {
    public uint damage { get; set; }
    public uint damageReceived { get; set; }
    public uint hits { get; set; }
    public uint haters { get; set; }
    public uint kills { get; set; }
    public uint maxMultiKills { get; set; }
    public uint deaths { get; set; }
    public uint healed { get; set; }
    public uint healingReceived { get; set; }
    public uint contributions { get; set; }
    public uint longestLife { get; set; }
    public uint assists { get; set; }
    public uint saves { get; set; }
    public uint longestImpulse { get; set; }
    public uint[]? customStats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure00B>()
        .Integer(x => x.damage, 32)
        .Integer(x => x.damageReceived, 32)
        .Integer(x => x.hits, 32)
        .Integer(x => x.haters, 32)
        .Integer(x => x.kills, 32)
        .Integer(x => x.maxMultiKills, 32)
        .Integer(x => x.deaths, 32)
        .Integer(x => x.healed, 32)
        .Integer(x => x.healingReceived, 32)
        .Integer(x => x.contributions, 32)
        .Integer(x => x.longestLife, 32)
        .Integer(x => x.assists, 32)
        .Integer(x => x.saves, 32)
        .Integer(x => x.longestImpulse, 32)
        .Array(x => x.customStats, 6).OfInteger(32);
    }
  }

  public record Structure00C
  {
    public uint teamId { get; set; }
    public Structure00B? stats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure00C>()
        .Integer(x => x.teamId, 32)
        .Structure(x => x.stats);
    }
  }

  public record Structure00D
  {
    public uint teamId { get; set; }
    public uint unitId { get; set; }
    public string? name { get; set; }
    public uint classEnum { get; set; }
    public uint playerPathTypeEnum { get; set; }
    public Structure00B? stats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure00D>()
        .Integer(x => x.teamId, 32)
        .Integer(x => x.unitId, 32)
        .String(x => x.name, true)
        .Integer(x => x.classEnum, 32)
        .Integer(x => x.playerPathTypeEnum, 32)
        .Structure(x => x.stats);
    }
  }

  public record Structure00E
  {
    public uint objectiveId { get; set; }
    public uint status { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure00E>()
        .Integer(x => x.objectiveId, 32)
        .Integer(x => x.status, 32);
    }
  }

  public record Structure00F
  {
    public uint objectId { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure00F>()
        .Integer(x => x.objectId, 32)
        .Integer(x => x.type, 3);
    }
  }

  public record Structure010
  {
    public uint choice { get; set; }
    public uint count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure010>()
        .Integer(x => x.choice, 32)
        .Integer(x => x.count, 32);
    }
  }

  public record Structure011
  {
    public uint realmId { get; set; }
    public string? realmName { get; set; }
    public uint flags { get; set; }
    public uint realmStatus { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure011>()
        .Integer(x => x.realmId, 32)
        .String(x => x.realmName, true)
        .Integer(x => x.flags, 32)
        .Integer(x => x.realmStatus, 3);
    }
  }

  public record Structure012
  {
    public uint address { get; set; }
    public ushort port { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure012>()
        .Integer(x => x.address, 32)
        .Integer(x => x.port, 16);
    }
  }

  public record Structure013
  {
    public byte[]? digest { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure013>()
        .Array(x => x.digest, 20).OfInteger(8);
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

  public record Structure016
  {
    public uint type { get; set; }
    public Union002? constraint { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure016>()
        .Integer(x => x.type, 2)
        .Union(x => x.constraint, x => x.type, matches =>
          matches
            .Match(x => x.levelRange, 0)
            .Match(x => x.subString, 1));
    }
  }

  public record Structure017
  {
    public uint levelMin { get; set; }
    public uint levelLim { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure017>()
        .Integer(x => x.levelMin, 32)
        .Integer(x => x.levelLim, 32);
    }
  }

  public record Structure018
  {
    public string? substring { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure018>()
        .String(x => x.substring, true);
    }
  }

  public record Structure019
  {
    public string? name { get; set; }
    public uint level { get; set; }
    public uint race { get; set; }
    public uint classId { get; set; }
    public uint playerPathType { get; set; }
    public uint worldZoneId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure019>()
        .String(x => x.name, true)
        .Integer(x => x.level, 32)
        .Integer(x => x.race, 5)
        .Integer(x => x.classId, 5)
        .Integer(x => x.playerPathType, 3)
        .Integer(x => x.worldZoneId, 32);
    }
  }

  public record Structure01A
  {
    public uint itemSlot { get; set; }
    public uint itemDisplayId { get; set; }
    public uint itemColorSetId { get; set; }
    public uint itemDyeData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure01A>()
        .Integer(x => x.itemSlot, 6)
        .Integer(x => x.itemDisplayId, 32)
        .Integer(x => x.itemColorSetId, 32)
        .Integer(x => x.itemDyeData, 32);
    }
  }

  public record Structure01B
  {
    public ulong characterId { get; set; }
    public string? characterName { get; set; }
    public uint characterSex { get; set; }
    public uint characterRace { get; set; }
    public uint characterClass { get; set; }
    public uint characterFaction { get; set; }
    public uint characterLevel { get; set; }
    public uint bodyCount { get; set; }
    public Structure01A[]? bodyVisuals { get; set; }
    public uint equipCount { get; set; }
    public Structure01A[]? equipmentVisuals { get; set; }
    public uint worldId { get; set; }
    public uint realmId { get; set; }
    public uint instanceId { get; set; }
    public Structure014? worldLocation { get; set; }
    public uint characterPath { get; set; }
    public uint boneCustomizationCount { get; set; }
    public float[]? boneCustomizations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure01B>()
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

  public record Structure01C
  {
    public uint m_msgId { get; set; }
    public uint m_generalVoId { get; set; }
    public byte m_numActors { get; set; }
    public Structure01D[]? m_actors { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure01C>()
        .Integer(x => x.m_msgId, 32)
        .Integer(x => x.m_generalVoId, 32)
        .Integer(x => x.m_numActors, 8)
        .Array(x => x.m_actors, x => x.m_numActors).OfStructure();
    }
  }

  public record Structure01D
  {
    public uint m_type { get; set; }
    public Union003? m_data { get; set; }
    public uint m_count { get; set; }
    public string? m_name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure01D>()
        .Integer(x => x.m_type, 3)
        .Union(x => x.m_data, x => x.m_type, matches =>
          matches
            .Match(x => x.creature, 0)
            .Match(x => x.@string, 1)
            .Match(x => x.textid, 2)
            .Match(x => x.playerunit, 3)
            .Match(x => x.creatureunit, 4)
            .Match(x => x.localplayer, 5))
        .Integer(x => x.m_count, 32)
        .String(x => x.m_name, false);
    }
  }

  public record Structure01E
  {
    public uint m_creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure01E>()
        .Integer(x => x.m_creatureId, 32);
    }
  }

  public record Structure01F
  {
    public string? m_str { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure01F>()
        .String(x => x.m_str, true);
    }
  }

  public record Structure020
  {
    public uint m_id { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure020>()
        .Integer(x => x.m_id, 32);
    }
  }

  public record Structure021
  {
    public uint m_unitId { get; set; }
    public string? m_name { get; set; }
    public uint m_level { get; set; }
    public uint m_gender { get; set; }
    public uint m_race { get; set; }
    public uint m_class { get; set; }
    public uint m_faction { get; set; }
    public uint m_path { get; set; }
    public uint m_title { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure021>()
        .Integer(x => x.m_unitId, 32)
        .String(x => x.m_name, true)
        .Integer(x => x.m_level, 32)
        .Integer(x => x.m_gender, 2)
        .Integer(x => x.m_race, 5)
        .Integer(x => x.m_class, 5)
        .Integer(x => x.m_faction, 32)
        .Integer(x => x.m_path, 32)
        .Integer(x => x.m_title, 32);
    }
  }

  public record Structure022
  {
    public uint m_unitId { get; set; }
    public uint m_creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure022>()
        .Integer(x => x.m_unitId, 32)
        .Integer(x => x.m_creatureId, 32);
    }
  }

  public record Structure023
  {
    public uint m_unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure023>()
        .Integer(x => x.m_unitId, 32);
    }
  }

  public record Structure024
  {
    public uint realmId { get; set; }
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure024>()
        .Integer(x => x.realmId, 32)
        .Integer(x => x.characterId, 64);
    }
  }

  public record Structure025
  {
    public Structure024? identity { get; set; }
    public uint flags { get; set; }
    public Structure026? character { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure025>()
        .Structure(x => x.identity)
        .Integer(x => x.flags, 32)
        .Structure(x => x.character);
    }
  }

  public record Structure026
  {
    public string? name { get; set; }
    public uint factionId { get; set; }
    public uint raceId { get; set; }
    public uint classId { get; set; }
    public uint level { get; set; }
    public uint pathType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure026>()
        .String(x => x.name, true)
        .Integer(x => x.factionId, 32)
        .Integer(x => x.raceId, 32)
        .Integer(x => x.classId, 32)
        .Integer(x => x.level, 32)
        .Integer(x => x.pathType, 3);
    }
  }

  public record Structure027
  {
    public uint leaderIndex { get; set; }
    public uint inviterIndex { get; set; }
    public uint count { get; set; }
    public Structure026[]? characters { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure027>()
        .Integer(x => x.leaderIndex, 32)
        .Integer(x => x.inviterIndex, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.characters, x => x.count).OfStructure();
    }
  }

  public record Structure028
  {
    public ulong groupId { get; set; }
    public uint flags { get; set; }
    public uint count { get; set; }
    public uint maxSize { get; set; }
    public uint lootRuleNormal { get; set; }
    public uint lootRuleThreshold { get; set; }
    public uint lootThreshold { get; set; }
    public Structure025[]? members { get; set; }
    public Structure024? leaderIdentity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure028>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.flags, 32)
        .Integer(x => x.count, 32)
        .Integer(x => x.maxSize, 32)
        .Integer(x => x.lootRuleNormal, 3)
        .Integer(x => x.lootRuleThreshold, 3)
        .Integer(x => x.lootThreshold, 4)
        .Array(x => x.members, x => x.count).OfStructure()
        .Structure(x => x.leaderIdentity);
    }
  }

  public record Structure029
  {
    public uint channelId { get; set; }
    public ulong chatId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure029>()
        .Integer(x => x.channelId, 32)
        .Integer(x => x.chatId, 64);
    }
  }

  public record Structure02A
  {
    public string? text { get; set; }
    public uint count { get; set; }
    public Structure02B[]? format { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure02A>()
        .String(x => x.text, true)
        .Integer(x => x.count, 32)
        .Array(x => x.format, x => x.count).OfStructure();
    }
  }

  public record Structure02B
  {
    public uint type { get; set; }
    public ushort startIndex { get; set; }
    public ushort stopIndex { get; set; }
    public uint data { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure02B>()
        .Integer(x => x.type, 3)
        .Integer(x => x.startIndex, 16)
        .Integer(x => x.stopIndex, 16)
        .Integer(x => x.data, 32);
    }
  }

  public record Structure02C
  {
    public uint locationType { get; set; }
    public uint bagIndex { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure02C>()
        .Integer(x => x.locationType, 32)
        .Integer(x => x.bagIndex, 32);
    }
  }

  public record Structure02D
  {
    public ulong uniqueId { get; set; }
    public uint objectId { get; set; }
    public Structure02C? location { get; set; }
    public uint stackCount { get; set; }
    public uint charges { get; set; }
    public ulong randomCircuitData { get; set; }
    public ulong thresholdData { get; set; }
    public float durability { get; set; }
    public uint dyeData { get; set; }
    public uint dynamicFlags { get; set; }
    public uint microchipCount { get; set; }
    public uint[]? microchips { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure02D>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.objectId, 32)
        .Structure(x => x.location)
        .Integer(x => x.stackCount, 32)
        .Integer(x => x.charges, 32)
        .Integer(x => x.randomCircuitData, 64)
        .Integer(x => x.thresholdData, 64)
        .Float(x => x.durability)
        .Integer(x => x.dyeData, 32)
        .Integer(x => x.dynamicFlags, 32)
        .Integer(x => x.microchipCount, 32)
        .Array(x => x.microchips, x => x.microchipCount).OfInteger(32);
    }
  }

  public record Structure02E
  {
    public uint unitId { get; set; }
    public uint summoningSpell { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure02E>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.summoningSpell, 32);
    }
  }

  public record Structure02F
  {
    public Structure02D? item { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure02F>()
        .Structure(x => x.item);
    }
  }

  public record Structure030
  {
    public uint factionId { get; set; }
    public ushort factionCount { get; set; }
    public Structure031[]? factionReputations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure030>()
        .Integer(x => x.factionId, 32)
        .Integer(x => x.factionCount, 16)
        .Array(x => x.factionReputations, x => x.factionCount).OfStructure();
    }
  }

  public record Structure031
  {
    public uint factionId { get; set; }
    public float value { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure031>()
        .Integer(x => x.factionId, 32)
        .Float(x => x.value);
    }
  }

  public record Structure032
  {
    public uint missionId { get; set; }
    public uint completed { get; set; }
    public uint userdata { get; set; }
    public uint statedata { get; set; }
    public uint reason { get; set; }
    public uint giver { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure032>()
        .Integer(x => x.missionId, 32)
        .Integer(x => x.completed, 1)
        .Integer(x => x.userdata, 32)
        .Integer(x => x.statedata, 32)
        .Integer(x => x.reason, 32)
        .Integer(x => x.giver, 32);
    }
  }

  public record Structure033
  {
    public uint missionId { get; set; }
    public uint completed { get; set; }
    public uint userdata { get; set; }
    public uint statedata { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure033>()
        .Integer(x => x.missionId, 32)
        .Integer(x => x.completed, 1)
        .Integer(x => x.userdata, 32)
        .Integer(x => x.statedata, 32);
    }
  }

  public record Structure034
  {
    public uint inputActionId { get; set; }
    public uint deviceEnum00 { get; set; }
    public uint deviceEnum01 { get; set; }
    public uint code00 { get; set; }
    public uint code01 { get; set; }
    public uint metaKeys00 { get; set; }
    public uint metaKeys01 { get; set; }
    public uint eventTypeEnum00 { get; set; }
    public uint eventTypeEnum01 { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure034>()
        .Integer(x => x.inputActionId, 32)
        .Integer(x => x.deviceEnum00, 32)
        .Integer(x => x.deviceEnum01, 32)
        .Integer(x => x.code00, 32)
        .Integer(x => x.code01, 32)
        .Integer(x => x.metaKeys00, 32)
        .Integer(x => x.metaKeys01, 32)
        .Integer(x => x.eventTypeEnum00, 32)
        .Integer(x => x.eventTypeEnum01, 32);
    }
  }

  public record Structure035
  {
    public uint shortcutType { get; set; }
    public Structure02C? location { get; set; }
    public uint objectId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure035>()
        .Integer(x => x.shortcutType, 32)
        .Structure(x => x.location)
        .Integer(x => x.objectId, 32);
    }
  }

  public record Structure036
  {
    public uint uniqueId { get; set; }
    public uint itemId { get; set; }
    public uint quantity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure036>()
        .Integer(x => x.uniqueId, 32)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.quantity, 32);
    }
  }

  public record Structure037
  {
    public ulong petId { get; set; }
    public uint creatureId { get; set; }
    public uint unitId { get; set; }
    public uint modelInfoId { get; set; }
    public uint petPoints { get; set; }
    public uint slot { get; set; }
    public uint teamSlot { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure037>()
        .Integer(x => x.petId, 64)
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.unitId, 32)
        .Integer(x => x.modelInfoId, 32)
        .Integer(x => x.petPoints, 32)
        .Integer(x => x.slot, 32)
        .Integer(x => x.teamSlot, 32)
        .String(x => x.name, true);
    }
  }

  public record Structure038
  {
    public uint titleId { get; set; }
    public uint revoked { get; set; }
    public uint inSchedule { get; set; }
    public uint timeRemaining { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure038>()
        .Integer(x => x.titleId, 32)
        .Integer(x => x.revoked, 1)
        .Integer(x => x.inSchedule, 1)
        .Integer(x => x.timeRemaining, 32);
    }
  }

  public record Structure039
  {
    public uint datacubeId { get; set; }
    public uint progress { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure039>()
        .Integer(x => x.datacubeId, 32)
        .Integer(x => x.progress, 32);
    }
  }

  public record Structure03A
  {
    public uint volumeId { get; set; }
    public uint volumeProgress { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure03A>()
        .Integer(x => x.volumeId, 32)
        .Integer(x => x.volumeProgress, 32);
    }
  }

  public record Structure03B
  {
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure03B>()
        .Integer(x => x.m_questId, 32);
    }
  }

  public record Structure03C
  {
    public uint m_questId { get; set; }
    public uint m_state { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure03C>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_state, 32);
    }
  }

  public record Structure03D
  {
    public uint m_questId { get; set; }
    public uint m_state { get; set; }
    public uint m_randomResultId { get; set; }
    public uint m_flags { get; set; }
    public uint m_objCount { get; set; }
    public uint[]? m_objCompleted { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure03D>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_state, 32)
        .Integer(x => x.m_randomResultId, 32)
        .Integer(x => x.m_flags, 32)
        .Integer(x => x.m_objCount, 32)
        .Array(x => x.m_objCompleted, x => x.m_objCount).OfInteger(32);
    }
  }

  public record Structure03E
  {
    public uint m_type { get; set; }
    public Union004? m_data { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure03E>()
        .Integer(x => x.m_type, 32)
        .Union(x => x.m_data, x => x.m_type, matches =>
          matches
            .Match(x => x.integer, 0)
            .Match(x => x.str, 1)
            .Match(x => x.unit, 2)
            .Match(x => x.boolean, 3)
            .Match(x => x.itemdata, 4)
            .Match(x => x.quest, 5));
    }
  }

  public record Structure03F
  {
    public uint m_integer { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure03F>()
        .Integer(x => x.m_integer, 32);
    }
  }

  public record Structure040
  {
    public string? m_string { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure040>()
        .String(x => x.m_string, false);
    }
  }

  public record Structure041
  {
    public uint m_unit { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure041>()
        .Integer(x => x.m_unit, 32);
    }
  }

  public record Structure042
  {
    public uint m_boolean { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure042>()
        .Integer(x => x.m_boolean, 1);
    }
  }

  public record Structure043
  {
    public uint m_itemdata { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure043>()
        .Integer(x => x.m_itemdata, 32);
    }
  }

  public record Structure044
  {
    public uint m_quest { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure044>()
        .Integer(x => x.m_quest, 32);
    }
  }

  public record Structure045
  {
    public ulong id { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure045>()
        .Integer(x => x.id, 64);
    }
  }

  public record Structure046
  {
    public uint rank { get; set; }
    public ulong data { get; set; }
    public string? who { get; set; }
    public uint operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure046>()
        .Integer(x => x.rank, 32)
        .Integer(x => x.data, 64)
        .String(x => x.who, true)
        .Integer(x => x.operation, 5);
    }
  }

  public record Structure047
  {
    public uint type { get; set; }
    public string? name { get; set; }
    public string? masterRankName { get; set; }
    public string? councilRankName { get; set; }
    public string? memberRankName { get; set; }
    public Structure048? emblem { get; set; }
    public Structure049? standard { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure047>()
        .Integer(x => x.type, 3)
        .String(x => x.name, true)
        .String(x => x.masterRankName, true)
        .String(x => x.councilRankName, true)
        .String(x => x.memberRankName, true)
        .Structure(x => x.emblem)
        .Structure(x => x.standard);
    }
  }

  public record Structure048
  {
    public uint id { get; set; }
    public uint colorId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure048>()
        .Integer(x => x.id, 32)
        .Integer(x => x.colorId, 32);
    }
  }

  public record Structure049
  {
    public Structure04A? shape { get; set; }
    public Structure04A? pattern { get; set; }
    public Structure04A? trim { get; set; }
    public Structure04A? backgroundIcon { get; set; }
    public Structure04A? foregroundIcon { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure049>()
        .Structure(x => x.shape)
        .Structure(x => x.pattern)
        .Structure(x => x.trim)
        .Structure(x => x.backgroundIcon)
        .Structure(x => x.foregroundIcon);
    }
  }

  public record Structure04A
  {
    public uint id { get; set; }
    public uint dieColorRampId1 { get; set; }
    public uint dieColorRampId2 { get; set; }
    public uint dieColorRampId3 { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure04A>()
        .Integer(x => x.id, 32)
        .Integer(x => x.dieColorRampId1, 32)
        .Integer(x => x.dieColorRampId2, 32)
        .Integer(x => x.dieColorRampId3, 32);
    }
  }

  public record Structure04B
  {
    public ulong id { get; set; }
    public uint unitId { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure04B>()
        .Integer(x => x.id, 64)
        .Integer(x => x.unitId, 32)
        .Integer(x => x.type, 3);
    }
  }

  public record Structure04C
  {
    public string? name { get; set; }
    public Structure048? emblem { get; set; }
    public Structure049? standard { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure04C>()
        .String(x => x.name, true)
        .Structure(x => x.emblem)
        .Structure(x => x.standard);
    }
  }

  public record Structure04D
  {
    public ulong characterItemIdFrom { get; set; }
    public ulong characterItemIdTo { get; set; }
    public Structure02C? locationFrom { get; set; }
    public Structure02C? locationTo { get; set; }
    public uint stackCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure04D>()
        .Integer(x => x.characterItemIdFrom, 64)
        .Integer(x => x.characterItemIdTo, 64)
        .Structure(x => x.locationFrom)
        .Structure(x => x.locationTo)
        .Integer(x => x.stackCount, 32);
    }
  }

  public record Structure04E
  {
    public ulong id { get; set; }
    public string? guildName { get; set; }
    public uint flags { get; set; }
    public uint type { get; set; }
    public Structure04F[]? ranks { get; set; }
    public Structure048? emblem { get; set; }
    public Structure049? standard { get; set; }
    public uint memberCount { get; set; }
    public uint onlineMemberCount { get; set; }
    public uint influence { get; set; }
    public ulong money { get; set; }
    public uint bankTabCount { get; set; }
    public string[]? bankTabName { get; set; }
    public uint pvpWins { get; set; }
    public uint pvpLosses { get; set; }
    public uint pvpDraws { get; set; }
    public uint pvpRating { get; set; }
    public uint pvpSeason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure04E>()
        .Integer(x => x.id, 64)
        .String(x => x.guildName, true)
        .Integer(x => x.flags, 32)
        .Integer(x => x.type, 3)
        .Array(x => x.ranks, 10).OfStructure()
        .Structure(x => x.emblem)
        .Structure(x => x.standard)
        .Integer(x => x.memberCount, 32)
        .Integer(x => x.onlineMemberCount, 32)
        .Integer(x => x.influence, 32)
        .Integer(x => x.money, 64)
        .Integer(x => x.bankTabCount, 32)
        .Array(x => x.bankTabName, 10).OfString(true)
        .Integer(x => x.pvpWins, 32)
        .Integer(x => x.pvpLosses, 32)
        .Integer(x => x.pvpDraws, 32)
        .Integer(x => x.pvpRating, 32)
        .Integer(x => x.pvpSeason, 32);
    }
  }

  public record Structure04F
  {
    public string? name { get; set; }
    public uint permissions { get; set; }
    public ulong bankPermissions { get; set; }
    public ulong moneyWithdrawnPerDay { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure04F>()
        .String(x => x.name, true)
        .Integer(x => x.permissions, 32)
        .Integer(x => x.bankPermissions, 64)
        .Integer(x => x.moneyWithdrawnPerDay, 64);
    }
  }

  public record Structure050
  {
    public Structure024? identity { get; set; }
    public uint rank { get; set; }
    public string? memberName { get; set; }
    public uint classType { get; set; }
    public uint pathType { get; set; }
    public uint level { get; set; }
    public float lastLogoutTimeDays { get; set; }
    public uint pvpWins { get; set; }
    public uint pvpLosses { get; set; }
    public uint pvpDraws { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure050>()
        .Structure(x => x.identity)
        .Integer(x => x.rank, 32)
        .String(x => x.memberName, true)
        .Integer(x => x.classType, 32)
        .Integer(x => x.pathType, 32)
        .Integer(x => x.level, 32)
        .Float(x => x.lastLogoutTimeDays)
        .Integer(x => x.pvpWins, 32)
        .Integer(x => x.pvpLosses, 32)
        .Integer(x => x.pvpDraws, 32);
    }
  }

  public record Structure051
  {
    public ulong bankWithdrawnMoney { get; set; }
    public uint[]? bankTabWithdrawCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure051>()
        .Integer(x => x.bankWithdrawnMoney, 64)
        .Array(x => x.bankTabWithdrawCount, 10).OfInteger(32);
    }
  }

  public record Structure052
  {
    public uint unitId { get; set; }
    public uint targetFlags { get; set; }
    public Structure015? initialPosition { get; set; }
    public float initialYaw { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure052>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.targetFlags, 32)
        .Structure(x => x.initialPosition)
        .Float(x => x.initialYaw);
    }
  }

  public record Structure053
  {
    public uint telegraphId { get; set; }
    public uint attachedUnitId { get; set; }
    public uint targetFlags { get; set; }
    public Structure015? position { get; set; }
    public float yaw { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure053>()
        .Integer(x => x.telegraphId, 32)
        .Integer(x => x.attachedUnitId, 32)
        .Integer(x => x.targetFlags, 32)
        .Structure(x => x.position)
        .Float(x => x.yaw);
    }
  }

  public record Structure054
  {
    public uint unitId { get; set; }
    public byte ndx { get; set; }
    public byte targetFlags { get; set; }
    public uint combatResult { get; set; }
    public byte effectCount { get; set; }
    public Structure055[]? effectInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure054>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.ndx, 8)
        .Integer(x => x.targetFlags, 8)
        .Integer(x => x.combatResult, 3)
        .Integer(x => x.effectCount, 8)
        .Array(x => x.effectInfo, x => x.effectCount).OfStructure();
    }
  }

  public record Structure055
  {
    public uint effectId { get; set; }
    public uint delayTime { get; set; }
    public uint elapsedTime { get; set; }
    public uint timeRemaining { get; set; }
    public uint infoType { get; set; }
    public Union005? info { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure055>()
        .Integer(x => x.effectId, 32)
        .Integer(x => x.delayTime, 32)
        .Integer(x => x.elapsedTime, 32)
        .Integer(x => x.timeRemaining, 32)
        .Integer(x => x.infoType, 2)
        .Union(x => x.info, x => x.infoType, matches =>
          matches
            .Match(x => x.empty, 0)
            .Match(x => x.damageDesc, 1));
    }
  }

  public record Structure056
  {
    public byte dummy { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure056>()
        .Integer(x => x.dummy, 0);
    }
  }

  public record Structure057
  {
    public uint rawDamage { get; set; }
    public uint absorbedAmount { get; set; }
    public uint shieldAbsorbAmount { get; set; }
    public uint adjustedDamage { get; set; }
    public uint killedTarget { get; set; }
    public uint combatResult { get; set; }
    public uint damageType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure057>()
        .Integer(x => x.rawDamage, 32)
        .Integer(x => x.absorbedAmount, 32)
        .Integer(x => x.shieldAbsorbAmount, 32)
        .Integer(x => x.adjustedDamage, 32)
        .Integer(x => x.killedTarget, 1)
        .Integer(x => x.combatResult, 3)
        .Integer(x => x.damageType, 2);
    }
  }

  public record Structure058
  {
    public Structure015? casterPosition { get; set; }
    public uint missileTravelTime { get; set; }
    public uint targetId { get; set; }
    public Structure015? targetPosition { get; set; }
    public uint hitPosition { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure058>()
        .Structure(x => x.casterPosition)
        .Integer(x => x.missileTravelTime, 32)
        .Integer(x => x.targetId, 32)
        .Structure(x => x.targetPosition)
        .Integer(x => x.hitPosition, 1);
    }
  }

  public record Structure059
  {
    public uint unitId { get; set; }
    public uint result { get; set; }
    public uint delay { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure059>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.result, 3)
        .Integer(x => x.delay, 32);
    }
  }

  public record Structure05A
  {
    public uint serverUniqueId { get; set; }
    public uint sourceUnitId { get; set; }
    public uint visualEffectId { get; set; }
    public uint timeElapsed { get; set; }
    public Structure015? sourceLocation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure05A>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.sourceUnitId, 32)
        .Integer(x => x.visualEffectId, 32)
        .Integer(x => x.timeElapsed, 32)
        .Structure(x => x.sourceLocation);
    }
  }

  public record Structure05B
  {
    public uint missileRecId { get; set; }
    public uint sourceUnitId { get; set; }
    public Structure015? sourcePosition { get; set; }
    public uint targetUnitId { get; set; }
    public Structure015? targetPosition { get; set; }
    public uint serverUniqueId { get; set; }
    public uint timeElapsed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure05B>()
        .Integer(x => x.missileRecId, 32)
        .Integer(x => x.sourceUnitId, 32)
        .Structure(x => x.sourcePosition)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.targetPosition)
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.timeElapsed, 32);
    }
  }

  public record Structure05C
  {
    public uint serverUniqueId { get; set; }
    public uint targetId { get; set; }
    public uint instanceCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure05C>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.targetId, 32)
        .Integer(x => x.instanceCount, 32);
    }
  }

  public record Structure05D
  {
    public uint casterId { get; set; }
    public uint originalTargetId { get; set; }
    public uint serverUniqueId { get; set; }
    public uint spellId { get; set; }
    public uint targetCount { get; set; }
    public Structure054[]? targetInfo { get; set; }
    public byte initialPositionCount { get; set; }
    public Structure052[]? initialPositions { get; set; }
    public byte telegraphPositionCount { get; set; }
    public Structure053[]? telegraphPositions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure05D>()
        .Integer(x => x.casterId, 32)
        .Integer(x => x.originalTargetId, 32)
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.spellId, 32)
        .Integer(x => x.targetCount, 32)
        .Array(x => x.targetInfo, x => x.targetCount).OfStructure()
        .Integer(x => x.initialPositionCount, 8)
        .Array(x => x.initialPositions, x => x.initialPositionCount).OfStructure()
        .Integer(x => x.telegraphPositionCount, 8)
        .Array(x => x.telegraphPositions, x => x.telegraphPositionCount).OfStructure();
    }
  }

  public record Structure05E
  {
    public uint type { get; set; }
    public uint spellId { get; set; }
    public uint typeId { get; set; }
    public uint timeRemaining { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure05E>()
        .Integer(x => x.type, 3)
        .Integer(x => x.spellId, 32)
        .Integer(x => x.typeId, 32)
        .Integer(x => x.timeRemaining, 32);
    }
  }

  public record Structure05F
  {
    public uint creatureId { get; set; }
    public uint questChecklistIdx { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure05F>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.questChecklistIdx, 32);
    }
  }

  public record Structure060
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure060>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure061
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure061>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure062
  {
    public uint creatureId { get; set; }
    public uint unitVehicleId { get; set; }
    public uint count { get; set; }
    public Structure063[]? passengers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure062>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.unitVehicleId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.passengers, x => x.count).OfStructure();
    }
  }

  public record Structure063
  {
    public uint seatType { get; set; }
    public uint seatPosition { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure063>()
        .Integer(x => x.seatType, 32)
        .Integer(x => x.seatPosition, 32)
        .Integer(x => x.unitId, 32);
    }
  }

  public record Structure064
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure064>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure065
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure065>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure066
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure066>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure067
  {
    public uint creatureId { get; set; }
    public uint unitVehicleId { get; set; }
    public uint count { get; set; }
    public Structure063[]? passengers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure067>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.unitVehicleId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.passengers, x => x.count).OfStructure();
    }
  }

  public record Structure068
  {
    public uint creatureId { get; set; }
    public uint questChecklistIdx { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure068>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.questChecklistIdx, 32);
    }
  }

  public record Structure069
  {
    public uint creatureId { get; set; }
    public uint unitVehicleId { get; set; }
    public uint count { get; set; }
    public Structure063[]? passengers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure069>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.unitVehicleId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.passengers, x => x.count).OfStructure();
    }
  }

  public record Structure06A
  {
    public uint creatureId { get; set; }
    public uint questChecklistIdx { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure06A>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.questChecklistIdx, 32);
    }
  }

  public record Structure06B
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure06B>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure06C
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure06C>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure06D
  {
    public uint creatureId { get; set; }
    public uint questChecklistIdx { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure06D>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.questChecklistIdx, 32);
    }
  }

  public record Structure06E
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure06E>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure06F
  {
    public uint socketId { get; set; }
    public uint plugId { get; set; }
    public uint plugFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure06F>()
        .Integer(x => x.socketId, 32)
        .Integer(x => x.plugId, 32)
        .Integer(x => x.plugFlags, 32);
    }
  }

  public record Structure070
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure070>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure071
  {
    public uint creatureId { get; set; }
    public uint itemId { get; set; }
    public uint itemCount { get; set; }
    public uint lootType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure071>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.itemCount, 32)
        .Integer(x => x.lootType, 32);
    }
  }

  public record Structure072
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure072>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure073
  {
    public ulong characterId { get; set; }
    public uint realmId { get; set; }
    public string? name { get; set; }
    public uint raceId { get; set; }
    public uint classId { get; set; }
    public uint sex { get; set; }
    public ulong groupId { get; set; }
    public uint petCount { get; set; }
    public uint[]? petIdList { get; set; }
    public string? guildName { get; set; }
    public uint guildType { get; set; }
    public uint guildEmblemId { get; set; }
    public uint guildEmblemColorId { get; set; }
    public byte guildCount { get; set; }
    public ulong[]? guildIds { get; set; }
    public ulong residenceId { get; set; }
    public ulong neighborhoodId { get; set; }
    public ushort boneCustomizationCount { get; set; }
    public float[]? boneCustomizationList { get; set; }
    public uint pvpFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure073>()
        .Integer(x => x.characterId, 64)
        .Integer(x => x.realmId, 32)
        .String(x => x.name, true)
        .Integer(x => x.raceId, 5)
        .Integer(x => x.classId, 5)
        .Integer(x => x.sex, 2)
        .Integer(x => x.groupId, 64)
        .Integer(x => x.petCount, 32)
        .Array(x => x.petIdList, x => x.petCount).OfInteger(32)
        .String(x => x.guildName, true)
        .Integer(x => x.guildType, 3)
        .Integer(x => x.guildEmblemId, 32)
        .Integer(x => x.guildEmblemColorId, 32)
        .Integer(x => x.guildCount, 8)
        .Array(x => x.guildIds, x => x.guildCount).OfInteger(64)
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.neighborhoodId, 64)
        .Integer(x => x.boneCustomizationCount, 16)
        .Array(x => x.boneCustomizationList, x => x.boneCustomizationCount).OfFloat()
        .Integer(x => x.pvpFlags, 32);
    }
  }

  public record Structure074
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure074>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure075
  {
    public string? name { get; set; }
    public byte boundsCount { get; set; }
    public Structure076[]? bounds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure075>()
        .String(x => x.name, true)
        .Integer(x => x.boundsCount, 8)
        .Array(x => x.bounds, x => x.boundsCount).OfStructure();
    }
  }

  public record Structure076
  {
    public uint type { get; set; }
    public Structure015? min { get; set; }
    public Structure015? lim { get; set; }
    public float radius { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure076>()
        .Integer(x => x.type, 2)
        .Structure(x => x.min)
        .Structure(x => x.lim)
        .Float(x => x.radius);
    }
  }

  public record Structure077
  {
    public ulong characterId { get; set; }
    public uint realmId { get; set; }
    public string? name { get; set; }
    public uint raceId { get; set; }
    public uint classId { get; set; }
    public uint sex { get; set; }
    public ulong groupId { get; set; }
    public string? guildName { get; set; }
    public uint guildType { get; set; }
    public uint guildEmblemId { get; set; }
    public uint guildEmblemColorId { get; set; }
    public byte guildCount { get; set; }
    public ulong[]? guildIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure077>()
        .Integer(x => x.characterId, 64)
        .Integer(x => x.realmId, 32)
        .String(x => x.name, true)
        .Integer(x => x.raceId, 5)
        .Integer(x => x.classId, 5)
        .Integer(x => x.sex, 2)
        .Integer(x => x.groupId, 64)
        .String(x => x.guildName, true)
        .Integer(x => x.guildType, 3)
        .Integer(x => x.guildEmblemId, 32)
        .Integer(x => x.guildEmblemColorId, 32)
        .Integer(x => x.guildCount, 8)
        .Array(x => x.guildIds, x => x.guildCount).OfInteger(64);
    }
  }

  public record Structure078
  {
    public uint creatureId { get; set; }
    public uint ownerId { get; set; }
    public uint ownerDisplayItemId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure078>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.ownerDisplayItemId, 32)
        .String(x => x.name, true);
    }
  }

  public record Structure079
  {
    public uint creatureId { get; set; }
    public uint ownerId { get; set; }
    public uint ownerDisplayItemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure079>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.ownerDisplayItemId, 32);
    }
  }

  public record Structure07A
  {
    public uint dummyVar { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure07A>()
        .Integer(x => x.dummyVar, 32);
    }
  }

  public record Structure07B
  {
    public uint creatureId { get; set; }
    public uint ownerId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure07B>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.ownerId, 32)
        .String(x => x.name, true);
    }
  }

  public record Structure07C
  {
    public uint dummyVar { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure07C>()
        .Integer(x => x.dummyVar, 32);
    }
  }

  public record Structure07D
  {
    public uint creatureId { get; set; }
    public uint ownerId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure07D>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.ownerId, 32);
    }
  }

  public record Structure07E
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure07E>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure07F
  {
    public uint creatureId { get; set; }
    public uint ownerId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure07F>()
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.ownerId, 32);
    }
  }

  public record Structure080
  {
    public uint creatureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure080>()
        .Integer(x => x.creatureId, 32);
    }
  }

  public record Structure081
  {
    public uint stat { get; set; }
    public uint newValue { get; set; }
    public uint data { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure081>()
        .Integer(x => x.stat, 5)
        .Integer(x => x.newValue, 32)
        .Integer(x => x.data, 32)
        .Integer(x => x.reason, 4);
    }
  }

  public record Structure082
  {
    public uint type { get; set; }
    public Union007? data { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure082>()
        .Integer(x => x.type, 5)
        .Union(x => x.data, x => x.type, matches =>
          matches
            .Match(x => x.setTime, 0)
            .Match(x => x.setPlatform, 1)
            .Match(x => x.setPosition, 2)
            .Match(x => x.setPositionKeys, 3)
            .Match(x => x.setPositionPath, 4)
            .Match(x => x.setPositionSpline, 5)
            .Match(x => x.setPositionProjectile, 6)
            .Match(x => x.setVelocity, 7)
            .Match(x => x.setVelocityKeys, 8)
            .Match(x => x.setVelocityDefault, 9)
            .Match(x => x.setMove, 10)
            .Match(x => x.setMoveKeys, 11)
            .Match(x => x.setMoveDefault, 12)
            .Match(x => x.setRotation, 13)
            .Match(x => x.setRotationKeys, 14)
            .Match(x => x.setRotationSpline, 15)
            .Match(x => x.setRotationFaceUnit, 16)
            .Match(x => x.setRotationFacePosition, 17)
            .Match(x => x.setRotationSpin, 18)
            .Match(x => x.setRotationDefault, 19)
            .Match(x => x.setScale, 20)
            .Match(x => x.setScaleKeys, 21)
            .Match(x => x.setState, 22)
            .Match(x => x.setStateKeys, 23)
            .Match(x => x.setStateDefault, 24)
            .Match(x => x.setMode, 25)
            .Match(x => x.setModeKeys, 26)
            .Match(x => x.setModeDefault, 27));
    }
  }

  public record Structure083
  {
    public uint time { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure083>()
        .Integer(x => x.time, 32);
    }
  }

  public record Structure084
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure084>()
        .Integer(x => x.unitId, 32);
    }
  }

  public record Structure085
  {
    public Structure086? position { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure085>()
        .Structure(x => x.position)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure086
  {
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure086>()
        .Float(x => x.x)
        .Float(x => x.y)
        .Float(x => x.z);
    }
  }

  public record Structure087
  {
    public uint count { get; set; }
    public uint[]? times { get; set; }
    public Structure015[]? positions { get; set; }
    public uint type { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure087>()
        .Integer(x => x.count, 32)
        .Array(x => x.times, x => x.count).OfInteger(32)
        .Array(x => x.positions, x => x.count).OfStructure()
        .Integer(x => x.type, 2)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure088
  {
    public uint count { get; set; }
    public Structure015[]? positions { get; set; }
    public float speed { get; set; }
    public uint type { get; set; }
    public uint mode { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure088>()
        .Integer(x => x.count, 32)
        .Array(x => x.positions, x => x.count).OfStructure()
        .Float(x => x.speed)
        .Integer(x => x.type, 2)
        .Integer(x => x.mode, 4)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure089
  {
    public uint splineId { get; set; }
    public float speed { get; set; }
    public float position { get; set; }
    public Structure086? formation { get; set; }
    public uint mode { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }
    public uint isContinuing { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure089>()
        .Integer(x => x.splineId, 32)
        .Float(x => x.speed)
        .Float(x => x.position)
        .Structure(x => x.formation)
        .Integer(x => x.mode, 4)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1)
        .Integer(x => x.isContinuing, 1);
    }
  }

  public record Structure08A
  {
    public Structure086? position { get; set; }
    public uint flightTime { get; set; }
    public float gravity { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure08A>()
        .Structure(x => x.position)
        .Integer(x => x.flightTime, 32)
        .Float(x => x.gravity)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure08B
  {
    public Structure086? velocity { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure08B>()
        .Structure(x => x.velocity)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure08C
  {
    public uint count { get; set; }
    public uint[]? times { get; set; }
    public Structure015[]? velocities { get; set; }
    public uint type { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure08C>()
        .Integer(x => x.count, 32)
        .Array(x => x.times, x => x.count).OfInteger(32)
        .Array(x => x.velocities, x => x.count).OfStructure()
        .Integer(x => x.type, 2)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure08D
  {
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure08D>()
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure08E
  {
    public Structure086? move { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure08E>()
        .Structure(x => x.move)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure08F
  {
    public uint count { get; set; }
    public uint[]? times { get; set; }
    public Structure015[]? moves { get; set; }
    public uint type { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure08F>()
        .Integer(x => x.count, 32)
        .Array(x => x.times, x => x.count).OfInteger(32)
        .Array(x => x.moves, x => x.count).OfStructure()
        .Integer(x => x.type, 2)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure090
  {
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure090>()
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure091
  {
    public Structure092? rotation { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure091>()
        .Structure(x => x.rotation)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure092
  {
    public float yaw { get; set; }
    public float pitch { get; set; }
    public float roll { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure092>()
        .Float(x => x.yaw)
        .Float(x => x.pitch)
        .Float(x => x.roll);
    }
  }

  public record Structure093
  {
    public uint count { get; set; }
    public uint[]? times { get; set; }
    public Structure092[]? rotations { get; set; }
    public uint type { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure093>()
        .Integer(x => x.count, 32)
        .Array(x => x.times, x => x.count).OfInteger(32)
        .Array(x => x.rotations, x => x.count).OfStructure()
        .Integer(x => x.type, 2)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure094
  {
    public uint splineId { get; set; }
    public float speed { get; set; }
    public float position { get; set; }
    public uint mode { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure094>()
        .Integer(x => x.splineId, 32)
        .Float(x => x.speed)
        .Float(x => x.position)
        .Integer(x => x.mode, 4)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure095
  {
    public uint unitId { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure095>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure096
  {
    public Structure086? position { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure096>()
        .Structure(x => x.position)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure097
  {
    public Structure092? rotation { get; set; }
    public uint flightTime { get; set; }
    public float spin { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure097>()
        .Structure(x => x.rotation)
        .Integer(x => x.flightTime, 32)
        .Float(x => x.spin)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure098
  {
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure098>()
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure099
  {
    public float scale { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure099>()
        .Float(x => x.scale)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure09A
  {
    public uint count { get; set; }
    public uint[]? times { get; set; }
    public float[]? scales { get; set; }
    public uint type { get; set; }
    public uint offset { get; set; }
    public uint blend { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure09A>()
        .Integer(x => x.count, 32)
        .Array(x => x.times, x => x.count).OfInteger(32)
        .Array(x => x.scales, x => x.count).OfFloat()
        .Integer(x => x.type, 2)
        .Integer(x => x.offset, 32)
        .Integer(x => x.blend, 1);
    }
  }

  public record Structure09B
  {
    public uint state { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure09B>()
        .Integer(x => x.state, 32);
    }
  }

  public record Structure09C
  {
    public uint count { get; set; }
    public uint[]? times { get; set; }
    public uint[]? states { get; set; }
    public uint offset { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure09C>()
        .Integer(x => x.count, 32)
        .Array(x => x.times, x => x.count).OfInteger(32)
        .Array(x => x.states, x => x.count).OfInteger(32)
        .Integer(x => x.offset, 32);
    }
  }

  public record Structure09D
  {
    public uint strafe { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure09D>()
        .Integer(x => x.strafe, 1);
    }
  }

  public record Structure09E
  {
    public uint mode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure09E>()
        .Integer(x => x.mode, 32);
    }
  }

  public record Structure09F
  {
    public uint count { get; set; }
    public uint[]? times { get; set; }
    public uint[]? modes { get; set; }
    public uint offset { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure09F>()
        .Integer(x => x.count, 32)
        .Array(x => x.times, x => x.count).OfInteger(32)
        .Array(x => x.modes, x => x.count).OfInteger(32)
        .Integer(x => x.offset, 32);
    }
  }

  public record Structure0A0
  {
    public uint unused { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A0>()
        .Integer(x => x.unused, 32);
    }
  }

  public record Structure0A1
  {
    public uint propertyId { get; set; }
    public float @base { get; set; }
    public float value { get; set; }
    public ushort modifierCount { get; set; }
    public Structure0A2[]? modifiers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A1>()
        .Integer(x => x.propertyId, 8)
        .Float(x => x.@base)
        .Float(x => x.value)
        .Integer(x => x.modifierCount, 16)
        .Array(x => x.modifiers, x => x.modifierCount).OfStructure();
    }
  }

  public record Structure0A2
  {
    public uint objectId { get; set; }
    public uint objectType { get; set; }
    public float scale { get; set; }
    public float offset { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A2>()
        .Integer(x => x.objectId, 32)
        .Integer(x => x.objectType, 4)
        .Float(x => x.scale)
        .Float(x => x.offset);
    }
  }

  public record Structure0A3
  {
    public uint groupIndex { get; set; }
    public uint localizedStringsIdName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A3>()
        .Integer(x => x.groupIndex, 32)
        .Integer(x => x.localizedStringsIdName, 32);
    }
  }

  public record Structure0A4
  {
    public uint uniqueId { get; set; }
    public uint vendorItemType { get; set; }
    public uint staticDbId { get; set; }
    public uint rewardOption { get; set; }
    public uint stockCount { get; set; }
    public uint prereqId { get; set; }
    public uint exchangeRate { get; set; }
    public uint vendorGroup { get; set; }
    public uint flags { get; set; }
    public ulong randomCircuitData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A4>()
        .Integer(x => x.uniqueId, 32)
        .Integer(x => x.vendorItemType, 4)
        .Integer(x => x.staticDbId, 32)
        .Integer(x => x.rewardOption, 32)
        .Integer(x => x.stockCount, 32)
        .Integer(x => x.prereqId, 32)
        .Integer(x => x.exchangeRate, 32)
        .Integer(x => x.vendorGroup, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.randomCircuitData, 64);
    }
  }

  public record Structure0A5
  {
    public Structure024[]? charId { get; set; }
    public uint[]? charRaceId { get; set; }
    public uint[]? charClassId { get; set; }
    public uint[]? charSexId { get; set; }
    public uint[]? charLevel { get; set; }
    public uint[]? charFlags { get; set; }
    public uint realmId { get; set; }
    public uint worldId { get; set; }
    public uint worldZoneId { get; set; }
    public uint articleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A5>()
        .Array(x => x.charId, 5).OfStructure()
        .Array(x => x.charRaceId, 5).OfInteger(4)
        .Array(x => x.charClassId, 5).OfInteger(4)
        .Array(x => x.charSexId, 5).OfInteger(4)
        .Array(x => x.charLevel, 5).OfInteger(32)
        .Array(x => x.charFlags, 5).OfInteger(32)
        .Integer(x => x.realmId, 32)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.worldZoneId, 32)
        .Integer(x => x.articleId, 32);
    }
  }

  public record Structure0A6
  {
    public Structure0A7? common { get; set; }
    public uint questId { get; set; }
    public uint rewardType { get; set; }
    public uint rewardObjectId { get; set; }
    public uint rewardObjectAmount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A6>()
        .Structure(x => x.common)
        .Integer(x => x.questId, 32)
        .Integer(x => x.rewardType, 32)
        .Integer(x => x.rewardObjectId, 32)
        .Integer(x => x.rewardObjectAmount, 32);
    }
  }

  public record Structure0A7
  {
    public string[]? characterName { get; set; }
    public uint[]? charRaceId { get; set; }
    public uint[]? charClassId { get; set; }
    public uint[]? charSexId { get; set; }
    public uint[]? charLevel { get; set; }
    public uint[]? charFlags { get; set; }
    public uint realmId { get; set; }
    public uint worldId { get; set; }
    public uint worldZoneId { get; set; }
    public uint articleId { get; set; }
    public float eventTime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A7>()
        .Array(x => x.characterName, 5).OfString(true)
        .Array(x => x.charRaceId, 5).OfInteger(4)
        .Array(x => x.charClassId, 5).OfInteger(4)
        .Array(x => x.charSexId, 5).OfInteger(4)
        .Array(x => x.charLevel, 5).OfInteger(32)
        .Array(x => x.charFlags, 5).OfInteger(32)
        .Integer(x => x.realmId, 32)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.worldZoneId, 32)
        .Integer(x => x.articleId, 32)
        .Float(x => x.eventTime);
    }
  }

  public record Structure0A8
  {
    public Structure0A7? common { get; set; }
    public uint achievementId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A8>()
        .Structure(x => x.common)
        .Integer(x => x.achievementId, 32);
    }
  }

  public record Structure0A9
  {
    public uint[]? contributionTiers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0A9>()
        .Array(x => x.contributionTiers, 5).OfInteger(32);
    }
  }

  public record Structure0AA
  {
    public ulong decorId { get; set; }
    public ulong residenceId { get; set; }
    public uint decorType { get; set; }
    public uint decorData { get; set; }
    public uint hookBagIndex { get; set; }
    public uint hookIndex { get; set; }
    public uint plotIndex { get; set; }
    public float scale { get; set; }
    public float posOffsetX { get; set; }
    public float posOffsetY { get; set; }
    public float posOffsetZ { get; set; }
    public float rotOffsetQuatX { get; set; }
    public float rotOffsetQuatY { get; set; }
    public float rotOffsetQuatZ { get; set; }
    public float rotOffsetQuatW { get; set; }
    public uint decorInfoId { get; set; }
    public uint activePropUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0AA>()
        .Integer(x => x.decorId, 64)
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.decorType, 32)
        .Integer(x => x.decorData, 32)
        .Integer(x => x.hookBagIndex, 32)
        .Integer(x => x.hookIndex, 32)
        .Integer(x => x.plotIndex, 32)
        .Float(x => x.scale)
        .Float(x => x.posOffsetX)
        .Float(x => x.posOffsetY)
        .Float(x => x.posOffsetZ)
        .Float(x => x.rotOffsetQuatX)
        .Float(x => x.rotOffsetQuatY)
        .Float(x => x.rotOffsetQuatZ)
        .Float(x => x.rotOffsetQuatW)
        .Integer(x => x.decorInfoId, 32)
        .Integer(x => x.activePropUnitId, 32);
    }
  }

  public record Structure0AB
  {
    public uint operation { get; set; }
    public Structure0AA? decor { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0AB>()
        .Integer(x => x.operation, 3)
        .Structure(x => x.decor);
    }
  }

  public record Structure0AC
  {
    public ulong residenceId { get; set; }
    public ulong neighborhoodId { get; set; }
    public ulong characterIdOwner { get; set; }
    public ulong guildIdOwner { get; set; }
    public uint realmIdOwner { get; set; }
    public uint tileId { get; set; }
    public string? name { get; set; }
    public uint propertyInfoId { get; set; }
    public uint residenceInfoId { get; set; }
    public uint wallpaperExterior { get; set; }
    public uint entryway { get; set; }
    public uint roof { get; set; }
    public uint door { get; set; }
    public uint flags { get; set; }
    public uint residenceDeleted { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0AC>()
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.neighborhoodId, 64)
        .Integer(x => x.characterIdOwner, 64)
        .Integer(x => x.guildIdOwner, 64)
        .Integer(x => x.realmIdOwner, 32)
        .Integer(x => x.tileId, 32)
        .String(x => x.name, true)
        .Integer(x => x.propertyInfoId, 32)
        .Integer(x => x.residenceInfoId, 32)
        .Integer(x => x.wallpaperExterior, 32)
        .Integer(x => x.entryway, 32)
        .Integer(x => x.roof, 32)
        .Integer(x => x.door, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.residenceDeleted, 1);
    }
  }

  public record Structure0AD
  {
    public ulong hoodId { get; set; }
    public uint hoodInfoId { get; set; }
    public uint parentRealm { get; set; }
    public ulong guildIdOwner { get; set; }
    public string? name { get; set; }
    public uint population { get; set; }
    public uint maxPopulation { get; set; }
    public uint cost { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0AD>()
        .Integer(x => x.hoodId, 64)
        .Integer(x => x.hoodInfoId, 32)
        .Integer(x => x.parentRealm, 32)
        .Integer(x => x.guildIdOwner, 64)
        .String(x => x.name, true)
        .Integer(x => x.population, 32)
        .Integer(x => x.maxPopulation, 32)
        .Integer(x => x.cost, 32);
    }
  }

  public record Structure0AE
  {
    public uint count { get; set; }
    public Structure0AF[]? plots { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0AE>()
        .Integer(x => x.count, 32)
        .Array(x => x.plots, x => x.count).OfStructure();
    }
  }

  public record Structure0AF
  {
    public uint plotProperyIndex { get; set; }
    public uint plugItemId { get; set; }
    public uint plotInfoId { get; set; }
    public uint[]? housingContributionTotals { get; set; }
    public uint[]? housingDecayTotals { get; set; }
    public uint housingUpkeepCharges { get; set; }
    public float housingUpkeepTime { get; set; }
    public uint buildState { get; set; }
    public uint buildStage { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0AF>()
        .Integer(x => x.plotProperyIndex, 32)
        .Integer(x => x.plugItemId, 32)
        .Integer(x => x.plotInfoId, 32)
        .Array(x => x.housingContributionTotals, 5).OfInteger(32)
        .Array(x => x.housingDecayTotals, 5).OfInteger(32)
        .Integer(x => x.housingUpkeepCharges, 32)
        .Float(x => x.housingUpkeepTime)
        .Integer(x => x.buildState, 3)
        .Integer(x => x.buildStage, 32);
    }
  }

  public record Structure0B0
  {
    public ulong sourceId { get; set; }
    public uint plugItemId { get; set; }
    public uint cost { get; set; }
    public uint plugItemFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B0>()
        .Integer(x => x.sourceId, 64)
        .Integer(x => x.plugItemId, 32)
        .Integer(x => x.cost, 32)
        .Integer(x => x.plugItemFlags, 32);
    }
  }

  public record Structure0B1
  {
    public uint tradeskillId { get; set; }
    public uint xp { get; set; }
    public uint flags { get; set; }
    public uint proficiencyFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B1>()
        .Integer(x => x.tradeskillId, 32)
        .Integer(x => x.xp, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.proficiencyFlags, 32);
    }
  }

  public record Structure0B2
  {
    public uint schematicId { get; set; }
    public float x { get; set; }
    public float y { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B2>()
        .Integer(x => x.schematicId, 32)
        .Float(x => x.x)
        .Float(x => x.y);
    }
  }

  public record Structure0B3
  {
    public uint bonusEnum { get; set; }
    public uint objectId { get; set; }
    public uint objectIdAlt { get; set; }
    public float multiplier { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B3>()
        .Integer(x => x.bonusEnum, 32)
        .Integer(x => x.objectId, 32)
        .Integer(x => x.objectIdAlt, 32)
        .Float(x => x.multiplier);
    }
  }

  public record Structure0B4
  {
    public uint rewardId { get; set; }
    public uint lootItemType { get; set; }
    public uint amount { get; set; }
    public uint challengeTier { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B4>()
        .Integer(x => x.rewardId, 32)
        .Integer(x => x.lootItemType, 4)
        .Integer(x => x.amount, 32)
        .Integer(x => x.challengeTier, 32);
    }
  }

  public record Structure0B5
  {
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
    public float w { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B5>()
        .Float(x => x.x)
        .Float(x => x.y)
        .Float(x => x.z)
        .Float(x => x.w);
    }
  }

  public record Structure0B6
  {
    public string? name { get; set; }
    public ulong itemId { get; set; }
    public ulong totalTicks { get; set; }
    public ulong callCount { get; set; }
    public ulong maxTicks { get; set; }
    public ulong primaryActorCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B6>()
        .String(x => x.name, true)
        .Integer(x => x.itemId, 64)
        .Integer(x => x.totalTicks, 64)
        .Integer(x => x.callCount, 64)
        .Integer(x => x.maxTicks, 64)
        .Integer(x => x.primaryActorCount, 64);
    }
  }

  public record Structure0B7
  {
    public uint index { get; set; }
    public uint displayFlags { get; set; }
    public uint[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B7>()
        .Integer(x => x.index, 32)
        .Integer(x => x.displayFlags, 32)
        .Array(x => x.items, 6).OfInteger(32);
    }
  }

  public record Structure0B8
  {
    public ulong uniqueId { get; set; }
    public ulong locationData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B8>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.locationData, 64);
    }
  }

  public record Structure0B9
  {
    public uint uniqueId { get; set; }
    public uint type { get; set; }
    public uint staticId { get; set; }
    public uint amount { get; set; }
    public uint canLoot { get; set; }
    public uint needsRoll { get; set; }
    public uint explosion { get; set; }
    public uint masterCount { get; set; }
    public uint rollTime { get; set; }
    public Structure024[]? masterList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0B9>()
        .Integer(x => x.uniqueId, 32)
        .Integer(x => x.type, 32)
        .Integer(x => x.staticId, 32)
        .Integer(x => x.amount, 32)
        .Integer(x => x.canLoot, 1)
        .Integer(x => x.needsRoll, 1)
        .Integer(x => x.explosion, 1)
        .Integer(x => x.masterCount, 32)
        .Integer(x => x.rollTime, 32)
        .Array(x => x.masterList, x => x.masterCount).OfStructure();
    }
  }

  public record Structure0BA
  {
    public ulong decorId { get; set; }
    public float posX { get; set; }
    public float posY { get; set; }
    public float posZ { get; set; }
    public float orientX { get; set; }
    public float orientY { get; set; }
    public float orientZ { get; set; }
    public float orientW { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0BA>()
        .Integer(x => x.decorId, 64)
        .Float(x => x.posX)
        .Float(x => x.posY)
        .Float(x => x.posZ)
        .Float(x => x.orientX)
        .Float(x => x.orientY)
        .Float(x => x.orientZ)
        .Float(x => x.orientW);
    }
  }

  public record Structure0BB
  {
    public ulong uniqueId { get; set; }
    public uint[]? dyes { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0BB>()
        .Integer(x => x.uniqueId, 64)
        .Array(x => x.dyes, 3).OfInteger(32);
    }
  }

  public record Structure0BC
  {
    public uint useTypes { get; set; }
    public uint mapCount { get; set; }
    public uint[]? maps { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0BC>()
        .Integer(x => x.useTypes, 1)
        .Integer(x => x.mapCount, 32)
        .Array(x => x.maps, x => x.mapCount).OfInteger(32);
    }
  }

  public record Structure0BD
  {
    public uint state { get; set; }
    public uint elapsed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0BD>()
        .Integer(x => x.state, 32)
        .Integer(x => x.elapsed, 32);
    }
  }

  public record Structure0BE
  {
    public Structure024? identity { get; set; }
    public string? name { get; set; }
    public uint factionId { get; set; }
    public uint raceId { get; set; }
    public uint classId { get; set; }
    public uint level { get; set; }
    public uint pathType { get; set; }
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0BE>()
        .Structure(x => x.identity)
        .String(x => x.name, true)
        .Integer(x => x.factionId, 32)
        .Integer(x => x.raceId, 32)
        .Integer(x => x.classId, 32)
        .Integer(x => x.level, 32)
        .Integer(x => x.pathType, 3)
        .Integer(x => x.role, 32);
    }
  }

  public record Structure0BF
  {
    public uint msgId { get; set; }
    public uint hash { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0BF>()
        .Integer(x => x.msgId, 32)
        .Integer(x => x.hash, 32);
    }
  }

  public record Structure0C0
  {
    public ulong uniqueId { get; set; }
    public uint messageType { get; set; }
    public string? subject { get; set; }
    public string? body { get; set; }
    public uint subjectStringId { get; set; }
    public uint bodyStringId { get; set; }
    public uint fromCreature { get; set; }
    public ulong moneyToGive { get; set; }
    public uint stationaryId { get; set; }
    public ulong codAmount { get; set; }
    public float expirationTimeInDays { get; set; }
    public uint flags { get; set; }
    public Structure0C1? fromCharacter { get; set; }
    public uint attachmentCount { get; set; }
    public Structure0C2[]? attachments { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0C0>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.messageType, 32)
        .String(x => x.subject, true)
        .String(x => x.body, true)
        .Integer(x => x.subjectStringId, 32)
        .Integer(x => x.bodyStringId, 32)
        .Integer(x => x.fromCreature, 32)
        .Integer(x => x.moneyToGive, 64)
        .Integer(x => x.stationaryId, 32)
        .Integer(x => x.codAmount, 64)
        .Float(x => x.expirationTimeInDays)
        .Integer(x => x.flags, 32)
        .Structure(x => x.fromCharacter)
        .Integer(x => x.attachmentCount, 32)
        .Array(x => x.attachments, x => x.attachmentCount).OfStructure();
    }
  }

  public record Structure0C1
  {
    public uint realmId { get; set; }
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0C1>()
        .Integer(x => x.realmId, 32)
        .Integer(x => x.characterId, 64);
    }
  }

  public record Structure0C2
  {
    public uint item2Id { get; set; }
    public uint stackCount { get; set; }
    public uint charges { get; set; }
    public ulong itemRandomCircuitData { get; set; }
    public ulong thresholdData { get; set; }
    public uint[]? item2IdMicrochip { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0C2>()
        .Integer(x => x.item2Id, 32)
        .Integer(x => x.stackCount, 32)
        .Integer(x => x.charges, 32)
        .Integer(x => x.itemRandomCircuitData, 64)
        .Integer(x => x.thresholdData, 64)
        .Array(x => x.item2IdMicrochip, 10).OfInteger(32);
    }
  }

  public record Structure0C3
  {
    public uint uniqueId { get; set; }
    public uint ownerId { get; set; }
    public uint tradeType { get; set; }
    public uint staticId { get; set; }
    public ulong itemUniqueId { get; set; }
    public ulong count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0C3>()
        .Integer(x => x.uniqueId, 32)
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.tradeType, 2)
        .Integer(x => x.staticId, 32)
        .Integer(x => x.itemUniqueId, 64)
        .Integer(x => x.count, 64);
    }
  }

  public record Structure0C4
  {
    public uint challengeId { get; set; }
    public uint type { get; set; }
    public uint actionId { get; set; }
    public uint qualifyCount { get; set; }
    public uint qualifyTotal { get; set; }
    public uint currentCount { get; set; }
    public uint goalCount { get; set; }
    public uint currentTier { get; set; }
    public uint lastRewardTier { get; set; }
    public uint completionCount { get; set; }
    public uint bUnlocked { get; set; }
    public uint bActivated { get; set; }
    public uint bInCooldown { get; set; }
    public uint bLeftArea { get; set; }
    public uint bCollectReward { get; set; }
    public uint timeActivatedDt { get; set; }
    public uint timeTotalActive { get; set; }
    public uint timeCooldownDt { get; set; }
    public uint timeTotalCooldown { get; set; }
    public uint timeAreaFailDt { get; set; }
    public uint timeTotalAreaFail { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0C4>()
        .Integer(x => x.challengeId, 32)
        .Integer(x => x.type, 3)
        .Integer(x => x.actionId, 32)
        .Integer(x => x.qualifyCount, 32)
        .Integer(x => x.qualifyTotal, 32)
        .Integer(x => x.currentCount, 32)
        .Integer(x => x.goalCount, 32)
        .Integer(x => x.currentTier, 32)
        .Integer(x => x.lastRewardTier, 32)
        .Integer(x => x.completionCount, 32)
        .Integer(x => x.bUnlocked, 1)
        .Integer(x => x.bActivated, 1)
        .Integer(x => x.bInCooldown, 1)
        .Integer(x => x.bLeftArea, 1)
        .Integer(x => x.bCollectReward, 1)
        .Integer(x => x.timeActivatedDt, 32)
        .Integer(x => x.timeTotalActive, 32)
        .Integer(x => x.timeCooldownDt, 32)
        .Integer(x => x.timeTotalCooldown, 32)
        .Integer(x => x.timeAreaFailDt, 32)
        .Integer(x => x.timeTotalAreaFail, 32);
    }
  }

  public record Structure0C5
  {
    public uint id { get; set; }
    public uint hazardType { get; set; }
    public float meterValue { get; set; }
    public float maxValue { get; set; }
    public uint currentThreshold { get; set; }
    public uint procSpellId { get; set; }
    public uint hazardUnitId { get; set; }
    public uint pulseTimeLeft { get; set; }
    public uint bUnitBased { get; set; }
    public uint bStartsFull { get; set; }
    public uint bEnabled { get; set; }
    public uint bSuspended { get; set; }
    public uint bDoNotRefill { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0C5>()
        .Integer(x => x.id, 32)
        .Integer(x => x.hazardType, 3)
        .Float(x => x.meterValue)
        .Float(x => x.maxValue)
        .Integer(x => x.currentThreshold, 32)
        .Integer(x => x.procSpellId, 32)
        .Integer(x => x.hazardUnitId, 32)
        .Integer(x => x.pulseTimeLeft, 32)
        .Integer(x => x.bUnitBased, 1)
        .Integer(x => x.bStartsFull, 1)
        .Integer(x => x.bEnabled, 1)
        .Integer(x => x.bSuspended, 1)
        .Integer(x => x.bDoNotRefill, 1);
    }
  }

  public record Structure0C6
  {
    public float multiplier { get; set; }
    public float offset { get; set; }
    public uint bSuspended { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Structure0C6>()
        .Float(x => x.multiplier)
        .Float(x => x.offset)
        .Integer(x => x.bSuspended, 1);
    }
  }

}
