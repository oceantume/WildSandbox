using System;
using WildSandbox.Common.Messages;

namespace WildSandbox.Messages.Build6072
{
  [Message(6072, 0x0002)]
  public record Message0002
  {
    public uint buildNumber { get; set; }
    public uint realmId { get; set; }
    public uint realmGroupId { get; set; }
    public ulong startupTime { get; set; }
    public ushort listenPort { get; set; }
    public uint connectionType { get; set; }
    public uint networkMessageCRC { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0002>()
        .Integer(x => x.buildNumber, 32)
        .Integer(x => x.realmId, 32)
        .Integer(x => x.realmGroupId, 32)
        .Integer(x => x.startupTime, 64)
        .Integer(x => x.listenPort, 16)
        .Integer(x => x.connectionType, 5)
        .Integer(x => x.networkMessageCRC, 32);
    }
  }

  [Message(6072, 0x0003)]
  public record Message0003
  {
    public uint errorID { get; set; }
    public string? context { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0003>()
        .Integer(x => x.errorID, 32)
        .String(x => x.context, true);
    }
  }

  [Message(6072, 0x0020)]
  public record Message0020
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0020>();
    }
  }

  [Message(6072, 0x0022)]
  public record Message0022
  {
    public Structure02E? petInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0022>()
        .Structure(x => x.petInfo);
    }
  }

  [Message(6072, 0x0026)]
  public record Message0026
  {
    public uint petCmd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0026>()
        .Integer(x => x.petCmd, 32);
    }
  }

  [Message(6072, 0x002A)]
  public record Message002A
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message002A>();
    }
  }

  [Message(6072, 0x002B)]
  public record Message002B
  {
    public float yaw { get; set; }
    public float pitch { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message002B>()
        .Float(x => x.yaw)
        .Float(x => x.pitch);
    }
  }

  [Message(6072, 0x002D)]
  public record Message002D
  {
    public uint clientUniqueId { get; set; }
    public uint actionBarSetIndex { get; set; }
    public uint whichSet { get; set; }
    public uint targetUnitId { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message002D>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.actionBarSetIndex, 32)
        .Integer(x => x.whichSet, 32)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.position);
    }
  }

  [Message(6072, 0x002E)]
  public record Message002E
  {
    public uint clientUniqueId { get; set; }
    public uint activateUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message002E>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.activateUnitId, 32);
    }
  }

  [Message(6072, 0x002F)]
  public record Message002F
  {
    public uint clientUniqueId { get; set; }
    public uint activateUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message002F>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.activateUnitId, 32);
    }
  }

  [Message(6072, 0x0030)]
  public record Message0030
  {
    public uint clientUniqueId { get; set; }
    public uint index { get; set; }
    public uint clueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0030>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.index, 32)
        .Integer(x => x.clueId, 32);
    }
  }

  [Message(6072, 0x0031)]
  public record Message0031
  {
    public uint clientUniqueId { get; set; }
    public uint spellBookIndex { get; set; }
    public uint targetUnitId { get; set; }
    public uint bButtonHeldCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0031>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.spellBookIndex, 32)
        .Integer(x => x.targetUnitId, 32)
        .Integer(x => x.bButtonHeldCast, 1);
    }
  }

  [Message(6072, 0x0032)]
  public record Message0032
  {
    public uint clientUniqueId { get; set; }
    public uint spellBookIndex { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0032>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.spellBookIndex, 32)
        .Structure(x => x.position);
    }
  }

  [Message(6072, 0x0033)]
  public record Message0033
  {
    public uint clientUniqueId { get; set; }
    public uint spellId { get; set; }
    public uint targetUnitId { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0033>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.spellId, 32)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.position);
    }
  }

  [Message(6072, 0x003D)]
  public record Message003D
  {
    public uint rewardId { get; set; }
    public uint lootItemType { get; set; }
    public uint amount { get; set; }
    public uint challengeTier { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message003D>()
        .Integer(x => x.rewardId, 32)
        .Integer(x => x.lootItemType, 4)
        .Integer(x => x.amount, 32)
        .Integer(x => x.challengeTier, 32);
    }
  }

  [Message(6072, 0x003E)]
  public record Message003E
  {
    public uint challengeId { get; set; }
    public uint numRewardItems { get; set; }
    public Structure0B4[]? rewards { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message003E>()
        .Integer(x => x.challengeId, 32)
        .Integer(x => x.numRewardItems, 32)
        .Array(x => x.rewards, x => x.numRewardItems).OfStructure();
    }
  }

  [Message(6072, 0x0040)]
  public record Message0040
  {
    public uint worldId { get; set; }
    public Structure014? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0040>()
        .Integer(x => x.worldId, 32)
        .Structure(x => x.location);
    }
  }

  [Message(6072, 0x0041)]
  public record Message0041
  {
    public uint m_achievementId { get; set; }
    public uint m_value00 { get; set; }
    public uint m_value01 { get; set; }
    public ulong m_dateCompleted { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0041>()
        .Integer(x => x.m_achievementId, 32)
        .Integer(x => x.m_value00, 32)
        .Integer(x => x.m_value01, 32)
        .Integer(x => x.m_dateCompleted, 64);
    }
  }

  [Message(6072, 0x0042)]
  public record Message0042
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0042>();
    }
  }

  [Message(6072, 0x0043)]
  public record Message0043
  {
    public uint itemDbId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0043>()
        .Integer(x => x.itemDbId, 32);
    }
  }

  [Message(6072, 0x0044)]
  public record Message0044
  {
    public uint count { get; set; }
    public uint[]? spellIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0044>()
        .Integer(x => x.count, 32)
        .Array(x => x.spellIds, x => x.count).OfInteger(32);
    }
  }

  [Message(6072, 0x0045)]
  public record Message0045
  {
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0045>()
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6072, 0x0046)]
  public record Message0046
  {
    public uint count { get; set; }
    public uint[]? activeSpells { get; set; }
    public uint abilityPoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0046>()
        .Integer(x => x.count, 32)
        .Array(x => x.activeSpells, x => x.count).OfInteger(32)
        .Integer(x => x.abilityPoints, 32);
    }
  }

  [Message(6072, 0x0047)]
  public record Message0047
  {
    public uint dyeColorId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0047>()
        .Integer(x => x.dyeColorId, 32);
    }
  }

  [Message(6072, 0x0048)]
  public record Message0048
  {
    public uint ownerId { get; set; }
    public uint lootId { get; set; }
    public Structure024? target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0048>()
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.lootId, 32)
        .Structure(x => x.target);
    }
  }

  [Message(6072, 0x0049)]
  public record Message0049
  {
    public uint count { get; set; }
    public uint[]? milestoneIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0049>()
        .Integer(x => x.count, 32)
        .Array(x => x.milestoneIds, x => x.count).OfInteger(32);
    }
  }

  [Message(6072, 0x004A)]
  public record Message004A
  {
    public uint count { get; set; }
    public uint[]? milestoneIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004A>()
        .Integer(x => x.count, 32)
        .Array(x => x.milestoneIds, x => x.count).OfInteger(32);
    }
  }

  [Message(6072, 0x004B)]
  public record Message004B
  {
    public uint inventoryIndex { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004B>()
        .Integer(x => x.inventoryIndex, 32);
    }
  }

  [Message(6072, 0x004C)]
  public record Message004C
  {
    public uint uniqueId { get; set; }
    public uint itemId { get; set; }
    public uint quantity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004C>()
        .Integer(x => x.uniqueId, 32)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.quantity, 32);
    }
  }

  [Message(6072, 0x004D)]
  public record Message004D
  {
    public uint uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004D>()
        .Integer(x => x.uniqueId, 32);
    }
  }

  [Message(6072, 0x004E)]
  public record Message004E
  {
    public uint itemCount { get; set; }
    public Structure036[]? buybackItems { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004E>()
        .Integer(x => x.itemCount, 32)
        .Array(x => x.buybackItems, x => x.itemCount).OfStructure();
    }
  }

  [Message(6072, 0x004F)]
  public record Message004F
  {
    public uint uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004F>()
        .Integer(x => x.uniqueId, 32);
    }
  }

  [Message(6072, 0x0050)]
  public record Message0050
  {
    public uint uniqueId { get; set; }
    public uint quantity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0050>()
        .Integer(x => x.uniqueId, 32)
        .Integer(x => x.quantity, 32);
    }
  }

  [Message(6072, 0x0051)]
  public record Message0051
  {
    public uint challengeId { get; set; }
    public uint actionType { get; set; }
    public uint extraData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0051>()
        .Integer(x => x.challengeId, 32)
        .Integer(x => x.actionType, 32)
        .Integer(x => x.extraData, 32);
    }
  }

  [Message(6072, 0x0052)]
  public record Message0052
  {
    public uint challengeId { get; set; }
    public uint actionType { get; set; }
    public uint extraData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0052>()
        .Integer(x => x.challengeId, 32)
        .Integer(x => x.actionType, 32)
        .Integer(x => x.extraData, 32);
    }
  }

  [Message(6072, 0x0053)]
  public record Message0053
  {
    public uint count { get; set; }
    public Structure0C4[]? challenges { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0053>()
        .Integer(x => x.count, 32)
        .Array(x => x.challenges, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0054)]
  public record Message0054
  {
    public uint classId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0054>()
        .Integer(x => x.classId, 5);
    }
  }

  [Message(6072, 0x0055)]
  public record Message0055
  {
    public ulong uniqueItemId { get; set; }
    public uint chargesCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0055>()
        .Integer(x => x.uniqueItemId, 64)
        .Integer(x => x.chargesCount, 32);
    }
  }

  [Message(6072, 0x0056)]
  public record Message0056
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0056>();
    }
  }

  [Message(6072, 0x0057)]
  public record Message0057
  {
    public uint commId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0057>()
        .Integer(x => x.commId, 32);
    }
  }

  [Message(6072, 0x0058)]
  public record Message0058
  {
    public uint commId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0058>()
        .Integer(x => x.commId, 32);
    }
  }

  [Message(6072, 0x0059)]
  public record Message0059
  {
    public uint itemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0059>()
        .Integer(x => x.itemId, 32);
    }
  }

  [Message(6072, 0x005A)]
  public record Message005A
  {
    public string? cheatStr { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005A>()
        .String(x => x.cheatStr, true);
    }
  }

  [Message(6072, 0x005B)]
  public record Message005B
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005B>();
    }
  }

  [Message(6072, 0x005C)]
  public record Message005C
  {
    public uint publicEventId { get; set; }
    public uint reason { get; set; }
    public uint elapsedTimeMs { get; set; }
    public Structure00B? stats { get; set; }
    public uint teamCount { get; set; }
    public Structure00C[]? teamStats { get; set; }
    public uint participantCount { get; set; }
    public Structure00D[]? participantStats { get; set; }
    public uint objectiveCount { get; set; }
    public Structure00E[]? objectiveStatus { get; set; }
    public uint rewardTier { get; set; }
    public uint rewardType { get; set; }
    public uint[]? rewardThreshold { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005C>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.reason, 32)
        .Integer(x => x.elapsedTimeMs, 32)
        .Structure(x => x.stats)
        .Integer(x => x.teamCount, 32)
        .Array(x => x.teamStats, x => x.teamCount).OfStructure()
        .Integer(x => x.participantCount, 32)
        .Array(x => x.participantStats, x => x.participantCount).OfStructure()
        .Integer(x => x.objectiveCount, 32)
        .Array(x => x.objectiveStatus, x => x.objectiveCount).OfStructure()
        .Integer(x => x.rewardTier, 32)
        .Integer(x => x.rewardType, 32)
        .Array(x => x.rewardThreshold, 3).OfInteger(32);
    }
  }

  [Message(6072, 0x005D)]
  public record Message005D
  {
    public uint targetUnitId { get; set; }
    public uint conversionId { get; set; }
    public uint amount { get; set; }
    public ulong uniqueItemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005D>()
        .Integer(x => x.targetUnitId, 32)
        .Integer(x => x.conversionId, 32)
        .Integer(x => x.amount, 32)
        .Integer(x => x.uniqueItemId, 64);
    }
  }

  [Message(6072, 0x005E)]
  public record Message005E
  {
    public uint index { get; set; }
    public uint displayFlags { get; set; }
    public uint[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005E>()
        .Integer(x => x.index, 32)
        .Integer(x => x.displayFlags, 32)
        .Array(x => x.items, 6).OfInteger(32);
    }
  }

  [Message(6072, 0x005F)]
  public record Message005F
  {
    public uint count { get; set; }
    public Structure0B7[]? costumes { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005F>()
        .Integer(x => x.count, 32)
        .Array(x => x.costumes, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0060)]
  public record Message0060
  {
    public uint schematicId { get; set; }
    public uint recipeId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0060>()
        .Integer(x => x.schematicId, 32)
        .Integer(x => x.recipeId, 32);
    }
  }

  [Message(6072, 0x0061)]
  public record Message0061
  {
    public ulong characterId { get; set; }
    public uint worldId { get; set; }
    public uint results { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0061>()
        .Integer(x => x.characterId, 64)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.results, 4);
    }
  }

  [Message(6072, 0x0062)]
  public record Message0062
  {
    public uint direction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0062>()
        .Integer(x => x.direction, 3);
    }
  }

  [Message(6072, 0x0063)]
  public record Message0063
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0063>();
    }
  }

  [Message(6072, 0x0064)]
  public record Message0064
  {
    public uint datacubeCount { get; set; }
    public Structure039[]? datacubeData { get; set; }
    public uint datacubeVolumeCount { get; set; }
    public Structure03A[]? datacubeVolumeData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0064>()
        .Integer(x => x.datacubeCount, 32)
        .Array(x => x.datacubeData, x => x.datacubeCount).OfStructure()
        .Integer(x => x.datacubeVolumeCount, 32)
        .Array(x => x.datacubeVolumeData, x => x.datacubeVolumeCount).OfStructure();
    }
  }

  [Message(6072, 0x0065)]
  public record Message0065
  {
    public uint datacubeId { get; set; }
    public uint progress { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0065>()
        .Integer(x => x.datacubeId, 32)
        .Integer(x => x.progress, 32);
    }
  }

  [Message(6072, 0x0066)]
  public record Message0066
  {
    public uint datacubeVolumeId { get; set; }
    public uint volumeProgress { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0066>()
        .Integer(x => x.datacubeVolumeId, 32)
        .Integer(x => x.volumeProgress, 32);
    }
  }

  [Message(6072, 0x0067)]
  public record Message0067
  {
    public uint bButtonHeldCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0067>()
        .Integer(x => x.bButtonHeldCast, 1);
    }
  }

  [Message(6072, 0x0068)]
  public record Message0068
  {
    public uint results { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0068>()
        .Integer(x => x.results, 4);
    }
  }

  [Message(6072, 0x0069)]
  public record Message0069
  {
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0069>()
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6072, 0x006A)]
  public record Message006A
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006A>();
    }
  }

  [Message(6072, 0x006B)]
  public record Message006B
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006B>();
    }
  }

  [Message(6072, 0x006C)]
  public record Message006C
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006C>();
    }
  }

  [Message(6072, 0x006D)]
  public record Message006D
  {
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006D>()
        .Integer(x => x.result, 4);
    }
  }

  [Message(6072, 0x006E)]
  public record Message006E
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006E>();
    }
  }

  [Message(6072, 0x006F)]
  public record Message006F
  {
    public ulong uniqueId { get; set; }
    public uint[]? dyes { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006F>()
        .Integer(x => x.uniqueId, 64)
        .Array(x => x.dyes, 3).OfInteger(32);
    }
  }

  [Message(6072, 0x0070)]
  public record Message0070
  {
    public uint count { get; set; }
    public Structure0BB[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0070>()
        .Integer(x => x.count, 32)
        .Array(x => x.items, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0071)]
  public record Message0071
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0071>();
    }
  }

  [Message(6072, 0x0072)]
  public record Message0072
  {
    public uint difficulty { get; set; }
    public uint gameMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0072>()
        .Integer(x => x.difficulty, 2)
        .Integer(x => x.gameMode, 3);
    }
  }

  [Message(6072, 0x0073)]
  public record Message0073
  {
    public uint worldZoneId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0073>()
        .Integer(x => x.worldZoneId, 32);
    }
  }

  [Message(6072, 0x0074)]
  public record Message0074
  {
    public uint missionId { get; set; }
    public uint nodeIndex { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0074>()
        .Integer(x => x.missionId, 32)
        .Integer(x => x.nodeIndex, 32);
    }
  }

  [Message(6072, 0x0075)]
  public record Message0075
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0075>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6072, 0x0076)]
  public record Message0076
  {
    public uint powerMapId { get; set; }
    public uint travelerId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0076>()
        .Integer(x => x.powerMapId, 32)
        .Integer(x => x.travelerId, 32);
    }
  }

  [Message(6072, 0x0077)]
  public record Message0077
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0077>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6072, 0x0078)]
  public record Message0078
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0078>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6072, 0x0079)]
  public record Message0079
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0079>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6072, 0x007A)]
  public record Message007A
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007A>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6072, 0x007B)]
  public record Message007B
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007B>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6072, 0x007C)]
  public record Message007C
  {
    public float healthPercent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007C>()
        .Float(x => x.healthPercent);
    }
  }

  [Message(6072, 0x007D)]
  public record Message007D
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007D>();
    }
  }

  [Message(6072, 0x007E)]
  public record Message007E
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007E>();
    }
  }

  [Message(6072, 0x007F)]
  public record Message007F
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007F>();
    }
  }

  [Message(6072, 0x0080)]
  public record Message0080
  {
    public uint targetUnitId { get; set; }
    public uint taxiRouteCount { get; set; }
    public uint[]? taxiRouteList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0080>()
        .Integer(x => x.targetUnitId, 32)
        .Integer(x => x.taxiRouteCount, 32)
        .Array(x => x.taxiRouteList, x => x.taxiRouteCount).OfInteger(32);
    }
  }

  [Message(6072, 0x0081)]
  public record Message0081
  {
    public uint forbidden { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0081>()
        .Integer(x => x.forbidden, 1);
    }
  }

  [Message(6072, 0x0082)]
  public record Message0082
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0082>();
    }
  }

  [Message(6072, 0x0083)]
  public record Message0083
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0083>();
    }
  }

  [Message(6072, 0x0084)]
  public record Message0084
  {
    public uint articleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0084>()
        .Integer(x => x.articleId, 32);
    }
  }

  [Message(6072, 0x0085)]
  public record Message0085
  {
    public uint articleId { get; set; }
    public uint status { get; set; }
    public uint viewed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0085>()
        .Integer(x => x.articleId, 32)
        .Integer(x => x.status, 32)
        .Integer(x => x.viewed, 32);
    }
  }

  [Message(6072, 0x0086)]
  public record Message0086
  {
    public uint articleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0086>()
        .Integer(x => x.articleId, 32);
    }
  }

  [Message(6072, 0x0087)]
  public record Message0087
  {
    public uint error { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0087>()
        .Integer(x => x.error, 7);
    }
  }

  [Message(6072, 0x0088)]
  public record Message0088
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0088>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x0089)]
  public record Message0089
  {
    public uint hazardId { get; set; }
    public uint actionType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0089>()
        .Integer(x => x.hazardId, 32)
        .Integer(x => x.actionType, 32);
    }
  }

  [Message(6072, 0x008A)]
  public record Message008A
  {
    public uint count { get; set; }
    public Structure0C5[]? hazards { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008A>()
        .Integer(x => x.count, 32)
        .Array(x => x.hazards, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x008B)]
  public record Message008B
  {
    public uint idCount { get; set; }
    public Structure0C6[]? hazardIdMods { get; set; }
    public uint typeCount { get; set; }
    public Structure0C6[]? hazardTypeMods { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008B>()
        .Integer(x => x.idCount, 32)
        .Array(x => x.hazardIdMods, x => x.idCount).OfStructure()
        .Integer(x => x.typeCount, 32)
        .Array(x => x.hazardTypeMods, x => x.typeCount).OfStructure();
    }
  }

  [Message(6072, 0x008C)]
  public record Message008C
  {
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008C>()
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6072, 0x008D)]
  public record Message008D
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
      builder.FieldsOf<Message008D>()
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

  [Message(6072, 0x008E)]
  public record Message008E
  {
    public uint unitId { get; set; }
    public uint itemId { get; set; }
    public uint count { get; set; }
    public uint errorCode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008E>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.count, 32)
        .Integer(x => x.errorCode, 7);
    }
  }

  [Message(6072, 0x008F)]
  public record Message008F
  {
    public Structure02D? item { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008F>()
        .Structure(x => x.item);
    }
  }

  [Message(6072, 0x0090)]
  public record Message0090
  {
    public uint publicEventId { get; set; }
    public uint publicEventTeamId { get; set; }
    public uint elapsedTimeMs { get; set; }
    public uint busy { get; set; }
    public uint objectiveCount { get; set; }
    public Structure00A[]? objectives { get; set; }
    public uint locationCount { get; set; }
    public uint[]? locations { get; set; }
    public uint rewardType { get; set; }
    public uint[]? rewardThreshold { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0090>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.publicEventTeamId, 32)
        .Integer(x => x.elapsedTimeMs, 32)
        .Integer(x => x.busy, 1)
        .Integer(x => x.objectiveCount, 32)
        .Array(x => x.objectives, x => x.objectiveCount).OfStructure()
        .Integer(x => x.locationCount, 32)
        .Array(x => x.locations, x => x.locationCount).OfInteger(32)
        .Integer(x => x.rewardType, 32)
        .Array(x => x.rewardThreshold, 3).OfInteger(32);
    }
  }

  [Message(6072, 0x0091)]
  public record Message0091
  {
    public uint publicEventId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0091>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6072, 0x0092)]
  public record Message0092
  {
    public uint characterCount { get; set; }
    public Structure01B[]? characterInfo { get; set; }
    public uint additionalCount { get; set; }
    public uint[]? additionalAllowedCharCreations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0092>()
        .Integer(x => x.characterCount, 32)
        .Array(x => x.characterInfo, x => x.characterCount).OfStructure()
        .Integer(x => x.additionalCount, 32)
        .Array(x => x.additionalAllowedCharCreations, x => x.additionalCount).OfInteger(32);
    }
  }

  [Message(6072, 0x0094)]
  public record Message0094
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0094>();
    }
  }

  [Message(6072, 0x0095)]
  public record Message0095
  {
    public uint lootUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0095>()
        .Integer(x => x.lootUniqueId, 32);
    }
  }

  [Message(6072, 0x0096)]
  public record Message0096
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0096>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6072, 0x0097)]
  public record Message0097
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0097>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6072, 0x0098)]
  public record Message0098
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0098>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6072, 0x0099)]
  public record Message0099
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0099>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6072, 0x009A)]
  public record Message009A
  {
    public ulong uniqueId { get; set; }
    public uint mailboxUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009A>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.mailboxUnitId, 32);
    }
  }

  [Message(6072, 0x009B)]
  public record Message009B
  {
    public ulong uniqueId { get; set; }
    public uint attachmentNdx { get; set; }
    public uint mailboxUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009B>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.attachmentNdx, 32)
        .Integer(x => x.mailboxUnitId, 32);
    }
  }

  [Message(6072, 0x009C)]
  public record Message009C
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009C>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6072, 0x009D)]
  public record Message009D
  {
    public ulong uniqueId { get; set; }
    public uint count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009D>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.count, 32);
    }
  }

  [Message(6072, 0x009E)]
  public record Message009E
  {
    public uint option { get; set; }
    public uint newValue { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009E>()
        .Integer(x => x.option, 32)
        .Integer(x => x.newValue, 32);
    }
  }

  [Message(6072, 0x009F)]
  public record Message009F
  {
    public uint questId { get; set; }
    public uint objIdx { get; set; }
    public uint locationId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009F>()
        .Integer(x => x.questId, 32)
        .Integer(x => x.objIdx, 32)
        .Integer(x => x.locationId, 32);
    }
  }

  [Message(6072, 0x00A0)]
  public record Message00A0
  {
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A0>()
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x00A1)]
  public record Message00A1
  {
    public uint spellUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A1>()
        .Integer(x => x.spellUniqueId, 32);
    }
  }

  [Message(6072, 0x00A2)]
  public record Message00A2
  {
    public uint publicEventId { get; set; }
    public uint teamCount { get; set; }
    public Structure00C[]? teamStats { get; set; }
    public uint participantCount { get; set; }
    public Structure00D[]? participantStats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A2>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.teamCount, 32)
        .Array(x => x.teamStats, x => x.teamCount).OfStructure()
        .Integer(x => x.participantCount, 32)
        .Array(x => x.participantStats, x => x.participantCount).OfStructure();
    }
  }

  [Message(6072, 0x00A3)]
  public record Message00A3
  {
    public uint objectId { get; set; }
    public uint type { get; set; }
    public uint location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A3>()
        .Integer(x => x.objectId, 32)
        .Integer(x => x.type, 3)
        .Integer(x => x.location, 32);
    }
  }

  [Message(6072, 0x00A4)]
  public record Message00A4
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
      builder.FieldsOf<Message00A4>()
        .Integer(x => x.objectiveId, 32)
        .Structure(x => x.objectiveStatus)
        .Integer(x => x.busy, 1)
        .Integer(x => x.elapsedTimeMs, 32)
        .Integer(x => x.notificationMode, 32)
        .Integer(x => x.locationCount, 32)
        .Array(x => x.locations, x => x.locationCount).OfInteger(32);
    }
  }

  [Message(6072, 0x00A5)]
  public record Message00A5
  {
    public uint objectiveId { get; set; }
    public uint notificationMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A5>()
        .Integer(x => x.objectiveId, 32)
        .Integer(x => x.notificationMode, 32);
    }
  }

  [Message(6072, 0x00A6)]
  public record Message00A6
  {
    public uint objectiveId { get; set; }
    public Structure004? objectiveStatus { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A6>()
        .Integer(x => x.objectiveId, 32)
        .Structure(x => x.objectiveStatus);
    }
  }

  [Message(6072, 0x00A7)]
  public record Message00A7
  {
    public uint publicEventId { get; set; }
    public uint busy { get; set; }
    public uint elapsedTimeMs { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A7>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.busy, 1)
        .Integer(x => x.elapsedTimeMs, 32);
    }
  }

  [Message(6072, 0x00A8)]
  public record Message00A8
  {
    public uint publicEventId { get; set; }
    public Structure00B? stats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A8>()
        .Integer(x => x.publicEventId, 32)
        .Structure(x => x.stats);
    }
  }

  [Message(6072, 0x00A9)]
  public record Message00A9
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
      builder.FieldsOf<Message00A9>()
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

  [Message(6072, 0x00AA)]
  public record Message00AA
  {
    public uint publicEventId { get; set; }
    public uint newTeamId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AA>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.newTeamId, 32);
    }
  }

  [Message(6072, 0x00AB)]
  public record Message00AB
  {
    public uint publicEventId { get; set; }
    public uint stat { get; set; }
    public uint value { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AB>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.stat, 32)
        .Integer(x => x.value, 32);
    }
  }

  [Message(6072, 0x00AC)]
  public record Message00AC
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AC>();
    }
  }

  [Message(6072, 0x00AD)]
  public record Message00AD
  {
    public uint remaining { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AD>()
        .Integer(x => x.remaining, 32);
    }
  }

  [Message(6072, 0x00AE)]
  public record Message00AE
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AE>();
    }
  }

  [Message(6072, 0x00AF)]
  public record Message00AF
  {
    public Structure02C? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AF>()
        .Structure(x => x.location);
    }
  }

  [Message(6072, 0x00B0)]
  public record Message00B0
  {
    public Structure02C? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B0>()
        .Structure(x => x.location);
    }
  }

  [Message(6072, 0x00B1)]
  public record Message00B1
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B1>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6072, 0x00B2)]
  public record Message00B2
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B2>();
    }
  }

  [Message(6072, 0x00B3)]
  public record Message00B3
  {
    public uint ownerId { get; set; }
    public uint lootId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B3>()
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.lootId, 32);
    }
  }

  [Message(6072, 0x00B4)]
  public record Message00B4
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B4>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x00B5)]
  public record Message00B5
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B5>();
    }
  }

  [Message(6072, 0x00B6)]
  public record Message00B6
  {
    public byte resourceNdx { get; set; }
    public uint nextTick { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B6>()
        .Integer(x => x.resourceNdx, 8)
        .Integer(x => x.nextTick, 32);
    }
  }

  [Message(6072, 0x00B7)]
  public record Message00B7
  {
    public uint unitId { get; set; }
    public uint rezType { get; set; }
    public uint rezData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B7>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.rezType, 32)
        .Integer(x => x.rezData, 32);
    }
  }

  [Message(6072, 0x00B8)]
  public record Message00B8
  {
    public uint unitId { get; set; }
    public uint spellId { get; set; }
    public uint timeUntilRez { get; set; }
    public float percentageHealthRestored { get; set; }
    public float percentageEnergyRestored { get; set; }
    public float posx { get; set; }
    public float posy { get; set; }
    public float posz { get; set; }
    public uint spellCastOnDead { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B8>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.spellId, 32)
        .Integer(x => x.timeUntilRez, 32)
        .Float(x => x.percentageHealthRestored)
        .Float(x => x.percentageEnergyRestored)
        .Float(x => x.posx)
        .Float(x => x.posy)
        .Float(x => x.posz)
        .Integer(x => x.spellCastOnDead, 1);
    }
  }

  [Message(6072, 0x00B9)]
  public record Message00B9
  {
    public uint direction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B9>()
        .Integer(x => x.direction, 3);
    }
  }

  [Message(6072, 0x00BA)]
  public record Message00BA
  {
    public uint ownerId { get; set; }
    public uint lootId { get; set; }
    public uint rollAction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BA>()
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.lootId, 32)
        .Integer(x => x.rollAction, 32);
    }
  }

  [Message(6072, 0x00BB)]
  public record Message00BB
  {
    public Structure02C? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BB>()
        .Structure(x => x.location);
    }
  }

  [Message(6072, 0x00BC)]
  public record Message00BC
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BC>();
    }
  }

  [Message(6072, 0x00BE)]
  public record Message00BE
  {
    public Structure02C? location { get; set; }
    public uint quantity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BE>()
        .Structure(x => x.location)
        .Integer(x => x.quantity, 32);
    }
  }

  [Message(6072, 0x00BF)]
  public record Message00BF
  {
    public string? toCharacterName { get; set; }
    public string? toCharacterRealmName { get; set; }
    public string? subject { get; set; }
    public string? body { get; set; }
    public ulong moneyToGive { get; set; }
    public ulong codAmount { get; set; }
    public uint stationaryId { get; set; }
    public uint mailboxUnitId { get; set; }
    public ulong[]? attachments { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BF>()
        .String(x => x.toCharacterName, true)
        .String(x => x.toCharacterRealmName, true)
        .String(x => x.subject, true)
        .String(x => x.body, true)
        .Integer(x => x.moneyToGive, 64)
        .Integer(x => x.codAmount, 64)
        .Integer(x => x.stationaryId, 32)
        .Integer(x => x.mailboxUnitId, 32)
        .Array(x => x.attachments, 12).OfInteger(64);
    }
  }

  [Message(6072, 0x00C0)]
  public record Message00C0
  {
    public uint abilityPoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C0>()
        .Integer(x => x.abilityPoints, 32);
    }
  }

  [Message(6072, 0x00C1)]
  public record Message00C1
  {
    public uint actionBarIndex { get; set; }
    public uint shortcutType { get; set; }
    public uint objectId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C1>()
        .Integer(x => x.actionBarIndex, 32)
        .Integer(x => x.shortcutType, 32)
        .Integer(x => x.objectId, 32);
    }
  }

  [Message(6072, 0x00C2)]
  public record Message00C2
  {
    public uint whichSet { get; set; }
    public uint actionBarShortcutSetId { get; set; }
    public uint associatedUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C2>()
        .Integer(x => x.whichSet, 4)
        .Integer(x => x.actionBarShortcutSetId, 32)
        .Integer(x => x.associatedUnitId, 32);
    }
  }

  [Message(6072, 0x00C3)]
  public record Message00C3
  {
    public uint bindPointId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C3>()
        .Integer(x => x.bindPointId, 32);
    }
  }

  [Message(6072, 0x00C4)]
  public record Message00C4
  {
    public uint coreIndex { get; set; }
    public uint prevIndex { get; set; }
    public uint prevTarget { get; set; }
    public uint prevSpell { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C4>()
        .Integer(x => x.coreIndex, 32)
        .Integer(x => x.prevIndex, 32)
        .Integer(x => x.prevTarget, 32)
        .Integer(x => x.prevSpell, 32);
    }
  }

  [Message(6072, 0x00C5)]
  public record Message00C5
  {
    public uint phasesIPerceive { get; set; }
    public uint phasesThatPerceiveMe { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C5>()
        .Integer(x => x.phasesIPerceive, 32)
        .Integer(x => x.phasesThatPerceiveMe, 32);
    }
  }

  [Message(6072, 0x00C6)]
  public record Message00C6
  {
    public uint on { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C6>()
        .Integer(x => x.on, 1);
    }
  }

  [Message(6072, 0x00C7)]
  public record Message00C7
  {
    public uint spellID { get; set; }
    public uint active { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C7>()
        .Integer(x => x.spellID, 32)
        .Integer(x => x.active, 1);
    }
  }

  [Message(6072, 0x00C8)]
  public record Message00C8
  {
    public uint spellId { get; set; }
    public uint reason { get; set; }
    public uint data00 { get; set; }
    public uint add { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C8>()
        .Integer(x => x.spellId, 32)
        .Integer(x => x.reason, 3)
        .Integer(x => x.data00, 32)
        .Integer(x => x.add, 1);
    }
  }

  [Message(6072, 0x00C9)]
  public record Message00C9
  {
    public uint sheathState { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C9>()
        .Integer(x => x.sheathState, 1);
    }
  }

  [Message(6072, 0x00CA)]
  public record Message00CA
  {
    public uint tutorialId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CA>()
        .Integer(x => x.tutorialId, 32);
    }
  }

  [Message(6072, 0x00CB)]
  public record Message00CB
  {
    public uint spellId { get; set; }
    public uint active { get; set; }
    public uint abilityPoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CB>()
        .Integer(x => x.spellId, 32)
        .Integer(x => x.active, 1)
        .Integer(x => x.abilityPoints, 32);
    }
  }

  [Message(6072, 0x00CC)]
  public record Message00CC
  {
    public uint[]? points { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CC>()
        .Array(x => x.points, 6).OfInteger(32);
    }
  }

  [Message(6072, 0x00CD)]
  public record Message00CD
  {
    public ulong uniqueId { get; set; }
    public Structure02C? toLocation { get; set; }
    public uint amount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CD>()
        .Integer(x => x.uniqueId, 64)
        .Structure(x => x.toLocation)
        .Integer(x => x.amount, 32);
    }
  }

  [Message(6072, 0x00CE)]
  public record Message00CE
  {
    public uint on { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CE>()
        .Integer(x => x.on, 1);
    }
  }

  [Message(6072, 0x00CF)]
  public record Message00CF
  {
    public ulong uniqueItemId { get; set; }
    public uint stackCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CF>()
        .Integer(x => x.uniqueItemId, 64)
        .Integer(x => x.stackCount, 32);
    }
  }

  [Message(6072, 0x00D0)]
  public record Message00D0
  {
    public uint profile { get; set; }
    public uint scanTarget { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D0>()
        .Integer(x => x.profile, 32)
        .Integer(x => x.scanTarget, 1);
    }
  }

  [Message(6072, 0x00D1)]
  public record Message00D1
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D1>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x00D2)]
  public record Message00D2
  {
    public uint fromCheat { get; set; }
    public Structure02C? fromLocation { get; set; }
    public Structure02C? toLocation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D2>()
        .Integer(x => x.fromCheat, 1)
        .Structure(x => x.fromLocation)
        .Structure(x => x.toLocation);
    }
  }

  [Message(6072, 0x00D3)]
  public record Message00D3
  {
    public uint materialId { get; set; }
    public uint count { get; set; }
    public Structure02C? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D3>()
        .Integer(x => x.materialId, 32)
        .Integer(x => x.count, 32)
        .Structure(x => x.location);
    }
  }

  [Message(6072, 0x00D4)]
  public record Message00D4
  {
    public uint newtargetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D4>()
        .Integer(x => x.newtargetUnitId, 32);
    }
  }

  [Message(6072, 0x00D5)]
  public record Message00D5
  {
    public uint taxiNodeId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D5>()
        .Integer(x => x.taxiNodeId, 32);
    }
  }

  [Message(6072, 0x00D6)]
  public record Message00D6
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D6>();
    }
  }

  [Message(6072, 0x00D7)]
  public record Message00D7
  {
    public uint taxiNodeCount { get; set; }
    public uint[]? taxiNodeData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D7>()
        .Integer(x => x.taxiNodeCount, 32)
        .Array(x => x.taxiNodeData, x => x.taxiNodeCount).OfInteger(32);
    }
  }

  [Message(6072, 0x00D8)]
  public record Message00D8
  {
    public uint unitId { get; set; }
    public uint titleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D8>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.titleId, 32);
    }
  }

  [Message(6072, 0x00D9)]
  public record Message00D9
  {
    public uint titleId { get; set; }
    public uint alreadyowned { get; set; }
    public uint revoked { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D9>()
        .Integer(x => x.titleId, 32)
        .Integer(x => x.alreadyowned, 1)
        .Integer(x => x.revoked, 1);
    }
  }

  [Message(6072, 0x00DA)]
  public record Message00DA
  {
    public uint titleCount { get; set; }
    public Structure038[]? titleData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DA>()
        .Integer(x => x.titleCount, 32)
        .Array(x => x.titleData, x => x.titleCount).OfStructure();
    }
  }

  [Message(6072, 0x00DB)]
  public record Message00DB
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DB>();
    }
  }

  [Message(6072, 0x00DC)]
  public record Message00DC
  {
    public uint tradeType { get; set; }
    public ulong uniqueItemId { get; set; }
    public uint staticId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DC>()
        .Integer(x => x.tradeType, 32)
        .Integer(x => x.uniqueItemId, 64)
        .Integer(x => x.staticId, 32);
    }
  }

  [Message(6072, 0x00DD)]
  public record Message00DD
  {
    public Structure0C3? p2pTradeItem { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DD>()
        .Structure(x => x.p2pTradeItem);
    }
  }

  [Message(6072, 0x00DE)]
  public record Message00DE
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DE>();
    }
  }

  [Message(6072, 0x00DF)]
  public record Message00DF
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DF>();
    }
  }

  [Message(6072, 0x00E0)]
  public record Message00E0
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E0>();
    }
  }

  [Message(6072, 0x00E1)]
  public record Message00E1
  {
    public uint tradeTargetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E1>()
        .Integer(x => x.tradeTargetId, 32);
    }
  }

  [Message(6072, 0x00E2)]
  public record Message00E2
  {
    public uint tradeInitiator { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E2>()
        .Integer(x => x.tradeInitiator, 32);
    }
  }

  [Message(6072, 0x00E3)]
  public record Message00E3
  {
    public uint uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E3>()
        .Integer(x => x.uniqueId, 32);
    }
  }

  [Message(6072, 0x00E4)]
  public record Message00E4
  {
    public uint uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E4>()
        .Integer(x => x.uniqueId, 32);
    }
  }

  [Message(6072, 0x00E5)]
  public record Message00E5
  {
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E5>()
        .Integer(x => x.result, 32);
    }
  }

  [Message(6072, 0x00E6)]
  public record Message00E6
  {
    public uint materialId { get; set; }
    public byte stackCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E6>()
        .Integer(x => x.materialId, 32)
        .Integer(x => x.stackCount, 8);
    }
  }

  [Message(6072, 0x00E7)]
  public record Message00E7
  {
    public uint trainerUnitId { get; set; }
    public uint spellId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E7>()
        .Integer(x => x.trainerUnitId, 32)
        .Integer(x => x.spellId, 32);
    }
  }

  [Message(6072, 0x00E8)]
  public record Message00E8
  {
    public uint unitId { get; set; }
    public int tileId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E8>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.tileId, 32);
    }
  }

  [Message(6072, 0x00E9)]
  public record Message00E9
  {
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E9>()
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6072, 0x00EA)]
  public record Message00EA
  {
    public uint actionBarCount { get; set; }
    public Structure035[]? actionBar { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EA>()
        .Integer(x => x.actionBarCount, 32)
        .Array(x => x.actionBar, x => x.actionBarCount).OfStructure();
    }
  }

  [Message(6072, 0x00EB)]
  public record Message00EB
  {
    public uint attributePoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EB>()
        .Integer(x => x.attributePoints, 32);
    }
  }

  [Message(6072, 0x00EC)]
  public record Message00EC
  {
    public uint delta { get; set; }
    public uint elderPoints { get; set; }
    public uint dailyElderPoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EC>()
        .Integer(x => x.delta, 32)
        .Integer(x => x.elderPoints, 32)
        .Integer(x => x.dailyElderPoints, 32);
    }
  }

  [Message(6072, 0x00ED)]
  public record Message00ED
  {
    public uint factionId { get; set; }
    public float diff { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00ED>()
        .Integer(x => x.factionId, 32)
        .Float(x => x.diff);
    }
  }

  [Message(6072, 0x00EE)]
  public record Message00EE
  {
    public ulong uniqueId { get; set; }
    public float durability { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EE>()
        .Integer(x => x.uniqueId, 64)
        .Float(x => x.durability);
    }
  }

  [Message(6072, 0x00EF)]
  public record Message00EF
  {
    public ulong uniqueId { get; set; }
    public uint dyeData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EF>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.dyeData, 32);
    }
  }

  [Message(6072, 0x00F0)]
  public record Message00F0
  {
    public uint factionId { get; set; }
    public float diff { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F0>()
        .Integer(x => x.factionId, 32)
        .Float(x => x.diff);
    }
  }

  [Message(6072, 0x00F1)]
  public record Message00F1
  {
    public uint itemSetId { get; set; }
    public uint setPower { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F1>()
        .Integer(x => x.itemSetId, 32)
        .Integer(x => x.setPower, 32);
    }
  }

  [Message(6072, 0x00F2)]
  public record Message00F2
  {
    public uint totalXP { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F2>()
        .Integer(x => x.totalXP, 32);
    }
  }

  [Message(6072, 0x00F3)]
  public record Message00F3
  {
    public uint baseXpDelta { get; set; }
    public uint restedXpDelta { get; set; }
    public uint reason { get; set; }
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F3>()
        .Integer(x => x.baseXpDelta, 32)
        .Integer(x => x.restedXpDelta, 32)
        .Integer(x => x.reason, 32)
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6072, 0x00F4)]
  public record Message00F4
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F4>();
    }
  }

  [Message(6072, 0x00F5)]
  public record Message00F5
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F5>();
    }
  }

  [Message(6072, 0x00F6)]
  public record Message00F6
  {
    public uint vehicleUnitId { get; set; }
    public uint seat { get; set; }
    public byte position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F6>()
        .Integer(x => x.vehicleUnitId, 32)
        .Integer(x => x.seat, 2)
        .Integer(x => x.position, 8);
    }
  }

  [Message(6072, 0x00F7)]
  public record Message00F7
  {
    public uint ghostId { get; set; }
    public uint rezCost { get; set; }
    public ushort timeUntilRez { get; set; }
    public uint dead { get; set; }
    public byte showRezFlags { get; set; }
    public ushort timeUntilWakeHere { get; set; }
    public ushort timeUntilForceRez { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F7>()
        .Integer(x => x.ghostId, 32)
        .Integer(x => x.rezCost, 32)
        .Integer(x => x.timeUntilRez, 16)
        .Integer(x => x.dead, 1)
        .Integer(x => x.showRezFlags, 8)
        .Integer(x => x.timeUntilWakeHere, 16)
        .Integer(x => x.timeUntilForceRez, 16);
    }
  }

  [Message(6072, 0x00F8)]
  public record Message00F8
  {
    public uint zoneMapId { get; set; }
    public uint count { get; set; }
    public byte[]? zoneMapBits { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F8>()
        .Integer(x => x.zoneMapId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.zoneMapBits, x => x.count).OfInteger(8);
    }
  }

  [Message(6072, 0x00F9)]
  public record Message00F9
  {
    public uint petId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F9>()
        .Integer(x => x.petId, 32)
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x00FA)]
  public record Message00FA
  {
    public ulong petId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FA>()
        .Integer(x => x.petId, 64);
    }
  }

  [Message(6072, 0x00FB)]
  public record Message00FB
  {
    public uint stance { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FB>()
        .Integer(x => x.stance, 32);
    }
  }

  [Message(6072, 0x00FC)]
  public record Message00FC
  {
    public Structure029? channel { get; set; }
    public string? nameActor { get; set; }
    public string? nameActedOn { get; set; }
    public uint action { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FC>()
        .Structure(x => x.channel)
        .String(x => x.nameActor, true)
        .String(x => x.nameActedOn, true)
        .Integer(x => x.action, 4);
    }
  }

  [Message(6072, 0x00FD)]
  public record Message00FD
  {
    public Structure029? channel { get; set; }
    public string? characterName { get; set; }
    public uint status { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FD>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true)
        .Integer(x => x.status, 1);
    }
  }

  [Message(6072, 0x00FE)]
  public record Message00FE
  {
    public Structure029? channel { get; set; }
    public uint count { get; set; }
    public string[]? names { get; set; }
    public uint more { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FE>()
        .Structure(x => x.channel)
        .Integer(x => x.count, 32)
        .Array(x => x.names, x => x.count).OfString(true)
        .Integer(x => x.more, 1);
    }
  }

  [Message(6072, 0x00FF)]
  public record Message00FF
  {
    public Structure029? channel { get; set; }
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FF>()
        .Structure(x => x.channel)
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6072, 0x0100)]
  public record Message0100
  {
    public string? name { get; set; }
    public string? password { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0100>()
        .String(x => x.name, true)
        .String(x => x.password, true);
    }
  }

  [Message(6072, 0x0101)]
  public record Message0101
  {
    public string? name { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0101>()
        .String(x => x.name, true)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6072, 0x0102)]
  public record Message0102
  {
    public Structure029? channel { get; set; }
    public string? name { get; set; }
    public uint memberCount { get; set; }
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0102>()
        .Structure(x => x.channel)
        .String(x => x.name, true)
        .Integer(x => x.memberCount, 32)
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6072, 0x0103)]
  public record Message0103
  {
    public Structure029? channel { get; set; }
    public string? characterName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0103>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true);
    }
  }

  [Message(6072, 0x0104)]
  public record Message0104
  {
    public Structure029? channel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0104>()
        .Structure(x => x.channel);
    }
  }

  [Message(6072, 0x0105)]
  public record Message0105
  {
    public Structure029? channel { get; set; }
    public uint leave { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0105>()
        .Structure(x => x.channel)
        .Integer(x => x.leave, 2);
    }
  }

  [Message(6072, 0x0106)]
  public record Message0106
  {
    public Structure029? channel { get; set; }
    public uint count { get; set; }
    public string[]? names { get; set; }
    public uint[]? flags { get; set; }
    public uint more { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0106>()
        .Structure(x => x.channel)
        .Integer(x => x.count, 32)
        .Array(x => x.names, x => x.count).OfString(true)
        .Array(x => x.flags, x => x.count).OfInteger(32)
        .Integer(x => x.more, 1);
    }
  }

  [Message(6072, 0x0107)]
  public record Message0107
  {
    public Structure029? channel { get; set; }
    public Structure02A? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0107>()
        .Structure(x => x.channel)
        .Structure(x => x.message);
    }
  }

  [Message(6072, 0x0109)]
  public record Message0109
  {
    public Structure029? channel { get; set; }
    public uint fromId { get; set; }
    public uint messageId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0109>()
        .Structure(x => x.channel)
        .Integer(x => x.fromId, 32)
        .Integer(x => x.messageId, 32);
    }
  }

  [Message(6072, 0x010B)]
  public record Message010B
  {
    public Structure029? channel { get; set; }
    public uint GM { get; set; }
    public uint self { get; set; }
    public string? fromName { get; set; }
    public Structure02A? message { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010B>()
        .Structure(x => x.channel)
        .Integer(x => x.GM, 1)
        .Integer(x => x.self, 1)
        .String(x => x.fromName, true)
        .Structure(x => x.message)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x010D)]
  public record Message010D
  {
    public Structure029? channel { get; set; }
    public uint fromId { get; set; }
    public string? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010D>()
        .Structure(x => x.channel)
        .Integer(x => x.fromId, 32)
        .String(x => x.message, true);
    }
  }

  [Message(6072, 0x010F)]
  public record Message010F
  {
    public Structure029? channel { get; set; }
    public string? characterName { get; set; }
    public uint status { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010F>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true)
        .Integer(x => x.status, 1);
    }
  }

  [Message(6072, 0x0110)]
  public record Message0110
  {
    public Structure029? channel { get; set; }
    public string? characterName { get; set; }
    public uint status { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0110>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true)
        .Integer(x => x.status, 1);
    }
  }

  [Message(6072, 0x0111)]
  public record Message0111
  {
    public Structure029? channel { get; set; }
    public string? characterName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0111>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true);
    }
  }

  [Message(6072, 0x0112)]
  public record Message0112
  {
    public Structure029? channel { get; set; }
    public string? password { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0112>()
        .Structure(x => x.channel)
        .String(x => x.password, true);
    }
  }

  [Message(6072, 0x0113)]
  public record Message0113
  {
    public Structure029? channel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0113>()
        .Structure(x => x.channel);
    }
  }

  [Message(6072, 0x0114)]
  public record Message0114
  {
    public Structure029? channel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0114>()
        .Structure(x => x.channel);
    }
  }

  [Message(6072, 0x0115)]
  public record Message0115
  {
    public Structure029? channel { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0115>()
        .Structure(x => x.channel)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6072, 0x0116)]
  public record Message0116
  {
    public string? characterTo { get; set; }
    public Structure02A? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0116>()
        .String(x => x.characterTo, true)
        .Structure(x => x.message);
    }
  }

  [Message(6072, 0x0117)]
  public record Message0117
  {
    public string? characterTo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0117>()
        .String(x => x.characterTo, true);
    }
  }

  [Message(6072, 0x0118)]
  public record Message0118
  {
    public uint worldZoneId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0118>()
        .Integer(x => x.worldZoneId, 32);
    }
  }

  [Message(6072, 0x011A)]
  public record Message011A
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011A>();
    }
  }

  [Message(6072, 0x011B)]
  public record Message011B
  {
    public uint delay { get; set; }
    public float px { get; set; }
    public float py { get; set; }
    public float pz { get; set; }
    public float vx { get; set; }
    public float vy { get; set; }
    public float vz { get; set; }
    public uint target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011B>()
        .Integer(x => x.delay, 32)
        .Float(x => x.px)
        .Float(x => x.py)
        .Float(x => x.pz)
        .Float(x => x.vx)
        .Float(x => x.vy)
        .Float(x => x.vz)
        .Integer(x => x.target, 1);
    }
  }

  [Message(6072, 0x011C)]
  public record Message011C
  {
    public uint delay { get; set; }
    public uint spline { get; set; }
    public uint splineMode { get; set; }
    public float speed { get; set; }
    public uint target { get; set; }
    public uint useRotation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011C>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.spline, 32)
        .Integer(x => x.splineMode, 32)
        .Float(x => x.speed)
        .Integer(x => x.target, 1)
        .Integer(x => x.useRotation, 1);
    }
  }

  [Message(6072, 0x011D)]
  public record Message011D
  {
    public uint delay { get; set; }
    public uint type { get; set; }
    public ushort durationStart { get; set; }
    public ushort durationMid { get; set; }
    public ushort durationEnd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011D>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.type, 32)
        .Integer(x => x.durationStart, 16)
        .Integer(x => x.durationMid, 16)
        .Integer(x => x.durationEnd, 16);
    }
  }

  [Message(6072, 0x011E)]
  public record Message011E
  {
    public uint delay { get; set; }
    public uint unit { get; set; }
    public uint target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011E>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.unit, 32)
        .Integer(x => x.target, 1);
    }
  }

  [Message(6072, 0x011F)]
  public record Message011F
  {
    public uint delay { get; set; }
    public uint flags { get; set; }
    public uint endTran { get; set; }
    public ushort tranDurationStart { get; set; }
    public ushort tranDurationMid { get; set; }
    public ushort tranDurationEnd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011F>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.endTran, 32)
        .Integer(x => x.tranDurationStart, 16)
        .Integer(x => x.tranDurationMid, 16)
        .Integer(x => x.tranDurationEnd, 16);
    }
  }

  [Message(6072, 0x0120)]
  public record Message0120
  {
    public uint delay { get; set; }
    public uint visualHandle { get; set; }
    public uint from { get; set; }
    public uint to { get; set; }
    public uint missileRecId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0120>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.visualHandle, 32)
        .Integer(x => x.from, 32)
        .Integer(x => x.to, 32)
        .Integer(x => x.missileRecId, 32);
    }
  }

  [Message(6072, 0x0121)]
  public record Message0121
  {
    public uint delay { get; set; }
    public uint visualHandle { get; set; }
    public uint visualEffectId { get; set; }
    public uint unitId { get; set; }
    public float loc_x { get; set; }
    public float loc_y { get; set; }
    public float loc_z { get; set; }
    public uint removeOnCameraEnd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0121>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.visualHandle, 32)
        .Integer(x => x.visualEffectId, 32)
        .Integer(x => x.unitId, 32)
        .Float(x => x.loc_x)
        .Float(x => x.loc_y)
        .Float(x => x.loc_z)
        .Integer(x => x.removeOnCameraEnd, 1);
    }
  }

  [Message(6072, 0x0122)]
  public record Message0122
  {
    public uint delay { get; set; }
    public uint spawnHandle { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0122>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.spawnHandle, 32);
    }
  }

  [Message(6072, 0x0123)]
  public record Message0123
  {
    public byte unused { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0123>()
        .Integer(x => x.unused, 8);
    }
  }

  [Message(6072, 0x0124)]
  public record Message0124
  {
    public uint delay { get; set; }
    public uint unitId { get; set; }
    public uint hide { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0124>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.unitId, 32)
        .Integer(x => x.hide, 1);
    }
  }

  [Message(6072, 0x0125)]
  public record Message0125
  {
    public uint delay { get; set; }
    public float yaw { get; set; }
    public float pitch { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0125>()
        .Integer(x => x.delay, 32)
        .Float(x => x.yaw)
        .Float(x => x.pitch);
    }
  }

  [Message(6072, 0x0126)]
  public record Message0126
  {
    public uint type { get; set; }
    public ushort durationStart { get; set; }
    public ushort durationMid { get; set; }
    public ushort durationEnd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0126>()
        .Integer(x => x.type, 32)
        .Integer(x => x.durationStart, 16)
        .Integer(x => x.durationMid, 16)
        .Integer(x => x.durationEnd, 16);
    }
  }

  [Message(6072, 0x0127)]
  public record Message0127
  {
    public uint delay { get; set; }
    public uint visualHandle { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0127>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.visualHandle, 32);
    }
  }

  [Message(6072, 0x0128)]
  public record Message0128
  {
    public uint delay { get; set; }
    public ushort flags { get; set; }
    public uint spawnHandle { get; set; }
    public uint creatureType { get; set; }
    public uint movementMode { get; set; }
    public float loc_x { get; set; }
    public float loc_y { get; set; }
    public float loc_z { get; set; }
    public ulong activePropId { get; set; }
    public uint socketId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0128>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.flags, 16)
        .Integer(x => x.spawnHandle, 32)
        .Integer(x => x.creatureType, 32)
        .Integer(x => x.movementMode, 32)
        .Float(x => x.loc_x)
        .Float(x => x.loc_y)
        .Float(x => x.loc_z)
        .Integer(x => x.activePropId, 64)
        .Integer(x => x.socketId, 32);
    }
  }

  [Message(6072, 0x0129)]
  public record Message0129
  {
    public uint delay { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0129>()
        .Integer(x => x.delay, 32);
    }
  }

  [Message(6072, 0x012A)]
  public record Message012A
  {
    public uint destinationId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012A>()
        .Integer(x => x.destinationId, 32);
    }
  }

  [Message(6072, 0x012B)]
  public record Message012B
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012B>();
    }
  }

  [Message(6072, 0x012C)]
  public record Message012C
  {
    public uint delay { get; set; }
    public uint show { get; set; }
    public uint animate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012C>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.show, 1)
        .Integer(x => x.animate, 1);
    }
  }

  [Message(6072, 0x012D)]
  public record Message012D
  {
    public uint delay { get; set; }
    public uint actorHandle { get; set; }
    public uint spline { get; set; }
    public float splineSpeed { get; set; }
    public uint splineMode { get; set; }
    public uint useRotation { get; set; }
    public uint strafe { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012D>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.actorHandle, 32)
        .Integer(x => x.spline, 32)
        .Float(x => x.splineSpeed)
        .Integer(x => x.splineMode, 32)
        .Integer(x => x.useRotation, 1)
        .Integer(x => x.strafe, 1);
    }
  }

  [Message(6072, 0x012E)]
  public record Message012E
  {
    public uint delay { get; set; }
    public uint unitId { get; set; }
    public float angle { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012E>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.unitId, 32)
        .Float(x => x.angle);
    }
  }

  [Message(6072, 0x012F)]
  public record Message012F
  {
    public uint delay { get; set; }
    public uint unitId { get; set; }
    public uint mode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012F>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.unitId, 32)
        .Integer(x => x.mode, 32);
    }
  }

  [Message(6072, 0x0130)]
  public record Message0130
  {
    public ushort flags { get; set; }
    public ushort cancel { get; set; }
    public uint duration { get; set; }
    public uint cinematicId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0130>()
        .Integer(x => x.flags, 16)
        .Integer(x => x.cancel, 16)
        .Integer(x => x.duration, 32)
        .Integer(x => x.cinematicId, 32);
    }
  }

  [Message(6072, 0x0133)]
  public record Message0133
  {
    public uint avgMs { get; set; }
    public uint worstMs { get; set; }
    public float worstX { get; set; }
    public float worstY { get; set; }
    public float worstZ { get; set; }
    public uint worstFacing { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0133>()
        .Integer(x => x.avgMs, 32)
        .Integer(x => x.worstMs, 32)
        .Float(x => x.worstX)
        .Float(x => x.worstY)
        .Float(x => x.worstZ)
        .Integer(x => x.worstFacing, 32);
    }
  }

  [Message(6072, 0x0134)]
  public record Message0134
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0134>();
    }
  }

  [Message(6072, 0x0139)]
  public record Message0139
  {
    public string? copyName { get; set; }
    public string? newName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0139>()
        .String(x => x.copyName, true)
        .String(x => x.newName, true);
    }
  }

  [Message(6072, 0x013A)]
  public record Message013A
  {
    public uint index { get; set; }
    public uint[]? itemIds { get; set; }
    public uint displayFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013A>()
        .Integer(x => x.index, 32)
        .Array(x => x.itemIds, 6).OfInteger(32)
        .Integer(x => x.displayFlags, 32);
    }
  }

  [Message(6072, 0x013B)]
  public record Message013B
  {
    public uint index { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013B>()
        .Integer(x => x.index, 32);
    }
  }

  [Message(6072, 0x013C)]
  public record Message013C
  {
    public uint characterCreationId { get; set; }
    public string? name { get; set; }
    public uint skinId { get; set; }
    public uint faceId { get; set; }
    public uint eyeId { get; set; }
    public uint earId { get; set; }
    public uint hairId { get; set; }
    public uint tattooId { get; set; }
    public uint tailId { get; set; }
    public uint handId { get; set; }
    public uint facialHairId { get; set; }
    public uint path { get; set; }
    public uint boneCustomizationCount { get; set; }
    public float[]? boneCustomizations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013C>()
        .Integer(x => x.characterCreationId, 32)
        .String(x => x.name, true)
        .Integer(x => x.skinId, 32)
        .Integer(x => x.faceId, 32)
        .Integer(x => x.eyeId, 32)
        .Integer(x => x.earId, 32)
        .Integer(x => x.hairId, 32)
        .Integer(x => x.tattooId, 32)
        .Integer(x => x.tailId, 32)
        .Integer(x => x.handId, 32)
        .Integer(x => x.facialHairId, 32)
        .Integer(x => x.path, 32)
        .Integer(x => x.boneCustomizationCount, 32)
        .Array(x => x.boneCustomizations, x => x.boneCustomizationCount).OfFloat();
    }
  }

  [Message(6072, 0x013E)]
  public record Message013E
  {
    public uint inventoryCount { get; set; }
    public Structure02F[]? inventory { get; set; }
    public ulong[]? money { get; set; }
    public uint xp { get; set; }
    public uint restBonusXp { get; set; }
    public uint itemProficiencies { get; set; }
    public uint elderPoints { get; set; }
    public uint dailyElderPoints { get; set; }
    public Structure030? factionData { get; set; }
    public uint petCount { get; set; }
    public Structure02E[]? petList { get; set; }
    public uint inputKeySetEnum { get; set; }
    public uint pathXp { get; set; }
    public uint bindPoint { get; set; }
    public uint activeCostumeIndex { get; set; }
    public uint bankBagsUnlocked { get; set; }
    public uint attributePoints { get; set; }
    public uint pvpCooldownRemaining { get; set; }
    public uint knownDyeCount { get; set; }
    public ushort[]? knownDyes { get; set; }
    public byte[]? tradeskillMaterials { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013E>()
        .Integer(x => x.inventoryCount, 32)
        .Array(x => x.inventory, x => x.inventoryCount).OfStructure()
        .Array(x => x.money, 4).OfInteger(64)
        .Integer(x => x.xp, 32)
        .Integer(x => x.restBonusXp, 32)
        .Integer(x => x.itemProficiencies, 32)
        .Integer(x => x.elderPoints, 32)
        .Integer(x => x.dailyElderPoints, 32)
        .Structure(x => x.factionData)
        .Integer(x => x.petCount, 32)
        .Array(x => x.petList, x => x.petCount).OfStructure()
        .Integer(x => x.inputKeySetEnum, 32)
        .Integer(x => x.pathXp, 32)
        .Integer(x => x.bindPoint, 32)
        .Integer(x => x.activeCostumeIndex, 32)
        .Integer(x => x.bankBagsUnlocked, 32)
        .Integer(x => x.attributePoints, 32)
        .Integer(x => x.pvpCooldownRemaining, 32)
        .Integer(x => x.knownDyeCount, 32)
        .Array(x => x.knownDyes, x => x.knownDyeCount).OfInteger(16)
        .Array(x => x.tradeskillMaterials, 196).OfInteger(8);
    }
  }

  [Message(6072, 0x013F)]
  public record Message013F
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
      builder.FieldsOf<Message013F>()
        .Integer(x => x.missileRecId, 32)
        .Integer(x => x.sourceUnitId, 32)
        .Structure(x => x.sourcePosition)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.targetPosition)
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.timeElapsed, 32);
    }
  }

  [Message(6072, 0x0140)]
  public record Message0140
  {
    public uint missileCount { get; set; }
    public Structure05B[]? missiles { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0140>()
        .Integer(x => x.missileCount, 32)
        .Array(x => x.missiles, x => x.missileCount).OfStructure();
    }
  }

  [Message(6072, 0x0141)]
  public record Message0141
  {
    public uint visualCount { get; set; }
    public Structure05A[]? visuals { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0141>()
        .Integer(x => x.visualCount, 32)
        .Array(x => x.visuals, x => x.visualCount).OfStructure();
    }
  }

  [Message(6072, 0x0142)]
  public record Message0142
  {
    public string? realmName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0142>()
        .String(x => x.realmName, true);
    }
  }

  [Message(6072, 0x0143)]
  public record Message0143
  {
    public uint unitId { get; set; }
    public uint unitType { get; set; }
    public Union006? unitInfo { get; set; }
    public uint createFlags { get; set; }
    public uint statCount { get; set; }
    public Structure081[]? stats { get; set; }
    public uint time { get; set; }
    public ushort commandCount { get; set; }
    public Structure082[]? commands { get; set; }
    public uint propertyCount { get; set; }
    public Structure0A1[]? properties { get; set; }
    public uint equipmentCount { get; set; }
    public Structure01A[]? equipment { get; set; }
    public ushort spellCastInitCount { get; set; }
    public Structure05D[]? spellInit { get; set; }
    public uint currentSpellUniqueId { get; set; }
    public uint factionId { get; set; }
    public uint unitTagOwner { get; set; }
    public ulong groupTagOwner { get; set; }
    public uint timeSinceDeath { get; set; }
    public ulong activePropId { get; set; }
    public uint socketId { get; set; }
    public uint tileId { get; set; }
    public uint clusterId { get; set; }
    public uint creatureSetId { get; set; }
    public uint lootFlags { get; set; }
    public uint vendorPrereqId { get; set; }
    public uint characterTitleId { get; set; }
    public uint miniMapMarker { get; set; }
    public uint displayInfoId { get; set; }
    public uint outfitInfoId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0143>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.unitType, 6)
        .Union(x => x.unitInfo, x => x.unitType, matches =>
          matches
            .Match(x => x.nonPlayer, 0)
            .Match(x => x.chest, 1)
            .Match(x => x.destructible, 2)
            .Match(x => x.vehicle, 3)
            .Match(x => x.door, 4)
            .Match(x => x.harvestUnit, 5)
            .Match(x => x.corpseUnit, 6)
            .Match(x => x.mount, 7)
            .Match(x => x.collectableUnit, 8)
            .Match(x => x.taxi, 9)
            .Match(x => x.simple, 10)
            .Match(x => x.platform, 11)
            .Match(x => x.mailBox, 12)
            .Match(x => x.aiTurret, 13)
            .Match(x => x.instancePortal, 14)
            .Match(x => x.plug, 15)
            .Match(x => x.residence, 16)
            .Match(x => x.pinataLoot, 17)
            .Match(x => x.bindPoint, 18)
            .Match(x => x.player, 19)
            .Match(x => x.hidden, 20)
            .Match(x => x.trigger, 21)
            .Match(x => x.ghost, 22)
            .Match(x => x.pet, 23)
            .Match(x => x.esperPet, 24)
            .Match(x => x.worldUnit, 25)
            .Match(x => x.scannerUnit, 26)
            .Match(x => x.camera, 27)
            .Match(x => x.trap, 28)
            .Match(x => x.destructibledoor, 29)
            .Match(x => x.pickup, 30)
            .Match(x => x.simpleCollidable, 31))
        .Integer(x => x.createFlags, 32)
        .Integer(x => x.statCount, 32)
        .Array(x => x.stats, x => x.statCount).OfStructure()
        .Integer(x => x.time, 32)
        .Integer(x => x.commandCount, 16)
        .Array(x => x.commands, x => x.commandCount).OfStructure()
        .Integer(x => x.propertyCount, 32)
        .Array(x => x.properties, x => x.propertyCount).OfStructure()
        .Integer(x => x.equipmentCount, 32)
        .Array(x => x.equipment, x => x.equipmentCount).OfStructure()
        .Integer(x => x.spellCastInitCount, 16)
        .Array(x => x.spellInit, x => x.spellCastInitCount).OfStructure()
        .Integer(x => x.currentSpellUniqueId, 32)
        .Integer(x => x.factionId, 32)
        .Integer(x => x.unitTagOwner, 32)
        .Integer(x => x.groupTagOwner, 64)
        .Integer(x => x.timeSinceDeath, 32)
        .Integer(x => x.activePropId, 64)
        .Integer(x => x.socketId, 32)
        .Integer(x => x.tileId, 32)
        .Integer(x => x.clusterId, 32)
        .Integer(x => x.creatureSetId, 32)
        .Integer(x => x.lootFlags, 32)
        .Integer(x => x.vendorPrereqId, 32)
        .Integer(x => x.characterTitleId, 32)
        .Integer(x => x.miniMapMarker, 32)
        .Integer(x => x.displayInfoId, 32)
        .Integer(x => x.outfitInfoId, 32);
    }
  }

  [Message(6072, 0x0144)]
  public record Message0144
  {
    public uint serverUniqueId { get; set; }
    public uint sourceUnitId { get; set; }
    public uint visualEffectId { get; set; }
    public uint timeElapsed { get; set; }
    public Structure015? sourceLocation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0144>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.sourceUnitId, 32)
        .Integer(x => x.visualEffectId, 32)
        .Integer(x => x.timeElapsed, 32)
        .Structure(x => x.sourceLocation);
    }
  }

  [Message(6072, 0x0145)]
  public record Message0145
  {
    public uint sourceUnitId { get; set; }
    public uint spell4VisualGroupId { get; set; }
    public uint timeElapsed { get; set; }
    public uint visualCount { get; set; }
    public uint[]? serverUniqueIdList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0145>()
        .Integer(x => x.sourceUnitId, 32)
        .Integer(x => x.spell4VisualGroupId, 32)
        .Integer(x => x.timeElapsed, 32)
        .Integer(x => x.visualCount, 32)
        .Array(x => x.serverUniqueIdList, x => x.visualCount).OfInteger(32);
    }
  }

  [Message(6072, 0x016D)]
  public record Message016D
  {
    public uint creatureId { get; set; }
    public string? text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message016D>()
        .Integer(x => x.creatureId, 32)
        .String(x => x.text, true);
    }
  }

  [Message(6072, 0x016E)]
  public record Message016E
  {
    public Structure015? a { get; set; }
    public Structure015? b { get; set; }
    public Structure015? c { get; set; }
    public Structure015? d { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message016E>()
        .Structure(x => x.a)
        .Structure(x => x.b)
        .Structure(x => x.c)
        .Structure(x => x.d);
    }
  }

  [Message(6072, 0x016F)]
  public record Message016F
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message016F>();
    }
  }

  [Message(6072, 0x0170)]
  public record Message0170
  {
    public uint primId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0170>()
        .Integer(x => x.primId, 32);
    }
  }

  [Message(6072, 0x0171)]
  public record Message0171
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0171>();
    }
  }

  [Message(6072, 0x0172)]
  public record Message0172
  {
    public uint type { get; set; }
    public Structure0B5? color { get; set; }
    public uint primId { get; set; }
    public uint lifetime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0172>()
        .Integer(x => x.type, 5)
        .Structure(x => x.color)
        .Integer(x => x.primId, 32)
        .Integer(x => x.lifetime, 32);
    }
  }

  [Message(6072, 0x0173)]
  public record Message0173
  {
    public Structure0B5? color { get; set; }
    public Structure015? a { get; set; }
    public Structure015? b { get; set; }
    public Structure015? c { get; set; }
    public Structure015? d { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0173>()
        .Structure(x => x.color)
        .Structure(x => x.a)
        .Structure(x => x.b)
        .Structure(x => x.c)
        .Structure(x => x.d);
    }
  }

  [Message(6072, 0x0174)]
  public record Message0174
  {
    public string? gatherMode { get; set; }
    public uint runTime { get; set; }
    public uint totalTime { get; set; }
    public uint totalCalls { get; set; }
    public uint totalItems { get; set; }
    public uint count { get; set; }
    public Structure0B6[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0174>()
        .String(x => x.gatherMode, true)
        .Integer(x => x.runTime, 32)
        .Integer(x => x.totalTime, 32)
        .Integer(x => x.totalCalls, 32)
        .Integer(x => x.totalItems, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.items, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0175)]
  public record Message0175
  {
    public uint unitId { get; set; }
    public uint drawMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0175>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.drawMode, 2);
    }
  }

  [Message(6072, 0x0176)]
  public record Message0176
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0176>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x0177)]
  public record Message0177
  {
    public uint unitId { get; set; }
    public Structure015? position { get; set; }
    public Structure015? direction { get; set; }
    public float time { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0177>()
        .Integer(x => x.unitId, 32)
        .Structure(x => x.position)
        .Structure(x => x.direction)
        .Float(x => x.time);
    }
  }

  [Message(6072, 0x0178)]
  public record Message0178
  {
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0178>()
        .Integer(x => x.characterId, 64);
    }
  }

  [Message(6072, 0x017A)]
  public record Message017A
  {
    public uint realmId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message017A>()
        .Integer(x => x.realmId, 32);
    }
  }

  [Message(6072, 0x017B)]
  public record Message017B
  {
    public uint unitId { get; set; }
    public uint wasDestroyed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message017B>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.wasDestroyed, 1);
    }
  }

  [Message(6072, 0x017C)]
  public record Message017C
  {
    public uint m_achievementId { get; set; }
    public uint m_value00 { get; set; }
    public uint m_value01 { get; set; }
    public ulong m_dateCompleted { get; set; }
    public uint m_deleted { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message017C>()
        .Integer(x => x.m_achievementId, 32)
        .Integer(x => x.m_value00, 32)
        .Integer(x => x.m_value01, 32)
        .Integer(x => x.m_dateCompleted, 64)
        .Integer(x => x.m_deleted, 1);
    }
  }

  [Message(6072, 0x017D)]
  public record Message017D
  {
    public uint m_targetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message017D>()
        .Integer(x => x.m_targetId, 32);
    }
  }

  [Message(6072, 0x017E)]
  public record Message017E
  {
    public uint m_target { get; set; }
    public uint m_isCommunique { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message017E>()
        .Integer(x => x.m_target, 32)
        .Integer(x => x.m_isCommunique, 1);
    }
  }

  [Message(6072, 0x017F)]
  public record Message017F
  {
    public uint m_targetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message017F>()
        .Integer(x => x.m_targetId, 32);
    }
  }

  [Message(6072, 0x0180)]
  public record Message0180
  {
    public uint m_target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0180>()
        .Integer(x => x.m_target, 32);
    }
  }

  [Message(6072, 0x0181)]
  public record Message0181
  {
    public uint m_event { get; set; }
    public uint m_argCount { get; set; }
    public Structure03E[]? m_args { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0181>()
        .Integer(x => x.m_event, 32)
        .Integer(x => x.m_argCount, 32)
        .Array(x => x.m_args, x => x.m_argCount).OfStructure();
    }
  }

  [Message(6072, 0x0182)]
  public record Message0182
  {
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0182>()
        .Integer(x => x.m_questId, 32);
    }
  }

  [Message(6072, 0x0183)]
  public record Message0183
  {
    public uint m_targetId { get; set; }
    public Structure02C? m_location { get; set; }
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0183>()
        .Integer(x => x.m_targetId, 32)
        .Structure(x => x.m_location)
        .Integer(x => x.m_questId, 32);
    }
  }

  [Message(6072, 0x0184)]
  public record Message0184
  {
    public uint m_id { get; set; }
    public uint m_state { get; set; }
    public uint m_randomResultId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0184>()
        .Integer(x => x.m_id, 32)
        .Integer(x => x.m_state, 32)
        .Integer(x => x.m_randomResultId, 32);
    }
  }

  [Message(6072, 0x0185)]
  public record Message0185
  {
    public uint m_targetId { get; set; }
    public uint m_questId { get; set; }
    public uint m_rewardSelection { get; set; }
    public uint m_isCommunique { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0185>()
        .Integer(x => x.m_targetId, 32)
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_rewardSelection, 32)
        .Integer(x => x.m_isCommunique, 1);
    }
  }

  [Message(6072, 0x0186)]
  public record Message0186
  {
    public uint m_dailyRandomSeed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0186>()
        .Integer(x => x.m_dailyRandomSeed, 32);
    }
  }

  [Message(6072, 0x0187)]
  public record Message0187
  {
    public uint m_questId { get; set; }
    public uint m_bIgnored { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0187>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_bIgnored, 1);
    }
  }

  [Message(6072, 0x0188)]
  public record Message0188
  {
    public uint m_completedCount { get; set; }
    public Structure03B[]? m_completed { get; set; }
    public uint m_inactiveCount { get; set; }
    public Structure03C[]? m_inactive { get; set; }
    public uint m_activeCount { get; set; }
    public Structure03D[]? m_active { get; set; }
    public uint m_periodicCount { get; set; }
    public uint[]? m_periodic { get; set; }
    public uint m_dailyRandomSeed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0188>()
        .Integer(x => x.m_completedCount, 32)
        .Array(x => x.m_completed, x => x.m_completedCount).OfStructure()
        .Integer(x => x.m_inactiveCount, 32)
        .Array(x => x.m_inactive, x => x.m_inactiveCount).OfStructure()
        .Integer(x => x.m_activeCount, 32)
        .Array(x => x.m_active, x => x.m_activeCount).OfStructure()
        .Integer(x => x.m_periodicCount, 32)
        .Array(x => x.m_periodic, x => x.m_periodicCount).OfInteger(32)
        .Integer(x => x.m_dailyRandomSeed, 32);
    }
  }

  [Message(6072, 0x0189)]
  public record Message0189
  {
    public uint m_questId { get; set; }
    public uint m_bMentioned { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0189>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_bMentioned, 1);
    }
  }

  [Message(6072, 0x018A)]
  public record Message018A
  {
    public uint m_questId { get; set; }
    public uint m_index { get; set; }
    public uint m_completed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message018A>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_index, 32)
        .Integer(x => x.m_completed, 32);
    }
  }

  [Message(6072, 0x018B)]
  public record Message018B
  {
    public uint m_sharer { get; set; }
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message018B>()
        .Integer(x => x.m_sharer, 32)
        .Integer(x => x.m_questId, 32);
    }
  }

  [Message(6072, 0x018C)]
  public record Message018C
  {
    public uint m_questId { get; set; }
    public uint m_bTracked { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message018C>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_bTracked, 1);
    }
  }

  [Message(6072, 0x018D)]
  public record Message018D
  {
    public uint m_targetId { get; set; }
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message018D>()
        .Integer(x => x.m_targetId, 32)
        .Integer(x => x.m_questId, 32);
    }
  }

  [Message(6072, 0x0190)]
  public record Message0190
  {
    public uint eventId { get; set; }
    public uint deleting { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0190>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.deleting, 1);
    }
  }

  [Message(6072, 0x0191)]
  public record Message0191
  {
    public uint emotesId { get; set; }
    public uint seed { get; set; }
    public uint targetUnitId { get; set; }
    public uint targeted { get; set; }
    public uint silent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0191>()
        .Integer(x => x.emotesId, 32)
        .Integer(x => x.seed, 32)
        .Integer(x => x.targetUnitId, 32)
        .Integer(x => x.targeted, 1)
        .Integer(x => x.silent, 1);
    }
  }

  [Message(6072, 0x0192)]
  public record Message0192
  {
    public uint emotesId { get; set; }
    public uint seed { get; set; }
    public uint sourceUnitId { get; set; }
    public uint targetUnitId { get; set; }
    public uint targeted { get; set; }
    public uint silent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0192>()
        .Integer(x => x.emotesId, 32)
        .Integer(x => x.seed, 32)
        .Integer(x => x.sourceUnitId, 32)
        .Integer(x => x.targetUnitId, 32)
        .Integer(x => x.targeted, 1)
        .Integer(x => x.silent, 1);
    }
  }

  [Message(6072, 0x0198)]
  public record Message0198
  {
    public Structure012? gatewayAddress { get; set; }
    public byte[]? gatewayTicket { get; set; }
    public uint accountId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0198>()
        .Structure(x => x.gatewayAddress)
        .Array(x => x.gatewayTicket, 16).Aligned(true).OfInteger(8)
        .Integer(x => x.accountId, 32);
    }
  }

  [Message(6072, 0x019B)]
  public record Message019B
  {
    public string? cheatString { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message019B>()
        .String(x => x.cheatString, true);
    }
  }

  [Message(6072, 0x019C)]
  public record Message019C
  {
    public string? debugString { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message019C>()
        .String(x => x.debugString, true);
    }
  }

  [Message(6072, 0x019D)]
  public record Message019D
  {
    public string? titleString { get; set; }
    public string? messageString { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message019D>()
        .String(x => x.titleString, true)
        .String(x => x.messageString, true);
    }
  }

  [Message(6072, 0x019E)]
  public record Message019E
  {
    public string? commandString { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message019E>()
        .String(x => x.commandString, true);
    }
  }

  [Message(6072, 0x019F)]
  public record Message019F
  {
    public ulong groupId { get; set; }
    public Structure025? member { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message019F>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.member);
    }
  }

  [Message(6072, 0x01A0)]
  public record Message01A0
  {
    public ulong groupId { get; set; }
    public uint groupFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A0>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.groupFlags, 32);
    }
  }

  [Message(6072, 0x01A2)]
  public record Message01A2
  {
    public ulong groupId { get; set; }
    public Structure024? identity { get; set; }
    public uint memberFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A2>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.memberFlags, 32);
    }
  }

  [Message(6072, 0x01A6)]
  public record Message01A6
  {
    public ulong groupId { get; set; }
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A6>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6072, 0x01A7)]
  public record Message01A7
  {
    public ulong groupId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A7>()
        .Integer(x => x.groupId, 64);
    }
  }

  [Message(6072, 0x01A8)]
  public record Message01A8
  {
    public ulong groupId { get; set; }
    public uint worldDifficulty { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A8>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.worldDifficulty, 2);
    }
  }

  [Message(6072, 0x01AA)]
  public record Message01AA
  {
    public ulong groupId { get; set; }
    public uint worldGameMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01AA>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.worldGameMode, 3);
    }
  }

  [Message(6072, 0x01AC)]
  public record Message01AC
  {
    public ulong groupId { get; set; }
    public uint worldDifficulty { get; set; }
    public uint worldGameMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01AC>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.worldDifficulty, 2)
        .Integer(x => x.worldGameMode, 3);
    }
  }

  [Message(6072, 0x01AE)]
  public record Message01AE
  {
    public ulong groupId { get; set; }
    public string? inviteeName { get; set; }
    public string? inviteeRealm { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01AE>()
        .Integer(x => x.groupId, 64)
        .String(x => x.inviteeName, true)
        .String(x => x.inviteeRealm, true);
    }
  }

  [Message(6072, 0x01B2)]
  public record Message01B2
  {
    public ulong inviteId { get; set; }
    public uint accept { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B2>()
        .Integer(x => x.inviteId, 64)
        .Integer(x => x.accept, 1);
    }
  }

  [Message(6072, 0x01B4)]
  public record Message01B4
  {
    public ulong inviteId { get; set; }
    public string? name { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B4>()
        .Integer(x => x.inviteId, 64)
        .String(x => x.name, true)
        .Integer(x => x.result, 4);
    }
  }

  [Message(6072, 0x01B6)]
  public record Message01B6
  {
    public ulong inviteId { get; set; }
    public Structure027? inviteStats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B6>()
        .Integer(x => x.inviteId, 64)
        .Structure(x => x.inviteStats);
    }
  }

  [Message(6072, 0x01B8)]
  public record Message01B8
  {
    public Structure024? identity { get; set; }
    public Structure028? group { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B8>()
        .Structure(x => x.identity)
        .Structure(x => x.group);
    }
  }

  [Message(6072, 0x01B9)]
  public record Message01B9
  {
    public ulong groupId { get; set; }
    public Structure024? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B9>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity);
    }
  }

  [Message(6072, 0x01BB)]
  public record Message01BB
  {
    public uint referenceType { get; set; }
    public uint referenceId { get; set; }
    public uint joinPhaseAllowed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01BB>()
        .Integer(x => x.referenceType, 32)
        .Integer(x => x.referenceId, 32)
        .Integer(x => x.joinPhaseAllowed, 1);
    }
  }

  [Message(6072, 0x01BC)]
  public record Message01BC
  {
    public ulong groupId { get; set; }
    public uint disband { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01BC>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.disband, 1);
    }
  }

  [Message(6072, 0x01BE)]
  public record Message01BE
  {
    public ulong groupId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01BE>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.reason, 3);
    }
  }

  [Message(6072, 0x01BF)]
  public record Message01BF
  {
    public ulong groupId { get; set; }
    public uint normalRule { get; set; }
    public uint thresholdRule { get; set; }
    public uint thresholdQuality { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01BF>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.normalRule, 3)
        .Integer(x => x.thresholdRule, 3)
        .Integer(x => x.thresholdQuality, 4);
    }
  }

  [Message(6072, 0x01C0)]
  public record Message01C0
  {
    public ulong groupId { get; set; }
    public uint normalRule { get; set; }
    public uint thresholdRule { get; set; }
    public uint thresholdQuality { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01C0>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.normalRule, 3)
        .Integer(x => x.thresholdRule, 3)
        .Integer(x => x.thresholdQuality, 4);
    }
  }

  [Message(6072, 0x01C2)]
  public record Message01C2
  {
    public ulong groupId { get; set; }
    public Structure024? identity { get; set; }
    public uint flags { get; set; }
    public uint isFromPromotion { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01C2>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.flags, 32)
        .Integer(x => x.isFromPromotion, 1);
    }
  }

  [Message(6072, 0x01C4)]
  public record Message01C4
  {
    public ulong groupId { get; set; }
    public Structure024? identity { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01C4>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6072, 0x01C7)]
  public record Message01C7
  {
    public ulong groupId { get; set; }
    public Structure024? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01C7>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity);
    }
  }

  [Message(6072, 0x01C8)]
  public record Message01C8
  {
    public ulong groupId { get; set; }
    public Structure024? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01C8>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity);
    }
  }

  [Message(6072, 0x01CA)]
  public record Message01CA
  {
    public ulong groupId { get; set; }
    public Structure024? identity { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01CA>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.reason, 3);
    }
  }

  [Message(6072, 0x01CC)]
  public record Message01CC
  {
    public Structure024? identity { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01CC>()
        .Structure(x => x.identity)
        .Structure(x => x.position);
    }
  }

  [Message(6072, 0x01CD)]
  public record Message01CD
  {
    public Structure024? identity { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01CD>()
        .Structure(x => x.identity)
        .Structure(x => x.position);
    }
  }

  [Message(6072, 0x01CE)]
  public record Message01CE
  {
    public uint questId { get; set; }
    public uint accept { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01CE>()
        .Integer(x => x.questId, 32)
        .Integer(x => x.accept, 1);
    }
  }

  [Message(6072, 0x01CF)]
  public record Message01CF
  {
    public uint questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01CF>()
        .Integer(x => x.questId, 32);
    }
  }

  [Message(6072, 0x01D0)]
  public record Message01D0
  {
    public uint questId { get; set; }
    public uint role { get; set; }
    public uint result { get; set; }
    public uint context { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D0>()
        .Integer(x => x.questId, 32)
        .Integer(x => x.role, 32)
        .Integer(x => x.result, 32)
        .Integer(x => x.context, 32);
    }
  }

  [Message(6072, 0x01D1)]
  public record Message01D1
  {
    public uint questId { get; set; }
    public uint role { get; set; }
    public uint result { get; set; }
    public uint context { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D1>()
        .Integer(x => x.questId, 32)
        .Integer(x => x.role, 32)
        .Integer(x => x.result, 32)
        .Integer(x => x.context, 32);
    }
  }

  [Message(6072, 0x01D2)]
  public record Message01D2
  {
    public ulong groupId { get; set; }
    public uint size { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D2>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.size, 32);
    }
  }

  [Message(6072, 0x01D3)]
  public record Message01D3
  {
    public ulong groupId { get; set; }
    public Structure024? identity { get; set; }
    public uint level { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D3>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.level, 32);
    }
  }

  [Message(6072, 0x01D4)]
  public record Message01D4
  {
    public ulong groupId { get; set; }
    public uint worldId { get; set; }
    public uint count { get; set; }
    public Structure024[]? identity { get; set; }
    public Structure015[]? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D4>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.identity, x => x.count).OfStructure()
        .Array(x => x.position, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x01D5)]
  public record Message01D5
  {
    public Structure045? guild { get; set; }
    public Structure02D? item { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D5>()
        .Structure(x => x.guild)
        .Structure(x => x.item);
    }
  }

  [Message(6072, 0x01D6)]
  public record Message01D6
  {
    public Structure045? guild { get; set; }
    public ulong characterItemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D6>()
        .Structure(x => x.guild)
        .Integer(x => x.characterItemId, 64);
    }
  }

  [Message(6072, 0x01D7)]
  public record Message01D7
  {
    public Structure04B? guild { get; set; }
    public Structure04D? item { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D7>()
        .Structure(x => x.guild)
        .Structure(x => x.item);
    }
  }

  [Message(6072, 0x01D9)]
  public record Message01D9
  {
    public Structure04B? guild { get; set; }
    public ulong characterItemIdGuild { get; set; }
    public uint itemIdGuild { get; set; }
    public Structure02C? locationTo { get; set; }
    public Structure02C? locationFrom { get; set; }
    public uint stackCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D9>()
        .Structure(x => x.guild)
        .Integer(x => x.characterItemIdGuild, 64)
        .Integer(x => x.itemIdGuild, 32)
        .Structure(x => x.locationTo)
        .Structure(x => x.locationFrom)
        .Integer(x => x.stackCount, 32);
    }
  }

  [Message(6072, 0x01DC)]
  public record Message01DC
  {
    public Structure045? guild { get; set; }
    public ulong characterItemId { get; set; }
    public uint stackCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DC>()
        .Structure(x => x.guild)
        .Integer(x => x.characterItemId, 64)
        .Integer(x => x.stackCount, 32);
    }
  }

  [Message(6072, 0x01DD)]
  public record Message01DD
  {
    public Structure04B? guild { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DD>()
        .Structure(x => x.guild);
    }
  }

  [Message(6072, 0x01DF)]
  public record Message01DF
  {
    public Structure04B? guild { get; set; }
    public uint location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DF>()
        .Structure(x => x.guild)
        .Integer(x => x.location, 8);
    }
  }

  [Message(6072, 0x01E0)]
  public record Message01E0
  {
    public Structure045? guild { get; set; }
    public uint bankTabCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E0>()
        .Structure(x => x.guild)
        .Integer(x => x.bankTabCount, 32);
    }
  }

  [Message(6072, 0x01E1)]
  public record Message01E1
  {
    public Structure045? guild { get; set; }
    public string[]? bankTabName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E1>()
        .Structure(x => x.guild)
        .Array(x => x.bankTabName, 10).OfString(true);
    }
  }

  [Message(6072, 0x01E2)]
  public record Message01E2
  {
    public Structure045? guild { get; set; }
    public uint location { get; set; }
    public uint count { get; set; }
    public Structure02D[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E2>()
        .Structure(x => x.guild)
        .Integer(x => x.location, 8)
        .Integer(x => x.count, 32)
        .Array(x => x.items, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x01E4)]
  public record Message01E4
  {
    public uint unitId { get; set; }
    public Structure047? create { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E4>()
        .Integer(x => x.unitId, 32)
        .Structure(x => x.create);
    }
  }

  [Message(6072, 0x01E7)]
  public record Message01E7
  {
    public Structure045? guild { get; set; }
    public Structure048? emblem { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E7>()
        .Structure(x => x.guild)
        .Structure(x => x.emblem);
    }
  }

  [Message(6072, 0x01E9)]
  public record Message01E9
  {
    public Structure045? guild { get; set; }
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E9>()
        .Structure(x => x.guild)
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6072, 0x01EB)]
  public record Message01EB
  {
    public Structure045? guild { get; set; }
    public uint influence { get; set; }
    public ulong money { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01EB>()
        .Structure(x => x.guild)
        .Integer(x => x.influence, 32)
        .Integer(x => x.money, 64);
    }
  }

  [Message(6072, 0x01ED)]
  public record Message01ED
  {
    public uint accept { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01ED>()
        .Integer(x => x.accept, 1);
    }
  }

  [Message(6072, 0x01EE)]
  public record Message01EE
  {
    public string? who { get; set; }
    public string? guild { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01EE>()
        .String(x => x.who, true)
        .String(x => x.guild, true)
        .Integer(x => x.type, 3);
    }
  }

  [Message(6072, 0x01EF)]
  public record Message01EF
  {
    public Structure04E? guild { get; set; }
    public Structure050? self { get; set; }
    public Structure051? selfPrivate { get; set; }
    public uint nameplate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01EF>()
        .Structure(x => x.guild)
        .Structure(x => x.self)
        .Structure(x => x.selfPrivate)
        .Integer(x => x.nameplate, 1);
    }
  }

  [Message(6072, 0x01F1)]
  public record Message01F1
  {
    public Structure045? guild { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F1>()
        .Structure(x => x.guild);
    }
  }

  [Message(6072, 0x01F3)]
  public record Message01F3
  {
    public uint count { get; set; }
    public uint nameplateIndex { get; set; }
    public Structure04E[]? guilds { get; set; }
    public Structure050[]? self { get; set; }
    public Structure051[]? selfPrivate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F3>()
        .Integer(x => x.count, 32)
        .Integer(x => x.nameplateIndex, 32)
        .Array(x => x.guilds, x => x.count).OfStructure()
        .Array(x => x.self, x => x.count).OfStructure()
        .Array(x => x.selfPrivate, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x01F5)]
  public record Message01F5
  {
    public Structure045? guild { get; set; }
    public uint count { get; set; }
    public Structure050[]? members { get; set; }
    public uint done { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F5>()
        .Structure(x => x.guild)
        .Integer(x => x.count, 32)
        .Array(x => x.members, x => x.count).OfStructure()
        .Integer(x => x.done, 1);
    }
  }

  [Message(6072, 0x01F6)]
  public record Message01F6
  {
    public Structure045? guild { get; set; }
    public Structure051? selfPrivate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F6>()
        .Structure(x => x.guild)
        .Structure(x => x.selfPrivate);
    }
  }

  [Message(6072, 0x01F7)]
  public record Message01F7
  {
    public Structure045? guild { get; set; }
    public Structure024? identity { get; set; }
    public ushort memberCount { get; set; }
    public ushort onlineMemberCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F7>()
        .Structure(x => x.guild)
        .Structure(x => x.identity)
        .Integer(x => x.memberCount, 16)
        .Integer(x => x.onlineMemberCount, 16);
    }
  }

  [Message(6072, 0x01F8)]
  public record Message01F8
  {
    public Structure045? guild { get; set; }
    public Structure050? member { get; set; }
    public ushort memberCount { get; set; }
    public ushort onlineMemberCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F8>()
        .Structure(x => x.guild)
        .Structure(x => x.member)
        .Integer(x => x.memberCount, 16)
        .Integer(x => x.onlineMemberCount, 16);
    }
  }

  [Message(6072, 0x01F9)]
  public record Message01F9
  {
    public Structure04B? guild { get; set; }
    public Structure04C? modify { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F9>()
        .Structure(x => x.guild)
        .Structure(x => x.modify);
    }
  }

  [Message(6072, 0x01FB)]
  public record Message01FB
  {
    public Structure04B? guild { get; set; }
    public ulong moneyFromGuild { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01FB>()
        .Structure(x => x.guild)
        .Integer(x => x.moneyFromGuild, 64);
    }
  }

  [Message(6072, 0x01FF)]
  public record Message01FF
  {
    public Structure045? guild { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01FF>()
        .Structure(x => x.guild);
    }
  }

  [Message(6072, 0x0201)]
  public record Message0201
  {
    public uint unitId { get; set; }
    public string? guildName { get; set; }
    public uint type { get; set; }
    public Structure048? emblem { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0201>()
        .Integer(x => x.unitId, 32)
        .String(x => x.guildName, true)
        .Integer(x => x.type, 3)
        .Structure(x => x.emblem);
    }
  }

  [Message(6072, 0x0202)]
  public record Message0202
  {
    public Structure045? guild { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0202>()
        .Structure(x => x.guild)
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x0204)]
  public record Message0204
  {
    public Structure045? guild { get; set; }
    public Structure046? operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0204>()
        .Structure(x => x.guild)
        .Structure(x => x.operation);
    }
  }

  [Message(6072, 0x0205)]
  public record Message0205
  {
    public Structure04B? guild { get; set; }
    public Structure046? operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0205>()
        .Structure(x => x.guild)
        .Structure(x => x.operation);
    }
  }

  [Message(6072, 0x0207)]
  public record Message0207
  {
    public Structure045? guild { get; set; }
    public uint pvpWins { get; set; }
    public uint pvpLosses { get; set; }
    public uint pvpDraws { get; set; }
    public uint pvpRating { get; set; }
    public uint pvpSeason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0207>()
        .Structure(x => x.guild)
        .Integer(x => x.pvpWins, 32)
        .Integer(x => x.pvpLosses, 32)
        .Integer(x => x.pvpDraws, 32)
        .Integer(x => x.pvpRating, 32)
        .Integer(x => x.pvpSeason, 32);
    }
  }

  [Message(6072, 0x0208)]
  public record Message0208
  {
    public Structure045? guild { get; set; }
    public Structure04F[]? ranks { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0208>()
        .Structure(x => x.guild)
        .Array(x => x.ranks, 10).OfStructure();
    }
  }

  [Message(6072, 0x0209)]
  public record Message0209
  {
    public Structure045? guild { get; set; }
    public uint rank { get; set; }
    public string? who { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0209>()
        .Structure(x => x.guild)
        .Integer(x => x.rank, 32)
        .String(x => x.who, true)
        .Integer(x => x.result, 7);
    }
  }

  [Message(6072, 0x020A)]
  public record Message020A
  {
    public Structure045? guild { get; set; }
    public uint rank { get; set; }
    public string? who { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message020A>()
        .Structure(x => x.guild)
        .Integer(x => x.rank, 32)
        .String(x => x.who, true)
        .Integer(x => x.result, 7);
    }
  }

  [Message(6072, 0x020B)]
  public record Message020B
  {
    public Structure04B? guild { get; set; }
    public Structure049? standard { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message020B>()
        .Structure(x => x.guild)
        .Structure(x => x.standard);
    }
  }

  [Message(6072, 0x020C)]
  public record Message020C
  {
    public Structure045? guild { get; set; }
    public Structure049? standard { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message020C>()
        .Structure(x => x.guild)
        .Structure(x => x.standard);
    }
  }

  [Message(6072, 0x020F)]
  public record Message020F
  {
    public uint unitId { get; set; }
    public byte guildCount { get; set; }
    public ulong[]? guildIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message020F>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.guildCount, 8)
        .Array(x => x.guildIds, x => x.guildCount).OfInteger(64);
    }
  }

  [Message(6072, 0x0212)]
  public record Message0212
  {
    public ulong neighborhoodId { get; set; }
    public uint count { get; set; }
    public Structure0AC[]? residences { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0212>()
        .Integer(x => x.neighborhoodId, 64)
        .Integer(x => x.count, 32)
        .Array(x => x.residences, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0213)]
  public record Message0213
  {
    public uint count { get; set; }
    public Structure0AA[]? decors { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0213>()
        .Integer(x => x.count, 32)
        .Array(x => x.decors, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0214)]
  public record Message0214
  {
    public uint realmId { get; set; }
    public uint worldId { get; set; }
    public uint count { get; set; }
    public Structure0AD[]? neighborhoods { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0214>()
        .Integer(x => x.realmId, 32)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.neighborhoods, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0215)]
  public record Message0215
  {
    public uint count { get; set; }
    public Structure0AC[]? residences { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0215>()
        .Integer(x => x.count, 32)
        .Array(x => x.residences, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0217)]
  public record Message0217
  {
    public ulong residenceId { get; set; }
    public Structure0AE? plotList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0217>()
        .Integer(x => x.residenceId, 64)
        .Structure(x => x.plotList);
    }
  }

  [Message(6072, 0x021B)]
  public record Message021B
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
      builder.FieldsOf<Message021B>()
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

  [Message(6072, 0x021C)]
  public record Message021C
  {
    public uint housingNeighborhoodType { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message021C>()
        .Integer(x => x.housingNeighborhoodType, 2)
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x021D)]
  public record Message021D
  {
    public uint housingNeighborhoodType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message021D>()
        .Integer(x => x.housingNeighborhoodType, 2);
    }
  }

  [Message(6072, 0x021F)]
  public record Message021F
  {
    public Structure0AD? neighborhood { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message021F>()
        .Structure(x => x.neighborhood);
    }
  }

  [Message(6072, 0x0220)]
  public record Message0220
  {
    public ulong neighborhood { get; set; }
    public ulong residenceId { get; set; }
    public uint cost { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0220>()
        .Integer(x => x.neighborhood, 64)
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.cost, 32);
    }
  }

  [Message(6072, 0x0221)]
  public record Message0221
  {
    public uint count { get; set; }
    public uint operation { get; set; }
    public Structure0BA[]? decor { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0221>()
        .Integer(x => x.count, 32)
        .Integer(x => x.operation, 3)
        .Array(x => x.decor, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0222)]
  public record Message0222
  {
    public uint count { get; set; }
    public Structure0B0[]? plugItems { get; set; }
    public uint listType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0222>()
        .Integer(x => x.count, 32)
        .Array(x => x.plugItems, x => x.count).OfStructure()
        .Integer(x => x.listType, 3);
    }
  }

  [Message(6072, 0x0223)]
  public record Message0223
  {
    public ulong residenceId { get; set; }
    public uint wallpaperId { get; set; }
    public uint roofDecorInfoId { get; set; }
    public uint entrywayDecorInfoId { get; set; }
    public uint doorDecorInfoId { get; set; }
    public uint operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0223>()
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.wallpaperId, 32)
        .Integer(x => x.roofDecorInfoId, 32)
        .Integer(x => x.entrywayDecorInfoId, 32)
        .Integer(x => x.doorDecorInfoId, 32)
        .Integer(x => x.operation, 3);
    }
  }

  [Message(6072, 0x0224)]
  public record Message0224
  {
    public uint crateEntryId { get; set; }
    public uint plotInfoId { get; set; }
    public uint plugItemId { get; set; }
    public uint operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0224>()
        .Integer(x => x.crateEntryId, 32)
        .Integer(x => x.plotInfoId, 32)
        .Integer(x => x.plugItemId, 32)
        .Integer(x => x.operation, 3);
    }
  }

  [Message(6072, 0x0225)]
  public record Message0225
  {
    public uint operation { get; set; }
    public Structure0AA? decor { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0225>()
        .Integer(x => x.operation, 3)
        .Structure(x => x.decor);
    }
  }

  [Message(6072, 0x0226)]
  public record Message0226
  {
    public Structure0AB[]? wallpapers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0226>()
        .Array(x => x.wallpapers, 4).OfStructure();
    }
  }

  [Message(6072, 0x0227)]
  public record Message0227
  {
    public ulong neighborhood { get; set; }
    public ulong residenceId { get; set; }
    public string? name { get; set; }
    public uint operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0227>()
        .Integer(x => x.neighborhood, 64)
        .Integer(x => x.residenceId, 64)
        .String(x => x.name, true)
        .Integer(x => x.operation, 3);
    }
  }

  [Message(6072, 0x0228)]
  public record Message0228
  {
    public uint plotInfo { get; set; }
    public ulong residenceId { get; set; }
    public uint plugItem { get; set; }
    public uint plotFlags { get; set; }
    public uint operation { get; set; }
    public Structure0A9[]? housingContributions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0228>()
        .Integer(x => x.plotInfo, 32)
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.plugItem, 32)
        .Integer(x => x.plotFlags, 32)
        .Integer(x => x.operation, 3)
        .Array(x => x.housingContributions, 5).OfStructure();
    }
  }

  [Message(6072, 0x0229)]
  public record Message0229
  {
    public uint realmId { get; set; }
    public uint worldId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0229>()
        .Integer(x => x.realmId, 32)
        .Integer(x => x.worldId, 32);
    }
  }

  [Message(6072, 0x022A)]
  public record Message022A
  {
    public ulong neighborhoodId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message022A>()
        .Integer(x => x.neighborhoodId, 64);
    }
  }

  [Message(6072, 0x022B)]
  public record Message022B
  {
    public ulong residenceId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message022B>()
        .Integer(x => x.residenceId, 64);
    }
  }

  [Message(6072, 0x022C)]
  public record Message022C
  {
    public uint instance { get; set; }
    public uint propInfo { get; set; }
    public ulong neighborhood { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message022C>()
        .Integer(x => x.instance, 32)
        .Integer(x => x.propInfo, 32)
        .Integer(x => x.neighborhood, 64);
    }
  }

  [Message(6072, 0x022E)]
  public record Message022E
  {
    public ulong residenceId { get; set; }
    public uint plotIndex { get; set; }
    public uint buildStage { get; set; }
    public uint buildState { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message022E>()
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.plotIndex, 32)
        .Integer(x => x.buildStage, 32)
        .Integer(x => x.buildState, 3);
    }
  }

  [Message(6072, 0x0232)]
  public record Message0232
  {
    public uint type { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0232>()
        .Integer(x => x.type, 3)
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x0233)]
  public record Message0233
  {
    public uint type { get; set; }
    public uint result { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0233>()
        .Integer(x => x.type, 3)
        .Integer(x => x.result, 3)
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x0234)]
  public record Message0234
  {
    public uint type { get; set; }
    public ulong iccomId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0234>()
        .Integer(x => x.type, 3)
        .Integer(x => x.iccomId, 64)
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x0235)]
  public record Message0235
  {
    public ulong iccomId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0235>()
        .Integer(x => x.iccomId, 64);
    }
  }

  [Message(6072, 0x0236)]
  public record Message0236
  {
    public ulong iccomId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0236>()
        .Integer(x => x.iccomId, 64);
    }
  }

  [Message(6072, 0x0237)]
  public record Message0237
  {
    public ulong iccomId { get; set; }
    public uint messageId { get; set; }
    public uint messageNextId { get; set; }
    public string? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0237>()
        .Integer(x => x.iccomId, 64)
        .Integer(x => x.messageId, 32)
        .Integer(x => x.messageNextId, 32)
        .String(x => x.message, true);
    }
  }

  [Message(6072, 0x0238)]
  public record Message0238
  {
    public ulong iccomId { get; set; }
    public uint messageId { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0238>()
        .Integer(x => x.iccomId, 64)
        .Integer(x => x.messageId, 32)
        .Integer(x => x.result, 3);
    }
  }

  [Message(6072, 0x0239)]
  public record Message0239
  {
    public ulong iccomId { get; set; }
    public string? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0239>()
        .Integer(x => x.iccomId, 64)
        .String(x => x.message, true);
    }
  }

  [Message(6072, 0x023A)]
  public record Message023A
  {
    public uint msgId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message023A>()
        .Integer(x => x.msgId, 32);
    }
  }

  [Message(6072, 0x023B)]
  public record Message023B
  {
    public uint count { get; set; }
    public Structure05E[]? cooldownPersistenceData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message023B>()
        .Integer(x => x.count, 32)
        .Array(x => x.cooldownPersistenceData, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x023C)]
  public record Message023C
  {
    public uint count { get; set; }
    public Structure05D[]? spellList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message023C>()
        .Integer(x => x.count, 32)
        .Array(x => x.spellList, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x0243)]
  public record Message0243
  {
    public ulong uniqueId { get; set; }
    public uint dynamicFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0243>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.dynamicFlags, 32);
    }
  }

  [Message(6072, 0x0244)]
  public record Message0244
  {
    public Structure0B8[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0244>()
        .Array(x => x.items, 2).OfStructure();
    }
  }

  [Message(6072, 0x0245)]
  public record Message0245
  {
    public ulong uniqueId { get; set; }
    public ulong locationData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0245>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.locationData, 64);
    }
  }

  [Message(6072, 0x0246)]
  public record Message0246
  {
    public ulong uniqueId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0246>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6072, 0x0247)]
  public record Message0247
  {
    public ulong itemId { get; set; }
    public uint numMicrochips { get; set; }
    public uint[]? microchips { get; set; }
    public ulong thresholdData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0247>()
        .Integer(x => x.itemId, 64)
        .Integer(x => x.numMicrochips, 32)
        .Array(x => x.microchips, x => x.numMicrochips).OfInteger(32)
        .Integer(x => x.thresholdData, 64);
    }
  }

  [Message(6072, 0x0248)]
  public record Message0248
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0248>();
    }
  }

  [Message(6072, 0x0249)]
  public record Message0249
  {
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0249>()
        .Integer(x => x.characterId, 64);
    }
  }

  [Message(6072, 0x024A)]
  public record Message024A
  {
    public uint inputKeySetEnum { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message024A>()
        .Integer(x => x.inputKeySetEnum, 32);
    }
  }

  [Message(6072, 0x024B)]
  public record Message024B
  {
    public uint count { get; set; }
    public Structure034[]? bindings { get; set; }
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message024B>()
        .Integer(x => x.count, 32)
        .Array(x => x.bindings, x => x.count).OfStructure()
        .Integer(x => x.characterId, 64);
    }
  }

  [Message(6072, 0x024F)]
  public record Message024F
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message024F>();
    }
  }

  [Message(6072, 0x0259)]
  public record Message0259
  {
    public string? accountName { get; set; }
    public uint buildNumber { get; set; }
    public uint loginClientType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0259>()
        .String(x => x.accountName, true)
        .Integer(x => x.buildNumber, 32)
        .Integer(x => x.loginClientType, 32);
    }
  }

  [Message(6072, 0x025A)]
  public record Message025A
  {
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message025A>()
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6072, 0x025B)]
  public record Message025B
  {
    public uint accountId { get; set; }
    public byte[]? sessionGUID { get; set; }
    public string? accountName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message025B>()
        .Integer(x => x.accountId, 32)
        .Array(x => x.sessionGUID, 16).Aligned(true).OfInteger(8)
        .String(x => x.accountName, true);
    }
  }

  [Message(6072, 0x025C)]
  public record Message025C
  {
    public Structure013? passwordDigest { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message025C>()
        .Structure(x => x.passwordDigest);
    }
  }

  [Message(6072, 0x025D)]
  public record Message025D
  {
    public ulong salt { get; set; }
    public ulong random { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message025D>()
        .Integer(x => x.salt, 64)
        .Integer(x => x.random, 64);
    }
  }

  [Message(6072, 0x025F)]
  public record Message025F
  {
    public byte dummyThatNeedsToGoAway { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message025F>()
        .Integer(x => x.dummyThatNeedsToGoAway, 8);
    }
  }

  [Message(6072, 0x0260)]
  public record Message0260
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0260>();
    }
  }

  [Message(6072, 0x0261)]
  public record Message0261
  {
    public string? reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0261>()
        .String(x => x.reason, true);
    }
  }

  [Message(6072, 0x0263)]
  public record Message0263
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0263>();
    }
  }

  [Message(6072, 0x0264)]
  public record Message0264
  {
    public uint requested { get; set; }
    public string? reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0264>()
        .Integer(x => x.requested, 1)
        .String(x => x.reason, true);
    }
  }

  [Message(6072, 0x0268)]
  public record Message0268
  {
    public Structure024? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0268>()
        .Structure(x => x.identity);
    }
  }

  [Message(6072, 0x026A)]
  public record Message026A
  {
    public uint ackType { get; set; }
    public ulong uniqueId { get; set; }
    public uint error { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message026A>()
        .Integer(x => x.ackType, 32)
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.error, 7);
    }
  }

  [Message(6072, 0x026B)]
  public record Message026B
  {
    public uint newMail { get; set; }
    public uint mailCount { get; set; }
    public Structure0C0[]? mailData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message026B>()
        .Integer(x => x.newMail, 1)
        .Integer(x => x.mailCount, 32)
        .Array(x => x.mailData, x => x.mailCount).OfStructure();
    }
  }

  [Message(6072, 0x026E)]
  public record Message026E
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message026E>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6072, 0x026F)]
  public record Message026F
  {
    public ulong uniqueId { get; set; }
    public uint error { get; set; }
    public uint index { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message026F>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.error, 7)
        .Integer(x => x.index, 32);
    }
  }

  [Message(6072, 0x0272)]
  public record Message0272
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0272>();
    }
  }

  [Message(6072, 0x0273)]
  public record Message0273
  {
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0273>()
        .Integer(x => x.role, 32);
    }
  }

  [Message(6072, 0x0274)]
  public record Message0274
  {
    public Structure0BC? maps { get; set; }
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0274>()
        .Structure(x => x.maps)
        .Integer(x => x.role, 32);
    }
  }

  [Message(6072, 0x0275)]
  public record Message0275
  {
    public Structure0BC? maps { get; set; }
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0275>()
        .Structure(x => x.maps)
        .Integer(x => x.role, 32);
    }
  }

  [Message(6072, 0x0279)]
  public record Message0279
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0279>();
    }
  }

  [Message(6072, 0x027A)]
  public record Message027A
  {
    public uint matchingGameMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message027A>()
        .Integer(x => x.matchingGameMapId, 32);
    }
  }

  [Message(6072, 0x027B)]
  public record Message027B
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message027B>();
    }
  }

  [Message(6072, 0x027F)]
  public record Message027F
  {
    public uint gameHandle { get; set; }
    public uint response { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message027F>()
        .Integer(x => x.gameHandle, 32)
        .Integer(x => x.response, 1);
    }
  }

  [Message(6072, 0x0280)]
  public record Message0280
  {
    public uint gameHandle { get; set; }
    public uint data { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0280>()
        .Integer(x => x.gameHandle, 32)
        .Integer(x => x.data, 32);
    }
  }

  [Message(6072, 0x0282)]
  public record Message0282
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0282>();
    }
  }

  [Message(6072, 0x0283)]
  public record Message0283
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0283>();
    }
  }

  [Message(6072, 0x0284)]
  public record Message0284
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0284>();
    }
  }

  [Message(6072, 0x0285)]
  public record Message0285
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0285>();
    }
  }

  [Message(6072, 0x0288)]
  public record Message0288
  {
    public uint[]? livesRemaining { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0288>()
        .Array(x => x.livesRemaining, 2).OfInteger(32);
    }
  }

  [Message(6072, 0x0289)]
  public record Message0289
  {
    public uint team { get; set; }
    public Structure0BD? stateInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0289>()
        .Integer(x => x.team, 32)
        .Structure(x => x.stateInfo);
    }
  }

  [Message(6072, 0x028A)]
  public record Message028A
  {
    public uint winner { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message028A>()
        .Integer(x => x.winner, 32)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6072, 0x028B)]
  public record Message028B
  {
    public uint state { get; set; }
    public uint elapsed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message028B>()
        .Integer(x => x.state, 32)
        .Integer(x => x.elapsed, 32);
    }
  }

  [Message(6072, 0x028C)]
  public record Message028C
  {
    public string[]? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message028C>()
        .Array(x => x.name, 2).OfString(true);
    }
  }

  [Message(6072, 0x0291)]
  public record Message0291
  {
    public Structure0BC? maps { get; set; }
    public uint waitTime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0291>()
        .Structure(x => x.maps)
        .Integer(x => x.waitTime, 32);
    }
  }

  [Message(6072, 0x0292)]
  public record Message0292
  {
    public Structure0BC? maps { get; set; }
    public uint waitTime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0292>()
        .Structure(x => x.maps)
        .Integer(x => x.waitTime, 32);
    }
  }

  [Message(6072, 0x0293)]
  public record Message0293
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0293>();
    }
  }

  [Message(6072, 0x0297)]
  public record Message0297
  {
    public Structure0BC? maps { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0297>()
        .Structure(x => x.maps);
    }
  }

  [Message(6072, 0x0298)]
  public record Message0298
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0298>();
    }
  }

  [Message(6072, 0x0299)]
  public record Message0299
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0299>();
    }
  }

  [Message(6072, 0x029A)]
  public record Message029A
  {
    public Structure024? identity { get; set; }
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message029A>()
        .Structure(x => x.identity)
        .Integer(x => x.role, 32);
    }
  }

  [Message(6072, 0x02A3)]
  public record Message02A3
  {
    public uint realmId { get; set; }
    public uint matchingGameMapId { get; set; }
    public uint playerCount { get; set; }
    public Structure0BE[]? players { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A3>()
        .Integer(x => x.realmId, 32)
        .Integer(x => x.matchingGameMapId, 32)
        .Integer(x => x.playerCount, 32)
        .Array(x => x.players, x => x.playerCount).OfStructure();
    }
  }

  [Message(6072, 0x02A5)]
  public record Message02A5
  {
    public uint waitTime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A5>()
        .Integer(x => x.waitTime, 32);
    }
  }

  [Message(6072, 0x02A6)]
  public record Message02A6
  {
    public uint count { get; set; }
    public Structure0BF[]? list { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A6>()
        .Integer(x => x.count, 32)
        .Array(x => x.list, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x02A7)]
  public record Message02A7
  {
    public uint msgId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A7>()
        .Integer(x => x.msgId, 32);
    }
  }

  [Message(6072, 0x02A8)]
  public record Message02A8
  {
    public uint mode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A8>()
        .Integer(x => x.mode, 32);
    }
  }

  [Message(6072, 0x02A9)]
  public record Message02A9
  {
    public uint ticket { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A9>()
        .Integer(x => x.ticket, 32);
    }
  }

  [Message(6072, 0x02AA)]
  public record Message02AA
  {
    public uint ticket { get; set; }
    public uint immediate { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AA>()
        .Integer(x => x.ticket, 32)
        .Integer(x => x.immediate, 1)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x02AB)]
  public record Message02AB
  {
    public uint time { get; set; }
    public uint commandCount { get; set; }
    public Structure082[]? commands { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AB>()
        .Integer(x => x.time, 32)
        .Integer(x => x.commandCount, 32)
        .Array(x => x.commands, x => x.commandCount).OfStructure();
    }
  }

  [Message(6072, 0x02AC)]
  public record Message02AC
  {
    public uint unitId { get; set; }
    public uint time { get; set; }
    public uint timeReset { get; set; }
    public uint serverControlled { get; set; }
    public uint commandCount { get; set; }
    public Structure082[]? commands { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AC>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.time, 32)
        .Integer(x => x.timeReset, 1)
        .Integer(x => x.serverControlled, 1)
        .Integer(x => x.commandCount, 32)
        .Array(x => x.commands, x => x.commandCount).OfStructure();
    }
  }

  [Message(6072, 0x02AD)]
  public record Message02AD
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AD>();
    }
  }

  [Message(6072, 0x02AE)]
  public record Message02AE
  {
    public uint oldZoneId { get; set; }
    public uint newZoneId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AE>()
        .Integer(x => x.oldZoneId, 32)
        .Integer(x => x.newZoneId, 32);
    }
  }

  [Message(6072, 0x02AF)]
  public record Message02AF
  {
    public Structure024? identity { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AF>()
        .Structure(x => x.identity)
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x02B0)]
  public record Message02B0
  {
    public uint achievementArticleCount { get; set; }
    public Structure0A8[]? achievementArticles { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B0>()
        .Integer(x => x.achievementArticleCount, 32)
        .Array(x => x.achievementArticles, x => x.achievementArticleCount).OfStructure();
    }
  }

  [Message(6072, 0x02B1)]
  public record Message02B1
  {
    public uint questArticleCount { get; set; }
    public Structure0A6[]? questArticles { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B1>()
        .Integer(x => x.questArticleCount, 32)
        .Array(x => x.questArticles, x => x.questArticleCount).OfStructure();
    }
  }

  [Message(6072, 0x02B2)]
  public record Message02B2
  {
    public uint queryType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B2>()
        .Integer(x => x.queryType, 2);
    }
  }

  [Message(6072, 0x02B3)]
  public record Message02B3
  {
    public Structure0A5? common { get; set; }
    public uint achievementId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B3>()
        .Structure(x => x.common)
        .Integer(x => x.achievementId, 32);
    }
  }

  [Message(6072, 0x02B4)]
  public record Message02B4
  {
    public Structure0A5? common { get; set; }
    public uint questId { get; set; }
    public uint rewardTypeId { get; set; }
    public uint rewardObjectId { get; set; }
    public uint rewardObjectAmount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B4>()
        .Structure(x => x.common)
        .Integer(x => x.questId, 32)
        .Integer(x => x.rewardTypeId, 32)
        .Integer(x => x.rewardObjectId, 32)
        .Integer(x => x.rewardObjectAmount, 32);
    }
  }

  [Message(6072, 0x02B5)]
  public record Message02B5
  {
    public string? _0073006d { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B5>()
        .String(x => x._0073006d, true);
    }
  }

  [Message(6072, 0x02B6)]
  public record Message02B6
  {
    public uint oob { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B6>()
        .Integer(x => x.oob, 1);
    }
  }

  [Message(6072, 0x02B7)]
  public record Message02B7
  {
    public uint prereqId { get; set; }
    public uint prereqType { get; set; }
    public uint prefixId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B7>()
        .Integer(x => x.prereqId, 32)
        .Integer(x => x.prereqType, 8)
        .Integer(x => x.prefixId, 32);
    }
  }

  [Message(6072, 0x02CA)]
  public record Message02CA
  {
    public uint unitId { get; set; }
    public uint[]? patterns { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02CA>()
        .Integer(x => x.unitId, 32)
        .Array(x => x.patterns, 4).OfInteger(32);
    }
  }

  [Message(6072, 0x02CC)]
  public record Message02CC
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02CC>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x02CD)]
  public record Message02CD
  {
    public uint scannerBotId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02CD>()
        .Integer(x => x.scannerBotId, 32);
    }
  }

  [Message(6072, 0x02CE)]
  public record Message02CE
  {
    public uint scannerBotCooldown { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02CE>()
        .Integer(x => x.scannerBotCooldown, 32);
    }
  }

  [Message(6072, 0x02CF)]
  public record Message02CF
  {
    public uint unitId { get; set; }
    public uint[]? patterns { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02CF>()
        .Integer(x => x.unitId, 32)
        .Array(x => x.patterns, 4).OfInteger(32);
    }
  }

  [Message(6072, 0x02D1)]
  public record Message02D1
  {
    public uint result { get; set; }
    public uint improvementId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D1>()
        .Integer(x => x.result, 32)
        .Integer(x => x.improvementId, 32);
    }
  }

  [Message(6072, 0x02D2)]
  public record Message02D2
  {
    public uint unitId { get; set; }
    public uint groupCount { get; set; }
    public Structure002[]? groups { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D2>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.groupCount, 32)
        .Array(x => x.groups, x => x.groupCount).OfStructure();
    }
  }

  [Message(6072, 0x02D3)]
  public record Message02D3
  {
    public uint hubId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D3>()
        .Integer(x => x.hubId, 32);
    }
  }

  [Message(6072, 0x02D4)]
  public record Message02D4
  {
    public uint unitId { get; set; }
    public uint groupId { get; set; }
    public uint tier { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D4>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.groupId, 32)
        .Integer(x => x.tier, 32);
    }
  }

  [Message(6072, 0x02D5)]
  public record Message02D5
  {
    public uint improvementGroupId { get; set; }
    public string? unitName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D5>()
        .Integer(x => x.improvementGroupId, 32)
        .String(x => x.unitName, true);
    }
  }

  [Message(6072, 0x02D6)]
  public record Message02D6
  {
    public uint infrastructureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D6>()
        .Integer(x => x.infrastructureId, 32);
    }
  }

  [Message(6072, 0x02D7)]
  public record Message02D7
  {
    public uint infrastructureId { get; set; }
    public uint state { get; set; }
    public float percent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D7>()
        .Integer(x => x.infrastructureId, 32)
        .Integer(x => x.state, 2)
        .Float(x => x.percent);
    }
  }

  [Message(6072, 0x02D8)]
  public record Message02D8
  {
    public uint infrastructureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D8>()
        .Integer(x => x.infrastructureId, 32);
    }
  }

  [Message(6072, 0x02D9)]
  public record Message02D9
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D9>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x02DA)]
  public record Message02DA
  {
    public uint unitId { get; set; }
    public uint @event { get; set; }
    public uint count { get; set; }
    public uint[]? built { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DA>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.@event, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.built, x => x.count).OfInteger(32);
    }
  }

  [Message(6072, 0x02DB)]
  public record Message02DB
  {
    public uint missionId { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DB>()
        .Integer(x => x.missionId, 32)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x02DC)]
  public record Message02DC
  {
    public uint @event { get; set; }
    public Structure001? unit { get; set; }
    public float maxTypeHealth { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DC>()
        .Integer(x => x.@event, 32)
        .Structure(x => x.unit)
        .Float(x => x.maxTypeHealth);
    }
  }

  [Message(6072, 0x02DD)]
  public record Message02DD
  {
    public uint @event { get; set; }
    public uint waveIndex { get; set; }
    public uint boss { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DD>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.waveIndex, 32)
        .Integer(x => x.boss, 1);
    }
  }

  [Message(6072, 0x02DE)]
  public record Message02DE
  {
    public uint @event { get; set; }
    public Structure001? unit { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DE>()
        .Integer(x => x.@event, 32)
        .Structure(x => x.unit);
    }
  }

  [Message(6072, 0x02DF)]
  public record Message02DF
  {
    public uint @event { get; set; }
    public uint interestCount { get; set; }
    public Structure001[]? interestUnits { get; set; }
    public uint flag { get; set; }
    public uint boss { get; set; }
    public uint runMode { get; set; }
    public uint elapsedTime { get; set; }
    public uint waveIndex { get; set; }
    public float maxDefendHealth { get; set; }
    public float maxAuxiliaryHealth { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DF>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.interestCount, 32)
        .Array(x => x.interestUnits, x => x.interestCount).OfStructure()
        .Integer(x => x.flag, 32)
        .Integer(x => x.boss, 1)
        .Integer(x => x.runMode, 32)
        .Integer(x => x.elapsedTime, 32)
        .Integer(x => x.waveIndex, 32)
        .Float(x => x.maxDefendHealth)
        .Float(x => x.maxAuxiliaryHealth);
    }
  }

  [Message(6072, 0x02E0)]
  public record Message02E0
  {
    public uint @event { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02E0>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6072, 0x02E1)]
  public record Message02E1
  {
    public uint unitId { get; set; }
    public uint towerId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02E1>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.towerId, 32);
    }
  }

  [Message(6072, 0x02E2)]
  public record Message02E2
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02E2>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x02E3)]
  public record Message02E3
  {
    public uint @event { get; set; }
    public uint credits { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02E3>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.credits, 32);
    }
  }

  [Message(6072, 0x02E4)]
  public record Message02E4
  {
    public uint @event { get; set; }
    public uint built { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02E4>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.built, 32);
    }
  }

  [Message(6072, 0x02EA)]
  public record Message02EA
  {
    public uint currPetPoints { get; set; }
    public uint maxPetPoints { get; set; }
    public uint count { get; set; }
    public Structure037[]? pets { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02EA>()
        .Integer(x => x.currPetPoints, 32)
        .Integer(x => x.maxPetPoints, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.pets, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x02EB)]
  public record Message02EB
  {
    public uint petId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02EB>()
        .Integer(x => x.petId, 32);
    }
  }

  [Message(6072, 0x02EC)]
  public record Message02EC
  {
    public ulong[]? teamSlot { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02EC>()
        .Array(x => x.teamSlot, 5).OfInteger(64);
    }
  }

  [Message(6072, 0x02ED)]
  public record Message02ED
  {
    public uint petIdx { get; set; }
    public uint petCmd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02ED>()
        .Integer(x => x.petIdx, 32)
        .Integer(x => x.petCmd, 32);
    }
  }

  [Message(6072, 0x02F9)]
  public record Message02F9
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02F9>();
    }
  }

  [Message(6072, 0x02FA)]
  public record Message02FA
  {
    public uint pathEpsiodeId { get; set; }
    public uint missionCount { get; set; }
    public Structure033[]? missions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FA>()
        .Integer(x => x.pathEpsiodeId, 32)
        .Integer(x => x.missionCount, 32)
        .Array(x => x.missions, x => x.missionCount).OfStructure();
    }
  }

  [Message(6072, 0x02FB)]
  public record Message02FB
  {
    public uint clueId { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FB>()
        .Integer(x => x.clueId, 32)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x02FC)]
  public record Message02FC
  {
    public uint clueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FC>()
        .Integer(x => x.clueId, 32);
    }
  }

  [Message(6072, 0x02FD)]
  public record Message02FD
  {
    public uint locationId { get; set; }
    public uint clueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FD>()
        .Integer(x => x.locationId, 32)
        .Integer(x => x.clueId, 32);
    }
  }

  [Message(6072, 0x02FE)]
  public record Message02FE
  {
    public uint clueId { get; set; }
    public uint unitCount { get; set; }
    public uint[]? unitIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FE>()
        .Integer(x => x.clueId, 32)
        .Integer(x => x.unitCount, 32)
        .Array(x => x.unitIds, x => x.unitCount).OfInteger(32);
    }
  }

  [Message(6072, 0x02FF)]
  public record Message02FF
  {
    public uint missionCount { get; set; }
    public Structure032[]? missions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FF>()
        .Integer(x => x.missionCount, 32)
        .Array(x => x.missions, x => x.missionCount).OfStructure();
    }
  }

  [Message(6072, 0x0300)]
  public record Message0300
  {
    public uint missionId { get; set; }
    public uint completed { get; set; }
    public uint userdata { get; set; }
    public uint statedata { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0300>()
        .Integer(x => x.missionId, 32)
        .Integer(x => x.completed, 1)
        .Integer(x => x.userdata, 32)
        .Integer(x => x.statedata, 32);
    }
  }

  [Message(6072, 0x0301)]
  public record Message0301
  {
    public uint pathType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0301>()
        .Integer(x => x.pathType, 32);
    }
  }

  [Message(6072, 0x0302)]
  public record Message0302
  {
    public uint zoneId { get; set; }
    public uint pathEpsiodeId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0302>()
        .Integer(x => x.zoneId, 32)
        .Integer(x => x.pathEpsiodeId, 32);
    }
  }

  [Message(6072, 0x0305)]
  public record Message0305
  {
    public ushort type { get; set; }
    public ushort subType { get; set; }
    public float posx { get; set; }
    public float posy { get; set; }
    public float posz { get; set; }
    public string? text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0305>()
        .Integer(x => x.type, 16)
        .Integer(x => x.subType, 16)
        .Float(x => x.posx)
        .Float(x => x.posy)
        .Float(x => x.posz)
        .String(x => x.text, true);
    }
  }

  [Message(6072, 0x030C)]
  public record Message030C
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint teamId { get; set; }
    public uint choice { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message030C>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.teamId, 32)
        .Integer(x => x.choice, 32);
    }
  }

  [Message(6072, 0x030E)]
  public record Message030E
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint teamId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message030E>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.teamId, 32);
    }
  }

  [Message(6072, 0x0311)]
  public record Message0311
  {
    public uint objectiveId { get; set; }
    public uint busy { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0311>()
        .Integer(x => x.objectiveId, 32)
        .Integer(x => x.busy, 1);
    }
  }

  [Message(6072, 0x0312)]
  public record Message0312
  {
    public uint choice { get; set; }
    public uint count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0312>()
        .Integer(x => x.choice, 32)
        .Integer(x => x.count, 32);
    }
  }

  [Message(6072, 0x0313)]
  public record Message0313
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint winner { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0313>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.winner, 32);
    }
  }

  [Message(6072, 0x0314)]
  public record Message0314
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint teamId { get; set; }
    public uint tallyCount { get; set; }
    public Structure010[]? tally { get; set; }
    public uint canPlayerVote { get; set; }
    public uint elapsedTimeMs { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0314>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.teamId, 32)
        .Integer(x => x.tallyCount, 32)
        .Array(x => x.tally, x => x.tallyCount).OfStructure()
        .Integer(x => x.canPlayerVote, 1)
        .Integer(x => x.elapsedTimeMs, 32);
    }
  }

  [Message(6072, 0x0315)]
  public record Message0315
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint choice { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0315>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.choice, 32);
    }
  }

  [Message(6072, 0x0321)]
  public record Message0321
  {
    public float px { get; set; }
    public float py { get; set; }
    public float pz { get; set; }
    public float vx { get; set; }
    public float vy { get; set; }
    public float vz { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0321>()
        .Float(x => x.px)
        .Float(x => x.py)
        .Float(x => x.pz)
        .Float(x => x.vx)
        .Float(x => x.vy)
        .Float(x => x.vz);
    }
  }

  [Message(6072, 0x0322)]
  public record Message0322
  {
    public uint spline { get; set; }
    public uint splineMode { get; set; }
    public float speed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0322>()
        .Integer(x => x.spline, 32)
        .Integer(x => x.splineMode, 32)
        .Float(x => x.speed);
    }
  }

  [Message(6072, 0x0323)]
  public record Message0323
  {
    public uint unit { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0323>()
        .Integer(x => x.unit, 32);
    }
  }

  [Message(6072, 0x0324)]
  public record Message0324
  {
    public byte m_notification { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0324>()
        .Integer(x => x.m_notification, 8);
    }
  }

  [Message(6072, 0x0325)]
  public record Message0325
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0325>();
    }
  }

  [Message(6072, 0x0327)]
  public record Message0327
  {
    public uint m_textId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0327>()
        .Integer(x => x.m_textId, 32);
    }
  }

  [Message(6072, 0x0328)]
  public record Message0328
  {
    public string? m_text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0328>()
        .String(x => x.m_text, true);
    }
  }

  [Message(6072, 0x033A)]
  public record Message033A
  {
    public Structure01C? m_text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message033A>()
        .Structure(x => x.m_text);
    }
  }

  [Message(6072, 0x033B)]
  public record Message033B
  {
    public Structure01C? m_text { get; set; }
    public uint m_creatureId { get; set; }
    public uint m_duration { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message033B>()
        .Structure(x => x.m_text)
        .Integer(x => x.m_creatureId, 32)
        .Integer(x => x.m_duration, 32);
    }
  }

  [Message(6072, 0x034A)]
  public record Message034A
  {
    public uint m_unitId { get; set; }
    public uint m_sequence { get; set; }
    public float m_start { get; set; }
    public float m_speed { get; set; }
    public uint m_layer { get; set; }
    public ushort m_seed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message034A>()
        .Integer(x => x.m_unitId, 32)
        .Integer(x => x.m_sequence, 32)
        .Float(x => x.m_start)
        .Float(x => x.m_speed)
        .Integer(x => x.m_layer, 32)
        .Integer(x => x.m_seed, 16);
    }
  }

  [Message(6072, 0x0352)]
  public record Message0352
  {
    public Structure01C? m_text { get; set; }
    public uint m_speakerUnitId { get; set; }
    public uint m_isEmote { get; set; }
    public uint m_squelchChatLog { get; set; }
    public float m_radius { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0352>()
        .Structure(x => x.m_text)
        .Integer(x => x.m_speakerUnitId, 32)
        .Integer(x => x.m_isEmote, 1)
        .Integer(x => x.m_squelchChatLog, 1)
        .Float(x => x.m_radius);
    }
  }

  [Message(6072, 0x0353)]
  public record Message0353
  {
    public uint m_unitId { get; set; }
    public uint m_set { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0353>()
        .Integer(x => x.m_unitId, 32)
        .Integer(x => x.m_set, 1);
    }
  }

  [Message(6072, 0x0355)]
  public record Message0355
  {
    public uint m_commId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0355>()
        .Integer(x => x.m_commId, 32);
    }
  }

  [Message(6072, 0x0356)]
  public record Message0356
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0356>();
    }
  }

  [Message(6072, 0x0357)]
  public record Message0357
  {
    public Structure01C? m_text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0357>()
        .Structure(x => x.m_text);
    }
  }

  [Message(6072, 0x0358)]
  public record Message0358
  {
    public Structure01C? m_text { get; set; }
    public uint soundEventId { get; set; }
    public uint windowTypeId { get; set; }
    public uint durationMS { get; set; }
    public uint storyPanelStyleEnum { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0358>()
        .Structure(x => x.m_text)
        .Integer(x => x.soundEventId, 32)
        .Integer(x => x.windowTypeId, 32)
        .Integer(x => x.durationMS, 32)
        .Integer(x => x.storyPanelStyleEnum, 32);
    }
  }

  [Message(6072, 0x0359)]
  public record Message0359
  {
    public uint realmId { get; set; }
    public string? realmName { get; set; }
    public uint flags { get; set; }
    public uint realmStatus { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0359>()
        .Integer(x => x.realmId, 32)
        .String(x => x.realmName, true)
        .Integer(x => x.flags, 32)
        .Integer(x => x.realmStatus, 3);
    }
  }

  [Message(6072, 0x035A)]
  public record Message035A
  {
    public uint realmCount { get; set; }
    public Structure011[]? realmInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message035A>()
        .Integer(x => x.realmCount, 32)
        .Array(x => x.realmInfo, x => x.realmCount).OfStructure();
    }
  }

  [Message(6072, 0x035B)]
  public record Message035B
  {
    public uint serverUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message035B>()
        .Integer(x => x.serverUniqueId, 32);
    }
  }

  [Message(6072, 0x035C)]
  public record Message035C
  {
    public uint visualCount { get; set; }
    public uint[]? serverUniqueIdList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message035C>()
        .Integer(x => x.visualCount, 32)
        .Array(x => x.serverUniqueIdList, x => x.visualCount).OfInteger(32);
    }
  }

  [Message(6072, 0x035D)]
  public record Message035D
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message035D>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x0360)]
  public record Message0360
  {
    public uint serverUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0360>()
        .Integer(x => x.serverUniqueId, 32);
    }
  }

  [Message(6072, 0x0361)]
  public record Message0361
  {
    public uint sourceUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0361>()
        .Integer(x => x.sourceUnitId, 32);
    }
  }

  [Message(6072, 0x0366)]
  public record Message0366
  {
    public uint titleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0366>()
        .Integer(x => x.titleId, 32);
    }
  }

  [Message(6072, 0x036C)]
  public record Message036C
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message036C>();
    }
  }

  [Message(6072, 0x0370)]
  public record Message0370
  {
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0370>()
        .Integer(x => x.characterId, 64);
    }
  }

  [Message(6072, 0x0372)]
  public record Message0372
  {
    public uint realmId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0372>()
        .Integer(x => x.realmId, 32);
    }
  }

  [Message(6072, 0x0373)]
  public record Message0373
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0373>();
    }
  }

  [Message(6072, 0x0378)]
  public record Message0378
  {
    public uint count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0378>()
        .Integer(x => x.count, 32);
    }
  }

  [Message(6072, 0x037D)]
  public record Message037D
  {
    public uint unitId { get; set; }
    public uint explosion { get; set; }
    public uint count { get; set; }
    public Structure0B9[]? loot { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message037D>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.explosion, 1)
        .Integer(x => x.count, 32)
        .Array(x => x.loot, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x037F)]
  public record Message037F
  {
    public uint serverUniqueId { get; set; }
    public uint bIgnoreCooldown { get; set; }
    public Structure015? primaryDestination { get; set; }
    public byte targetCount { get; set; }
    public Structure054[]? targetInfo { get; set; }
    public byte initialPositionCount { get; set; }
    public Structure052[]? initialPositions { get; set; }
    public byte telegraphPositionCount { get; set; }
    public Structure053[]? telegraphPositions { get; set; }
    public byte missileCount { get; set; }
    public Structure058[]? missileInfo { get; set; }
    public uint phase { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message037F>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.bIgnoreCooldown, 1)
        .Structure(x => x.primaryDestination)
        .Integer(x => x.targetCount, 8)
        .Array(x => x.targetInfo, x => x.targetCount).OfStructure()
        .Integer(x => x.initialPositionCount, 8)
        .Array(x => x.initialPositions, x => x.initialPositionCount).OfStructure()
        .Integer(x => x.telegraphPositionCount, 8)
        .Array(x => x.telegraphPositions, x => x.telegraphPositionCount).OfStructure()
        .Integer(x => x.missileCount, 8)
        .Array(x => x.missileInfo, x => x.missileCount).OfStructure()
        .Integer(x => x.phase, 32);
    }
  }

  [Message(6072, 0x0380)]
  public record Message0380
  {
    public uint serverUniqueId { get; set; }
    public uint effectId { get; set; }
    public uint targetId { get; set; }
    public byte damageCount { get; set; }
    public Structure057[]? damageInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0380>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.effectId, 32)
        .Integer(x => x.targetId, 32)
        .Integer(x => x.damageCount, 8)
        .Array(x => x.damageInfo, x => x.damageCount).OfStructure();
    }
  }

  [Message(6072, 0x0381)]
  public record Message0381
  {
    public uint serverUniqueId { get; set; }
    public uint result { get; set; }
    public uint unitThatCausedId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0381>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.result, 9)
        .Integer(x => x.unitThatCausedId, 32);
    }
  }

  [Message(6072, 0x0382)]
  public record Message0382
  {
    public uint serverUniqueId { get; set; }
    public uint result { get; set; }
    public uint unitThatCausedId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0382>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.result, 9)
        .Integer(x => x.unitThatCausedId, 32);
    }
  }

  [Message(6072, 0x0383)]
  public record Message0383
  {
    public uint serverUniqueId { get; set; }
    public uint missCount { get; set; }
    public Structure059[]? missInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0383>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.missCount, 32)
        .Array(x => x.missInfo, x => x.missCount).OfStructure();
    }
  }

  [Message(6072, 0x0384)]
  public record Message0384
  {
    public uint clientUniqueId { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0384>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.result, 9);
    }
  }

  [Message(6072, 0x0385)]
  public record Message0385
  {
    public uint clientUniqueId { get; set; }
    public uint serverUniqueId { get; set; }
    public uint casterId { get; set; }
    public uint primaryTargetId { get; set; }
    public Structure015? fieldPosition { get; set; }
    public float yaw { get; set; }
    public byte initialPositionCount { get; set; }
    public Structure052[]? initialPositions { get; set; }
    public byte telegraphPositionCount { get; set; }
    public Structure053[]? telegraphPositions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0385>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.casterId, 32)
        .Integer(x => x.primaryTargetId, 32)
        .Structure(x => x.fieldPosition)
        .Float(x => x.yaw)
        .Integer(x => x.initialPositionCount, 8)
        .Array(x => x.initialPositions, x => x.initialPositionCount).OfStructure()
        .Integer(x => x.telegraphPositionCount, 8)
        .Array(x => x.telegraphPositions, x => x.telegraphPositionCount).OfStructure();
    }
  }

  [Message(6072, 0x0386)]
  public record Message0386
  {
    public uint serverUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0386>()
        .Integer(x => x.serverUniqueId, 32);
    }
  }

  [Message(6072, 0x0387)]
  public record Message0387
  {
    public uint drainerUnitId { get; set; }
    public uint draineeUnitId { get; set; }
    public uint drainAmount { get; set; }
    public uint drainType { get; set; }
    public uint fillAmount { get; set; }
    public uint fillType { get; set; }
    public uint spellId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0387>()
        .Integer(x => x.drainerUnitId, 32)
        .Integer(x => x.draineeUnitId, 32)
        .Integer(x => x.drainAmount, 32)
        .Integer(x => x.drainType, 32)
        .Integer(x => x.fillAmount, 32)
        .Integer(x => x.fillType, 32)
        .Integer(x => x.spellId, 32);
    }
  }

  [Message(6072, 0x0388)]
  public record Message0388
  {
    public uint serverUniqueId { get; set; }
    public uint spellId { get; set; }
    public uint rootSpellId { get; set; }
    public uint parentSpellId { get; set; }
    public uint casterId { get; set; }
    public uint primaryTargetId { get; set; }
    public Structure015? fieldPosition { get; set; }
    public float yaw { get; set; }
    public byte initialPositionCount { get; set; }
    public Structure052[]? initialPositions { get; set; }
    public byte telegraphPositionCount { get; set; }
    public Structure053[]? telegraphPositions { get; set; }
    public uint bUserInitiatedSpellCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0388>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.spellId, 32)
        .Integer(x => x.rootSpellId, 32)
        .Integer(x => x.parentSpellId, 32)
        .Integer(x => x.casterId, 32)
        .Integer(x => x.primaryTargetId, 32)
        .Structure(x => x.fieldPosition)
        .Float(x => x.yaw)
        .Integer(x => x.initialPositionCount, 8)
        .Array(x => x.initialPositions, x => x.initialPositionCount).OfStructure()
        .Integer(x => x.telegraphPositionCount, 8)
        .Array(x => x.telegraphPositions, x => x.telegraphPositionCount).OfStructure()
        .Integer(x => x.bUserInitiatedSpellCast, 1);
    }
  }

  [Message(6072, 0x038A)]
  public record Message038A
  {
    public uint clientUniqueId { get; set; }
    public uint bCancelCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message038A>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.bCancelCast, 1);
    }
  }

  [Message(6072, 0x038B)]
  public record Message038B
  {
    public uint serverUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message038B>()
        .Integer(x => x.serverUniqueId, 32);
    }
  }

  [Message(6072, 0x038C)]
  public record Message038C
  {
    public uint serverUniqueId { get; set; }
    public uint castResult { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message038C>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.castResult, 32);
    }
  }

  [Message(6072, 0x038E)]
  public record Message038E
  {
    public uint serverUniqueId { get; set; }
    public uint result { get; set; }
    public uint validation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message038E>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.result, 3)
        .Integer(x => x.validation, 32);
    }
  }

  [Message(6072, 0x0397)]
  public record Message0397
  {
    public uint clientUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0397>()
        .Integer(x => x.clientUniqueId, 32);
    }
  }

  [Message(6072, 0x0398)]
  public record Message0398
  {
    public uint disableCooldowns { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0398>()
        .Integer(x => x.disableCooldowns, 1);
    }
  }

  [Message(6072, 0x0399)]
  public record Message0399
  {
    public uint count { get; set; }
    public Structure05C[]? spellTargets { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0399>()
        .Integer(x => x.count, 32)
        .Array(x => x.spellTargets, x => x.count).OfStructure();
    }
  }

  [Message(6072, 0x039A)]
  public record Message039A
  {
    public uint spellId { get; set; }
    public uint rootSpellId { get; set; }
    public uint serverUID { get; set; }
    public uint newThresholdNdx { get; set; }
    public uint bClear { get; set; }
    public uint bForceCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039A>()
        .Integer(x => x.spellId, 32)
        .Integer(x => x.rootSpellId, 32)
        .Integer(x => x.serverUID, 32)
        .Integer(x => x.newThresholdNdx, 32)
        .Integer(x => x.bClear, 1)
        .Integer(x => x.bForceCast, 1);
    }
  }

  [Message(6072, 0x039B)]
  public record Message039B
  {
    public ushort subType { get; set; }
    public uint unitId { get; set; }
    public uint questId { get; set; }
    public string? text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039B>()
        .Integer(x => x.subType, 16)
        .Integer(x => x.unitId, 32)
        .Integer(x => x.questId, 32)
        .String(x => x.text, true);
    }
  }

  [Message(6072, 0x039C)]
  public record Message039C
  {
    public string? m_comment { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039C>()
        .String(x => x.m_comment, true);
    }
  }

  [Message(6072, 0x039D)]
  public record Message039D
  {
    public string? m_comment { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039D>()
        .String(x => x.m_comment, true);
    }
  }

  [Message(6072, 0x039E)]
  public record Message039E
  {
    public uint timeOfDay { get; set; }
    public uint season { get; set; }
    public uint lengthOfDay { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039E>()
        .Integer(x => x.timeOfDay, 32)
        .Integer(x => x.season, 32)
        .Integer(x => x.lengthOfDay, 32);
    }
  }

  [Message(6072, 0x039F)]
  public record Message039F
  {
    public float timeScale { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039F>()
        .Float(x => x.timeScale);
    }
  }

  [Message(6072, 0x03A1)]
  public record Message03A1
  {
    public uint trackingSlotId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A1>()
        .Integer(x => x.trackingSlotId, 32);
    }
  }

  [Message(6072, 0x03A2)]
  public record Message03A2
  {
    public uint trackingSlotId { get; set; }
    public float posX { get; set; }
    public float posY { get; set; }
    public float posZ { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A2>()
        .Integer(x => x.trackingSlotId, 32)
        .Float(x => x.posX)
        .Float(x => x.posY)
        .Float(x => x.posZ);
    }
  }

  [Message(6072, 0x03A3)]
  public record Message03A3
  {
    public uint craftingStationId { get; set; }
    public uint itemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A3>()
        .Integer(x => x.craftingStationId, 32)
        .Integer(x => x.itemId, 32);
    }
  }

  [Message(6072, 0x03A4)]
  public record Message03A4
  {
    public uint bonusEnum { get; set; }
    public uint objectId { get; set; }
    public uint objectIdAlt { get; set; }
    public float multiplier { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A4>()
        .Integer(x => x.bonusEnum, 32)
        .Integer(x => x.objectId, 32)
        .Integer(x => x.objectIdAlt, 32)
        .Float(x => x.multiplier);
    }
  }

  [Message(6072, 0x03A5)]
  public record Message03A5
  {
    public uint bonusCount { get; set; }
    public Structure0B3[]? bonuses { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A5>()
        .Integer(x => x.bonusCount, 32)
        .Array(x => x.bonuses, x => x.bonusCount).OfStructure();
    }
  }

  [Message(6072, 0x03A6)]
  public record Message03A6
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A6>();
    }
  }

  [Message(6072, 0x03A7)]
  public record Message03A7
  {
    public uint craftingStationId { get; set; }
    public uint schematicId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A7>()
        .Integer(x => x.craftingStationId, 32)
        .Integer(x => x.schematicId, 32);
    }
  }

  [Message(6072, 0x03A8)]
  public record Message03A8
  {
    public uint craftingStationId { get; set; }
    public uint schematicId { get; set; }
    public uint microchipCount { get; set; }
    public uint[]? microchips { get; set; }
    public ulong thresholdData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A8>()
        .Integer(x => x.craftingStationId, 32)
        .Integer(x => x.schematicId, 32)
        .Integer(x => x.microchipCount, 32)
        .Array(x => x.microchips, x => x.microchipCount).OfInteger(32)
        .Integer(x => x.thresholdData, 64);
    }
  }

  [Message(6072, 0x03A9)]
  public record Message03A9
  {
    public uint success { get; set; }
    public uint hotCold { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A9>()
        .Integer(x => x.success, 1)
        .Integer(x => x.hotCold, 32);
    }
  }

  [Message(6072, 0x03AA)]
  public record Message03AA
  {
    public uint schematicId { get; set; }
    public uint numAdditives { get; set; }
    public float vectorX { get; set; }
    public float vectorY { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AA>()
        .Integer(x => x.schematicId, 32)
        .Integer(x => x.numAdditives, 32)
        .Float(x => x.vectorX)
        .Float(x => x.vectorY);
    }
  }

  [Message(6072, 0x03AB)]
  public record Message03AB
  {
    public uint schematicId { get; set; }
    public float x { get; set; }
    public float y { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AB>()
        .Integer(x => x.schematicId, 32)
        .Float(x => x.x)
        .Float(x => x.y);
    }
  }

  [Message(6072, 0x03AC)]
  public record Message03AC
  {
    public uint tradeskillId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AC>()
        .Integer(x => x.tradeskillId, 32);
    }
  }

  [Message(6072, 0x03AD)]
  public record Message03AD
  {
    public uint numTradeskills { get; set; }
    public Structure0B1[]? tradeskillData { get; set; }
    public uint schematicCount { get; set; }
    public uint[]? schematics { get; set; }
    public uint discoveryCount { get; set; }
    public Structure0B2[]? discoveries { get; set; }
    public uint craftedMaskSize { get; set; }
    public uint[]? craftedMask { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AD>()
        .Integer(x => x.numTradeskills, 32)
        .Array(x => x.tradeskillData, x => x.numTradeskills).OfStructure()
        .Integer(x => x.schematicCount, 32)
        .Array(x => x.schematics, x => x.schematicCount).OfInteger(32)
        .Integer(x => x.discoveryCount, 32)
        .Array(x => x.discoveries, x => x.discoveryCount).OfStructure()
        .Integer(x => x.craftedMaskSize, 32)
        .Array(x => x.craftedMask, x => x.craftedMaskSize).OfInteger(32);
    }
  }

  [Message(6072, 0x03AE)]
  public record Message03AE
  {
    public uint tradeskillId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AE>()
        .Integer(x => x.tradeskillId, 32);
    }
  }

  [Message(6072, 0x03AF)]
  public record Message03AF
  {
    public ulong itemId { get; set; }
    public uint microchipCount { get; set; }
    public uint[]? microchips { get; set; }
    public ulong thresholdData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AF>()
        .Integer(x => x.itemId, 64)
        .Integer(x => x.microchipCount, 32)
        .Array(x => x.microchips, x => x.microchipCount).OfInteger(32)
        .Integer(x => x.thresholdData, 64);
    }
  }

  [Message(6072, 0x03B0)]
  public record Message03B0
  {
    public ulong itemId { get; set; }
    public uint socketIndex { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03B0>()
        .Integer(x => x.itemId, 64)
        .Integer(x => x.socketIndex, 32);
    }
  }

  [Message(6072, 0x03B1)]
  public record Message03B1
  {
    public uint tradeskillId { get; set; }
    public uint schematicId { get; set; }
    public float discoveredX { get; set; }
    public float discoveredY { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03B1>()
        .Integer(x => x.tradeskillId, 32)
        .Integer(x => x.schematicId, 32)
        .Float(x => x.discoveredX)
        .Float(x => x.discoveredY);
    }
  }

  [Message(6072, 0x03B2)]
  public record Message03B2
  {
    public uint tradeskillId { get; set; }
    public uint xp { get; set; }
    public uint flags { get; set; }
    public uint proficiencyFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03B2>()
        .Integer(x => x.tradeskillId, 32)
        .Integer(x => x.xp, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.proficiencyFlags, 32);
    }
  }

  [Message(6072, 0x03BC)]
  public record Message03BC
  {
    public uint self { get; set; }
    public Structure063? passenger { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03BC>()
        .Integer(x => x.self, 32)
        .Structure(x => x.passenger);
    }
  }

  [Message(6072, 0x03C3)]
  public record Message03C3
  {
    public uint unitId { get; set; }
    public uint targetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C3>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.targetId, 32);
    }
  }

  [Message(6072, 0x03C4)]
  public record Message03C4
  {
    public uint unitId { get; set; }
    public uint targetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C4>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.targetId, 32);
    }
  }

  [Message(6072, 0x03C6)]
  public record Message03C6
  {
    public uint playerId { get; set; }
    public uint targetId { get; set; }
    public uint state { get; set; }
    public uint result { get; set; }
    public uint extraData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C6>()
        .Integer(x => x.playerId, 32)
        .Integer(x => x.targetId, 32)
        .Integer(x => x.state, 5)
        .Integer(x => x.result, 32)
        .Integer(x => x.extraData, 32);
    }
  }

  [Message(6072, 0x03C7)]
  public record Message03C7
  {
    public uint unitId { get; set; }
    public uint state { get; set; }
    public uint bRemove { get; set; }
    public uint additionalDataId { get; set; }
    public uint spellUniqueId { get; set; }
    public uint spellEffectDuration { get; set; }
    public uint spellEffectId { get; set; }
    public uint visualOverrideId0 { get; set; }
    public uint visualOverrideId1 { get; set; }
    public uint visualOverrideId2 { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C7>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.state, 5)
        .Integer(x => x.bRemove, 1)
        .Integer(x => x.additionalDataId, 32)
        .Integer(x => x.spellUniqueId, 32)
        .Integer(x => x.spellEffectDuration, 32)
        .Integer(x => x.spellEffectId, 32)
        .Integer(x => x.visualOverrideId0, 32)
        .Integer(x => x.visualOverrideId1, 32)
        .Integer(x => x.visualOverrideId2, 32);
    }
  }

  [Message(6072, 0x03CB)]
  public record Message03CB
  {
    public uint self { get; set; }
    public uint flags { get; set; }
    public uint uiFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03CB>()
        .Integer(x => x.self, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.uiFlags, 32);
    }
  }

  [Message(6072, 0x03CC)]
  public record Message03CC
  {
    public uint self { get; set; }
    public uint miniMapMarkerId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03CC>()
        .Integer(x => x.self, 32)
        .Integer(x => x.miniMapMarkerId, 32);
    }
  }

  [Message(6072, 0x03CE)]
  public record Message03CE
  {
    public uint unitId { get; set; }
    public uint dead { get; set; }
    public uint reason { get; set; }
    public uint rezHealth { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03CE>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.dead, 1)
        .Integer(x => x.reason, 32)
        .Integer(x => x.rezHealth, 32);
    }
  }

  [Message(6072, 0x03D0)]
  public record Message03D0
  {
    public uint self { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D0>()
        .Integer(x => x.self, 32);
    }
  }

  [Message(6072, 0x03D1)]
  public record Message03D1
  {
    public uint challengerId { get; set; }
    public uint opponentId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D1>()
        .Integer(x => x.challengerId, 32)
        .Integer(x => x.opponentId, 32);
    }
  }

  [Message(6072, 0x03D2)]
  public record Message03D2
  {
    public uint challengerId { get; set; }
    public uint opponentId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D2>()
        .Integer(x => x.challengerId, 32)
        .Integer(x => x.opponentId, 32);
    }
  }

  [Message(6072, 0x03D3)]
  public record Message03D3
  {
    public uint challengerId { get; set; }
    public uint opponentId { get; set; }
    public uint forfeiterId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D3>()
        .Integer(x => x.challengerId, 32)
        .Integer(x => x.opponentId, 32)
        .Integer(x => x.forfeiterId, 32)
        .Integer(x => x.reason, 2);
    }
  }

  [Message(6072, 0x03D4)]
  public record Message03D4
  {
    public uint challengerId { get; set; }
    public uint opponentId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D4>()
        .Integer(x => x.challengerId, 32)
        .Integer(x => x.opponentId, 32);
    }
  }

  [Message(6072, 0x03D5)]
  public record Message03D5
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D5>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x03D6)]
  public record Message03D6
  {
    public uint unitId { get; set; }
    public uint inCombat { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D6>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.inCombat, 1);
    }
  }

  [Message(6072, 0x03D7)]
  public record Message03D7
  {
    public uint self { get; set; }
    public uint vehicle { get; set; }
    public uint seatType { get; set; }
    public uint seatPosition { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D7>()
        .Integer(x => x.self, 32)
        .Integer(x => x.vehicle, 32)
        .Integer(x => x.seatType, 32)
        .Integer(x => x.seatPosition, 32);
    }
  }

  [Message(6072, 0x03D9)]
  public record Message03D9
  {
    public uint uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D9>()
        .Integer(x => x.uniqueId, 32);
    }
  }

  [Message(6072, 0x03DA)]
  public record Message03DA
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
      builder.FieldsOf<Message03DA>()
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

  [Message(6072, 0x03DB)]
  public record Message03DB
  {
    public uint uniqueId { get; set; }
    public Structure024? winner { get; set; }
    public uint itemId { get; set; }
    public uint need { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03DB>()
        .Integer(x => x.uniqueId, 32)
        .Structure(x => x.winner)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.need, 1);
    }
  }

  [Message(6072, 0x03DC)]
  public record Message03DC
  {
    public uint unitId { get; set; }
    public uint lootFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03DC>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.lootFlags, 32);
    }
  }

  [Message(6072, 0x03DD)]
  public record Message03DD
  {
    public uint unitId { get; set; }
    public uint looter { get; set; }
    public Structure0B9? lootInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03DD>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.looter, 32)
        .Structure(x => x.lootInfo);
    }
  }

  [Message(6072, 0x03DF)]
  public record Message03DF
  {
    public uint unitId { get; set; }
    public uint noDraw { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03DF>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.noDraw, 1);
    }
  }

  [Message(6072, 0x03E1)]
  public record Message03E1
  {
    public uint self { get; set; }
    public uint infoId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E1>()
        .Integer(x => x.self, 32)
        .Integer(x => x.infoId, 32);
    }
  }

  [Message(6072, 0x03E2)]
  public record Message03E2
  {
    public uint self { get; set; }
    public uint scanstate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E2>()
        .Integer(x => x.self, 32)
        .Integer(x => x.scanstate, 32);
    }
  }

  [Message(6072, 0x03E3)]
  public record Message03E3
  {
    public uint self { get; set; }
    public uint infoId { get; set; }
    public uint index { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E3>()
        .Integer(x => x.self, 32)
        .Integer(x => x.infoId, 32)
        .Integer(x => x.index, 32);
    }
  }

  [Message(6072, 0x03E4)]
  public record Message03E4
  {
    public uint self { get; set; }
    public uint infoId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E4>()
        .Integer(x => x.self, 32)
        .Integer(x => x.infoId, 32);
    }
  }

  [Message(6072, 0x03E5)]
  public record Message03E5
  {
    public uint self { get; set; }
    public uint groupId { get; set; }
    public uint remainingTimeMs { get; set; }
    public string? currentOwner { get; set; }
    public uint tierCount { get; set; }
    public Structure003[]? tiers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E5>()
        .Integer(x => x.self, 32)
        .Integer(x => x.groupId, 32)
        .Integer(x => x.remainingTimeMs, 32)
        .String(x => x.currentOwner, true)
        .Integer(x => x.tierCount, 32)
        .Array(x => x.tiers, x => x.tierCount).OfStructure();
    }
  }

  [Message(6072, 0x03E6)]
  public record Message03E6
  {
    public uint hub { get; set; }
    public uint[]? values { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E6>()
        .Integer(x => x.hub, 32)
        .Array(x => x.values, 3).OfInteger(32);
    }
  }

  [Message(6072, 0x03E7)]
  public record Message03E7
  {
    public uint self { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E7>()
        .Integer(x => x.self, 32)
        .Integer(x => x.type, 32);
    }
  }

  [Message(6072, 0x03E9)]
  public record Message03E9
  {
    public uint unitId { get; set; }
    public uint objectCount { get; set; }
    public Structure00F[]? objects { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E9>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.objectCount, 32)
        .Array(x => x.objects, x => x.objectCount).OfStructure();
    }
  }

  [Message(6072, 0x03EA)]
  public record Message03EA
  {
    public uint unitId { get; set; }
    public uint objectId { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03EA>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.objectId, 32)
        .Integer(x => x.type, 3);
    }
  }

  [Message(6072, 0x03EB)]
  public record Message03EB
  {
    public uint unitId { get; set; }
    public uint pvpFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03EB>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.pvpFlags, 32);
    }
  }

  [Message(6072, 0x03F1)]
  public record Message03F1
  {
    public uint self { get; set; }
    public uint passenger { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03F1>()
        .Integer(x => x.self, 32)
        .Integer(x => x.passenger, 32);
    }
  }

  [Message(6072, 0x03F6)]
  public record Message03F6
  {
    public uint unitId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03F6>()
        .Integer(x => x.unitId, 32)
        .String(x => x.name, true);
    }
  }

  [Message(6072, 0x040D)]
  public record Message040D
  {
    public uint unitId { get; set; }
    public uint state { get; set; }
    public uint value { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message040D>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.state, 5)
        .Integer(x => x.value, 32);
    }
  }

  [Message(6072, 0x040E)]
  public record Message040E
  {
    public uint unitId { get; set; }
    public uint stealthed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message040E>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.stealthed, 1);
    }
  }

  [Message(6072, 0x0414)]
  public record Message0414
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0414>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6072, 0x0415)]
  public record Message0415
  {
    public uint self { get; set; }
    public uint creatureId { get; set; }
    public uint displayInfoId { get; set; }
    public uint outfitInfoId { get; set; }
    public uint previousFactionOverride { get; set; }
    public uint factionOverride { get; set; }
    public float factionValue { get; set; }
    public string? nameOverride { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0415>()
        .Integer(x => x.self, 32)
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.displayInfoId, 32)
        .Integer(x => x.outfitInfoId, 32)
        .Integer(x => x.previousFactionOverride, 32)
        .Integer(x => x.factionOverride, 32)
        .Float(x => x.factionValue)
        .String(x => x.nameOverride, true);
    }
  }

  [Message(6072, 0x0416)]
  public record Message0416
  {
    public uint self { get; set; }
    public uint itemCount { get; set; }
    public Structure01A[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0416>()
        .Integer(x => x.self, 32)
        .Integer(x => x.itemCount, 32)
        .Array(x => x.items, x => x.itemCount).OfStructure();
    }
  }

  [Message(6072, 0x0417)]
  public record Message0417
  {
    public uint self { get; set; }
    public uint race { get; set; }
    public uint sex { get; set; }
    public float scale { get; set; }
    public uint itemCount { get; set; }
    public Structure01A[]? items { get; set; }
    public uint previousFactionOverride { get; set; }
    public uint factionOverride { get; set; }
    public float factionValue { get; set; }
    public string? nameOverride { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0417>()
        .Integer(x => x.self, 32)
        .Integer(x => x.race, 5)
        .Integer(x => x.sex, 2)
        .Float(x => x.scale)
        .Integer(x => x.itemCount, 32)
        .Array(x => x.items, x => x.itemCount).OfStructure()
        .Integer(x => x.previousFactionOverride, 32)
        .Integer(x => x.factionOverride, 32)
        .Float(x => x.factionValue)
        .String(x => x.nameOverride, true);
    }
  }

  [Message(6072, 0x0419)]
  public record Message0419
  {
    public uint unitId { get; set; }
    public uint newTargetId { get; set; }
    public uint threatLevel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0419>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.newTargetId, 32)
        .Integer(x => x.threatLevel, 32);
    }
  }

  [Message(6072, 0x041A)]
  public record Message041A
  {
    public uint srcUnitId { get; set; }
    public uint[]? threatUnitIds { get; set; }
    public uint[]? threatLevels { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message041A>()
        .Integer(x => x.srcUnitId, 32)
        .Array(x => x.threatUnitIds, 5).OfInteger(32)
        .Array(x => x.threatLevels, 5).OfInteger(32);
    }
  }

  [Message(6072, 0x041B)]
  public record Message041B
  {
    public uint unitId { get; set; }
    public uint targetId { get; set; }
    public uint threatLevel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message041B>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.targetId, 32)
        .Integer(x => x.threatLevel, 32);
    }
  }

  [Message(6072, 0x041C)]
  public record Message041C
  {
    public uint unitId { get; set; }
    public uint groupCount { get; set; }
    public Structure0A3[]? vendorGroups { get; set; }
    public uint itemCount { get; set; }
    public Structure0A4[]? vendorItems { get; set; }
    public float buyMultiplier { get; set; }
    public float sellMultiplier { get; set; }
    public uint initialList { get; set; }
    public uint failed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message041C>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.groupCount, 32)
        .Array(x => x.vendorGroups, x => x.groupCount).OfStructure()
        .Integer(x => x.itemCount, 32)
        .Array(x => x.vendorItems, x => x.itemCount).OfStructure()
        .Float(x => x.buyMultiplier)
        .Float(x => x.sellMultiplier)
        .Integer(x => x.initialList, 1)
        .Integer(x => x.failed, 1);
    }
  }

  [Message(6072, 0x041D)]
  public record Message041D
  {
    public uint spellId { get; set; }
    public uint abilityChargeCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message041D>()
        .Integer(x => x.spellId, 32)
        .Integer(x => x.abilityChargeCount, 32);
    }
  }

  [Message(6072, 0x041E)]
  public record Message041E
  {
    public uint numSlots { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message041E>()
        .Integer(x => x.numSlots, 32);
    }
  }

  [Message(6072, 0x041F)]
  public record Message041F
  {
    public uint stat { get; set; }
    public ulong newValue { get; set; }
    public uint combatRewardId { get; set; }
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message041F>()
        .Integer(x => x.stat, 5)
        .Integer(x => x.newValue, 64)
        .Integer(x => x.combatRewardId, 32)
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6072, 0x0426)]
  public record Message0426
  {
    public uint unitId { get; set; }
    public uint clusterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0426>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.clusterId, 32);
    }
  }

  [Message(6072, 0x0427)]
  public record Message0427
  {
    public uint unitId { get; set; }
    public uint equipmentCount { get; set; }
    public Structure01A[]? equipment { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0427>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.equipmentCount, 32)
        .Array(x => x.equipment, x => x.equipmentCount).OfStructure();
    }
  }

  [Message(6072, 0x0428)]
  public record Message0428
  {
    public uint unitId { get; set; }
    public uint factionId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0428>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.factionId, 32);
    }
  }

  [Message(6072, 0x0429)]
  public record Message0429
  {
    public uint unitId { get; set; }
    public ulong groupId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0429>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.groupId, 64);
    }
  }

  [Message(6072, 0x042A)]
  public record Message042A
  {
    public uint unitId { get; set; }
    public uint propertyCount { get; set; }
    public Structure0A1[]? properties { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042A>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.propertyCount, 32)
        .Array(x => x.properties, x => x.propertyCount).OfStructure();
    }
  }

  [Message(6072, 0x042B)]
  public record Message042B
  {
    public uint unitId { get; set; }
    public uint checklistIdx { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042B>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.checklistIdx, 32);
    }
  }

  [Message(6072, 0x042C)]
  public record Message042C
  {
    public uint unitId { get; set; }
    public Structure081? stat { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042C>()
        .Integer(x => x.unitId, 32)
        .Structure(x => x.stat);
    }
  }

  [Message(6072, 0x042D)]
  public record Message042D
  {
    public uint unitId { get; set; }
    public uint ownerUnitId { get; set; }
    public ulong ownerGroupId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042D>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.ownerUnitId, 32)
        .Integer(x => x.ownerGroupId, 64);
    }
  }

  [Message(6072, 0x042E)]
  public record Message042E
  {
    public uint clientUniqueId { get; set; }
    public Structure02C? location { get; set; }
    public uint targetUnitId { get; set; }
    public Structure02C? targetLocation { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042E>()
        .Integer(x => x.clientUniqueId, 32)
        .Structure(x => x.location)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.targetLocation)
        .Structure(x => x.position);
    }
  }

  [Message(6072, 0x0437)]
  public record Message0437
  {
    public uint constraintCount { get; set; }
    public Structure016[]? constraints { get; set; }
    public uint orCount { get; set; }
    public uint[]? orIndices { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0437>()
        .Integer(x => x.constraintCount, 32)
        .Array(x => x.constraints, x => x.constraintCount).OfStructure()
        .Integer(x => x.orCount, 32)
        .Array(x => x.orIndices, x => x.orCount).OfInteger(32);
    }
  }

  [Message(6072, 0x0438)]
  public record Message0438
  {
    public uint resultCount { get; set; }
    public Structure019[]? results { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0438>()
        .Integer(x => x.resultCount, 32)
        .Array(x => x.results, x => x.resultCount).OfStructure();
    }
  }

  [Message(6072, 0x043C)]
  public record Message043C
  {
    public uint targetUnitId { get; set; }
    public float meter { get; set; }
    public float successThreshold { get; set; }
    public float failureThreshold { get; set; }
    public uint rangeBand { get; set; }
    public float rate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message043C>()
        .Integer(x => x.targetUnitId, 32)
        .Float(x => x.meter)
        .Float(x => x.successThreshold)
        .Float(x => x.failureThreshold)
        .Integer(x => x.rangeBand, 32)
        .Float(x => x.rate);
    }
  }

  [Message(6072, 0x043D)]
  public record Message043D
  {
    public uint hexGroupId { get; set; }
    public uint tooltipStringId { get; set; }
    public uint color { get; set; }
    public uint visible { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message043D>()
        .Integer(x => x.hexGroupId, 32)
        .Integer(x => x.tooltipStringId, 32)
        .Integer(x => x.color, 32)
        .Integer(x => x.visible, 1);
    }
  }

}
