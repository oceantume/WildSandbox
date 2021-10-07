using System;
using WildSandbox.Common.Messages;

namespace WildSandbox.Messages.Build6152
{
  [Message(6152, 0x0002)]
  public record Message0002
  {
    public uint buildNumber { get; set; }
    public uint realmId { get; set; }
    public uint realmGroupId { get; set; }
    public uint realmGroupEnum { get; set; }
    public ulong startupTime { get; set; }
    public ushort listenPort { get; set; }
    public uint connectionType { get; set; }
    public uint networkMessageCRC { get; set; }
    public uint processId { get; set; }
    public ulong processCreationTime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0002>()
        .Integer(x => x.buildNumber, 32)
        .Integer(x => x.realmId, 32)
        .Integer(x => x.realmGroupId, 32)
        .Integer(x => x.realmGroupEnum, 32)
        .Integer(x => x.startupTime, 64)
        .Integer(x => x.listenPort, 16)
        .Integer(x => x.connectionType, 5)
        .Integer(x => x.networkMessageCRC, 32)
        .Integer(x => x.processId, 32)
        .Integer(x => x.processCreationTime, 64);
    }
  }

  [Message(6152, 0x0003)]
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

  [Message(6152, 0x0026)]
  public record Message0026
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0026>();
    }
  }

  [Message(6152, 0x0028)]
  public record Message0028
  {
    public Structure037? petInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0028>()
        .Structure(x => x.petInfo);
    }
  }

  [Message(6152, 0x002C)]
  public record Message002C
  {
    public uint petBarIdx { get; set; }
    public uint petBarCmdIdx { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message002C>()
        .Integer(x => x.petBarIdx, 32)
        .Integer(x => x.petBarCmdIdx, 32);
    }
  }

  [Message(6152, 0x0030)]
  public record Message0030
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0030>();
    }
  }

  [Message(6152, 0x0031)]
  public record Message0031
  {
    public float yaw { get; set; }
    public float pitch { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0031>()
        .Float(x => x.yaw)
        .Float(x => x.pitch);
    }
  }

  [Message(6152, 0x0032)]
  public record Message0032
  {
    public ulong orderId { get; set; }
    public uint itemId { get; set; }
    public uint buy { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0032>()
        .Integer(x => x.orderId, 64)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.buy, 1);
    }
  }

  [Message(6152, 0x0033)]
  public record Message0033
  {
    public uint itemId { get; set; }
    public ulong auctionId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0033>()
        .Integer(x => x.itemId, 32)
        .Integer(x => x.auctionId, 64);
    }
  }

  [Message(6152, 0x0035)]
  public record Message0035
  {
    public uint clientUniqueId { get; set; }
    public uint actionBarSetIndex { get; set; }
    public uint whichSet { get; set; }
    public uint targetUnitId { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0035>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.actionBarSetIndex, 32)
        .Integer(x => x.whichSet, 32)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.position);
    }
  }

  [Message(6152, 0x0036)]
  public record Message0036
  {
    public uint clientUniqueId { get; set; }
    public uint activateUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0036>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.activateUnitId, 32);
    }
  }

  [Message(6152, 0x0037)]
  public record Message0037
  {
    public uint clientUniqueId { get; set; }
    public uint activateUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0037>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.activateUnitId, 32);
    }
  }

  [Message(6152, 0x0038)]
  public record Message0038
  {
    public uint clientUniqueId { get; set; }
    public uint index { get; set; }
    public uint clueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0038>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.index, 32)
        .Integer(x => x.clueId, 32);
    }
  }

  [Message(6152, 0x0039)]
  public record Message0039
  {
    public uint clientUniqueId { get; set; }
    public uint spellBookIndex { get; set; }
    public uint targetUnitId { get; set; }
    public uint bButtonHeldCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0039>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.spellBookIndex, 32)
        .Integer(x => x.targetUnitId, 32)
        .Integer(x => x.bButtonHeldCast, 1);
    }
  }

  [Message(6152, 0x003A)]
  public record Message003A
  {
    public uint clientUniqueId { get; set; }
    public uint spellBookIndex { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message003A>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.spellBookIndex, 32)
        .Structure(x => x.position);
    }
  }

  [Message(6152, 0x003B)]
  public record Message003B
  {
    public uint clientUniqueId { get; set; }
    public uint spellId { get; set; }
    public uint targetUnitId { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message003B>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.spellId, 32)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.position);
    }
  }

  [Message(6152, 0x0045)]
  public record Message0045
  {
    public uint rewardId { get; set; }
    public uint lootItemType { get; set; }
    public uint amount { get; set; }
    public uint challengeTier { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0045>()
        .Integer(x => x.rewardId, 32)
        .Integer(x => x.lootItemType, 4)
        .Integer(x => x.amount, 32)
        .Integer(x => x.challengeTier, 32);
    }
  }

  [Message(6152, 0x0046)]
  public record Message0046
  {
    public uint challengeId { get; set; }
    public uint numRewardItems { get; set; }
    public Structure0C8[]? rewards { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0046>()
        .Integer(x => x.challengeId, 32)
        .Integer(x => x.numRewardItems, 32)
        .Array(x => x.rewards, x => x.numRewardItems).OfStructure();
    }
  }

  [Message(6152, 0x0048)]
  public record Message0048
  {
    public uint worldId { get; set; }
    public Structure014? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0048>()
        .Integer(x => x.worldId, 32)
        .Structure(x => x.location);
    }
  }

  [Message(6152, 0x0049)]
  public record Message0049
  {
    public uint m_achievementId { get; set; }
    public uint m_value00 { get; set; }
    public uint m_value01 { get; set; }
    public ulong m_dateCompleted { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0049>()
        .Integer(x => x.m_achievementId, 32)
        .Integer(x => x.m_value00, 32)
        .Integer(x => x.m_value01, 32)
        .Integer(x => x.m_dateCompleted, 64);
    }
  }

  [Message(6152, 0x004A)]
  public record Message004A
  {
    public uint itemDbId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004A>()
        .Integer(x => x.itemDbId, 32);
    }
  }

  [Message(6152, 0x004B)]
  public record Message004B
  {
    public uint count { get; set; }
    public uint[]? spellIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004B>()
        .Integer(x => x.count, 32)
        .Array(x => x.spellIds, x => x.count).OfInteger(32);
    }
  }

  [Message(6152, 0x004C)]
  public record Message004C
  {
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004C>()
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6152, 0x004D)]
  public record Message004D
  {
    public uint count { get; set; }
    public uint[]? activeSpells { get; set; }
    public uint abilityPoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004D>()
        .Integer(x => x.count, 32)
        .Array(x => x.activeSpells, x => x.count).OfInteger(32)
        .Integer(x => x.abilityPoints, 32);
    }
  }

  [Message(6152, 0x004E)]
  public record Message004E
  {
    public uint dyeColorId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004E>()
        .Integer(x => x.dyeColorId, 32);
    }
  }

  [Message(6152, 0x004F)]
  public record Message004F
  {
    public uint ownerId { get; set; }
    public uint lootId { get; set; }
    public Structure02A? target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message004F>()
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.lootId, 32)
        .Structure(x => x.target);
    }
  }

  [Message(6152, 0x0050)]
  public record Message0050
  {
    public ulong uniqueId { get; set; }
    public uint toBank { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0050>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.toBank, 1);
    }
  }

  [Message(6152, 0x0051)]
  public record Message0051
  {
    public uint on { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0051>()
        .Integer(x => x.on, 1);
    }
  }

  [Message(6152, 0x0052)]
  public record Message0052
  {
    public uint on { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0052>()
        .Integer(x => x.on, 1);
    }
  }

  [Message(6152, 0x0053)]
  public record Message0053
  {
    public uint inventoryIndex { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0053>()
        .Integer(x => x.inventoryIndex, 32);
    }
  }

  [Message(6152, 0x0054)]
  public record Message0054
  {
    public uint uniqueId { get; set; }
    public uint itemId { get; set; }
    public uint quantity { get; set; }
    public ulong randomCircuitData { get; set; }
    public ulong thresholdData { get; set; }
    public uint[]? microchips { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0054>()
        .Integer(x => x.uniqueId, 32)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.quantity, 32)
        .Integer(x => x.randomCircuitData, 64)
        .Integer(x => x.thresholdData, 64)
        .Array(x => x.microchips, 10).OfInteger(32);
    }
  }

  [Message(6152, 0x0055)]
  public record Message0055
  {
    public uint uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0055>()
        .Integer(x => x.uniqueId, 32);
    }
  }

  [Message(6152, 0x0056)]
  public record Message0056
  {
    public uint itemCount { get; set; }
    public Structure03F[]? buybackItems { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0056>()
        .Integer(x => x.itemCount, 32)
        .Array(x => x.buybackItems, x => x.itemCount).OfStructure();
    }
  }

  [Message(6152, 0x0057)]
  public record Message0057
  {
    public uint uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0057>()
        .Integer(x => x.uniqueId, 32);
    }
  }

  [Message(6152, 0x0058)]
  public record Message0058
  {
    public uint uniqueId { get; set; }
    public uint quantity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0058>()
        .Integer(x => x.uniqueId, 32)
        .Integer(x => x.quantity, 32);
    }
  }

  [Message(6152, 0x0059)]
  public record Message0059
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0059>();
    }
  }

  [Message(6152, 0x005A)]
  public record Message005A
  {
    public uint challengeId { get; set; }
    public uint actionType { get; set; }
    public uint extraData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005A>()
        .Integer(x => x.challengeId, 32)
        .Integer(x => x.actionType, 32)
        .Integer(x => x.extraData, 32);
    }
  }

  [Message(6152, 0x005B)]
  public record Message005B
  {
    public uint challengeId { get; set; }
    public uint actionType { get; set; }
    public uint extraData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005B>()
        .Integer(x => x.challengeId, 32)
        .Integer(x => x.actionType, 32)
        .Integer(x => x.extraData, 32);
    }
  }

  [Message(6152, 0x005C)]
  public record Message005C
  {
    public uint count { get; set; }
    public Structure0D5[]? challenges { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005C>()
        .Integer(x => x.count, 32)
        .Array(x => x.challenges, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x005D)]
  public record Message005D
  {
    public uint classId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005D>()
        .Integer(x => x.classId, 5);
    }
  }

  [Message(6152, 0x005E)]
  public record Message005E
  {
    public ulong uniqueItemId { get; set; }
    public uint chargesCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005E>()
        .Integer(x => x.uniqueItemId, 64)
        .Integer(x => x.chargesCount, 32);
    }
  }

  [Message(6152, 0x005F)]
  public record Message005F
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message005F>();
    }
  }

  [Message(6152, 0x0060)]
  public record Message0060
  {
    public uint commId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0060>()
        .Integer(x => x.commId, 32);
    }
  }

  [Message(6152, 0x0061)]
  public record Message0061
  {
    public uint commId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0061>()
        .Integer(x => x.commId, 32);
    }
  }

  [Message(6152, 0x0062)]
  public record Message0062
  {
    public uint itemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0062>()
        .Integer(x => x.itemId, 32);
    }
  }

  [Message(6152, 0x0063)]
  public record Message0063
  {
    public string? cheatStr { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0063>()
        .String(x => x.cheatStr, true);
    }
  }

  [Message(6152, 0x0064)]
  public record Message0064
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0064>();
    }
  }

  [Message(6152, 0x0065)]
  public record Message0065
  {
    public Structure02A? characterIdentity { get; set; }
    public uint portalUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0065>()
        .Structure(x => x.characterIdentity)
        .Integer(x => x.portalUnitId, 32);
    }
  }

  [Message(6152, 0x0066)]
  public record Message0066
  {
    public Structure02A? characterIdentity { get; set; }
    public uint portalUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0066>()
        .Structure(x => x.characterIdentity)
        .Integer(x => x.portalUnitId, 32);
    }
  }

  [Message(6152, 0x0067)]
  public record Message0067
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
      builder.FieldsOf<Message0067>()
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

  [Message(6152, 0x0068)]
  public record Message0068
  {
    public uint conversionId { get; set; }
    public uint amount { get; set; }
    public ulong uniqueItemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0068>()
        .Integer(x => x.conversionId, 32)
        .Integer(x => x.amount, 32)
        .Integer(x => x.uniqueItemId, 64);
    }
  }

  [Message(6152, 0x0069)]
  public record Message0069
  {
    public uint index { get; set; }
    public uint displayFlags { get; set; }
    public uint[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0069>()
        .Integer(x => x.index, 32)
        .Integer(x => x.displayFlags, 32)
        .Array(x => x.items, 6).OfInteger(32);
    }
  }

  [Message(6152, 0x006A)]
  public record Message006A
  {
    public uint count { get; set; }
    public Structure0CB[]? costumes { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006A>()
        .Integer(x => x.count, 32)
        .Array(x => x.costumes, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x006B)]
  public record Message006B
  {
    public uint schematicId { get; set; }
    public uint recipeId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006B>()
        .Integer(x => x.schematicId, 32)
        .Integer(x => x.recipeId, 32);
    }
  }

  [Message(6152, 0x006C)]
  public record Message006C
  {
    public ulong characterId { get; set; }
    public uint worldId { get; set; }
    public uint results { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006C>()
        .Integer(x => x.characterId, 64)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.results, 4);
    }
  }

  [Message(6152, 0x006D)]
  public record Message006D
  {
    public uint direction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006D>()
        .Integer(x => x.direction, 3);
    }
  }

  [Message(6152, 0x006E)]
  public record Message006E
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006E>();
    }
  }

  [Message(6152, 0x006F)]
  public record Message006F
  {
    public uint datacubeCount { get; set; }
    public Structure042[]? datacubeData { get; set; }
    public uint datacubeVolumeCount { get; set; }
    public Structure043[]? datacubeVolumeData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message006F>()
        .Integer(x => x.datacubeCount, 32)
        .Array(x => x.datacubeData, x => x.datacubeCount).OfStructure()
        .Integer(x => x.datacubeVolumeCount, 32)
        .Array(x => x.datacubeVolumeData, x => x.datacubeVolumeCount).OfStructure();
    }
  }

  [Message(6152, 0x0070)]
  public record Message0070
  {
    public uint datacubeId { get; set; }
    public uint progress { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0070>()
        .Integer(x => x.datacubeId, 32)
        .Integer(x => x.progress, 32);
    }
  }

  [Message(6152, 0x0071)]
  public record Message0071
  {
    public uint datacubeVolumeId { get; set; }
    public uint volumeProgress { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0071>()
        .Integer(x => x.datacubeVolumeId, 32)
        .Integer(x => x.volumeProgress, 32);
    }
  }

  [Message(6152, 0x0072)]
  public record Message0072
  {
    public uint bButtonHeldCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0072>()
        .Integer(x => x.bButtonHeldCast, 1);
    }
  }

  [Message(6152, 0x0073)]
  public record Message0073
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0073>();
    }
  }

  [Message(6152, 0x0074)]
  public record Message0074
  {
    public uint results { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0074>()
        .Integer(x => x.results, 4);
    }
  }

  [Message(6152, 0x0075)]
  public record Message0075
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0075>();
    }
  }

  [Message(6152, 0x0076)]
  public record Message0076
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0076>();
    }
  }

  [Message(6152, 0x0077)]
  public record Message0077
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0077>();
    }
  }

  [Message(6152, 0x0078)]
  public record Message0078
  {
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0078>()
        .Integer(x => x.result, 4);
    }
  }

  [Message(6152, 0x0079)]
  public record Message0079
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0079>();
    }
  }

  [Message(6152, 0x007A)]
  public record Message007A
  {
    public ulong uniqueId { get; set; }
    public uint[]? dyes { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007A>()
        .Integer(x => x.uniqueId, 64)
        .Array(x => x.dyes, 3).OfInteger(32);
    }
  }

  [Message(6152, 0x007B)]
  public record Message007B
  {
    public uint count { get; set; }
    public Structure0CF[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007B>()
        .Integer(x => x.count, 32)
        .Array(x => x.items, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x007C)]
  public record Message007C
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007C>();
    }
  }

  [Message(6152, 0x007D)]
  public record Message007D
  {
    public uint difficulty { get; set; }
    public uint gameMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007D>()
        .Integer(x => x.difficulty, 2)
        .Integer(x => x.gameMode, 3);
    }
  }

  [Message(6152, 0x007E)]
  public record Message007E
  {
    public uint worldZoneId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007E>()
        .Integer(x => x.worldZoneId, 32);
    }
  }

  [Message(6152, 0x007F)]
  public record Message007F
  {
    public uint missionId { get; set; }
    public uint nodeIndex { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message007F>()
        .Integer(x => x.missionId, 32)
        .Integer(x => x.nodeIndex, 32);
    }
  }

  [Message(6152, 0x0080)]
  public record Message0080
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0080>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6152, 0x0081)]
  public record Message0081
  {
    public uint powerMapId { get; set; }
    public uint travelerId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0081>()
        .Integer(x => x.powerMapId, 32)
        .Integer(x => x.travelerId, 32);
    }
  }

  [Message(6152, 0x0082)]
  public record Message0082
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0082>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6152, 0x0083)]
  public record Message0083
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0083>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6152, 0x0084)]
  public record Message0084
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0084>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6152, 0x0085)]
  public record Message0085
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0085>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6152, 0x0086)]
  public record Message0086
  {
    public uint powerMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0086>()
        .Integer(x => x.powerMapId, 32);
    }
  }

  [Message(6152, 0x0087)]
  public record Message0087
  {
    public float healthPercent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0087>()
        .Float(x => x.healthPercent);
    }
  }

  [Message(6152, 0x0088)]
  public record Message0088
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0088>();
    }
  }

  [Message(6152, 0x0089)]
  public record Message0089
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0089>();
    }
  }

  [Message(6152, 0x008A)]
  public record Message008A
  {
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008A>()
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6152, 0x008B)]
  public record Message008B
  {
    public uint taxiRouteCount { get; set; }
    public uint[]? taxiRouteList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008B>()
        .Integer(x => x.taxiRouteCount, 32)
        .Array(x => x.taxiRouteList, x => x.taxiRouteCount).OfInteger(32);
    }
  }

  [Message(6152, 0x008C)]
  public record Message008C
  {
    public uint forbidden { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008C>()
        .Integer(x => x.forbidden, 1);
    }
  }

  [Message(6152, 0x008D)]
  public record Message008D
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008D>();
    }
  }

  [Message(6152, 0x008E)]
  public record Message008E
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008E>();
    }
  }

  [Message(6152, 0x008F)]
  public record Message008F
  {
    public uint articleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message008F>()
        .Integer(x => x.articleId, 32);
    }
  }

  [Message(6152, 0x0090)]
  public record Message0090
  {
    public uint articleId { get; set; }
    public uint status { get; set; }
    public uint viewed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0090>()
        .Integer(x => x.articleId, 32)
        .Integer(x => x.status, 32)
        .Integer(x => x.viewed, 32);
    }
  }

  [Message(6152, 0x0091)]
  public record Message0091
  {
    public uint articleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0091>()
        .Integer(x => x.articleId, 32);
    }
  }

  [Message(6152, 0x0092)]
  public record Message0092
  {
    public uint error { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0092>()
        .Integer(x => x.error, 7);
    }
  }

  [Message(6152, 0x0093)]
  public record Message0093
  {
    public uint hazardId { get; set; }
    public uint actionType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0093>()
        .Integer(x => x.hazardId, 32)
        .Integer(x => x.actionType, 32);
    }
  }

  [Message(6152, 0x0094)]
  public record Message0094
  {
    public uint count { get; set; }
    public Structure0D6[]? hazards { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0094>()
        .Integer(x => x.count, 32)
        .Array(x => x.hazards, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x0095)]
  public record Message0095
  {
    public uint idCount { get; set; }
    public Structure0D7[]? hazardIdMods { get; set; }
    public uint typeCount { get; set; }
    public Structure0D7[]? hazardTypeMods { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0095>()
        .Integer(x => x.idCount, 32)
        .Array(x => x.hazardIdMods, x => x.idCount).OfStructure()
        .Integer(x => x.typeCount, 32)
        .Array(x => x.hazardTypeMods, x => x.typeCount).OfStructure();
    }
  }

  [Message(6152, 0x0096)]
  public record Message0096
  {
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0096>()
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6152, 0x0097)]
  public record Message0097
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
      builder.FieldsOf<Message0097>()
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

  [Message(6152, 0x0098)]
  public record Message0098
  {
    public uint unitId { get; set; }
    public uint itemId { get; set; }
    public uint count { get; set; }
    public uint errorCode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0098>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.count, 32)
        .Integer(x => x.errorCode, 7);
    }
  }

  [Message(6152, 0x0099)]
  public record Message0099
  {
    public Structure036? item { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0099>()
        .Structure(x => x.item)
        .Integer(x => x.reason, 5);
    }
  }

  [Message(6152, 0x009A)]
  public record Message009A
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
      builder.FieldsOf<Message009A>()
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

  [Message(6152, 0x009B)]
  public record Message009B
  {
    public uint publicEventId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009B>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6152, 0x009D)]
  public record Message009D
  {
    public uint characterCount { get; set; }
    public Structure021[]? characterInfo { get; set; }
    public uint additionalCount { get; set; }
    public uint[]? additionalAllowedCharCreations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009D>()
        .Integer(x => x.characterCount, 32)
        .Array(x => x.characterInfo, x => x.characterCount).OfStructure()
        .Integer(x => x.additionalCount, 32)
        .Array(x => x.additionalAllowedCharCreations, x => x.additionalCount).OfInteger(32);
    }
  }

  [Message(6152, 0x009F)]
  public record Message009F
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message009F>();
    }
  }

  [Message(6152, 0x00A0)]
  public record Message00A0
  {
    public uint lootUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A0>()
        .Integer(x => x.lootUniqueId, 32);
    }
  }

  [Message(6152, 0x00A1)]
  public record Message00A1
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A1>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6152, 0x00A2)]
  public record Message00A2
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A2>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6152, 0x00A3)]
  public record Message00A3
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A3>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6152, 0x00A4)]
  public record Message00A4
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A4>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6152, 0x00A5)]
  public record Message00A5
  {
    public ulong uniqueId { get; set; }
    public uint mailboxUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A5>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.mailboxUnitId, 32);
    }
  }

  [Message(6152, 0x00A6)]
  public record Message00A6
  {
    public ulong uniqueId { get; set; }
    public uint attachmentNdx { get; set; }
    public uint mailboxUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A6>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.attachmentNdx, 32)
        .Integer(x => x.mailboxUnitId, 32);
    }
  }

  [Message(6152, 0x00A7)]
  public record Message00A7
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A7>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6152, 0x00A8)]
  public record Message00A8
  {
    public ulong uniqueId { get; set; }
    public uint count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A8>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.count, 32);
    }
  }

  [Message(6152, 0x00A9)]
  public record Message00A9
  {
    public uint option { get; set; }
    public uint newValue { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00A9>()
        .Integer(x => x.option, 32)
        .Integer(x => x.newValue, 32);
    }
  }

  [Message(6152, 0x00AA)]
  public record Message00AA
  {
    public uint questId { get; set; }
    public uint objIdx { get; set; }
    public uint locationId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AA>()
        .Integer(x => x.questId, 32)
        .Integer(x => x.objIdx, 32)
        .Integer(x => x.locationId, 32);
    }
  }

  [Message(6152, 0x00AB)]
  public record Message00AB
  {
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AB>()
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x00AC)]
  public record Message00AC
  {
    public byte[]? unlockedFlair { get; set; }
    public uint petCustomizationCount { get; set; }
    public Structure04E[]? petCustomizations { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AC>()
        .Array(x => x.unlockedFlair, 512).OfInteger(8)
        .Integer(x => x.petCustomizationCount, 32)
        .Array(x => x.petCustomizations, x => x.petCustomizationCount).OfStructure();
    }
  }

  [Message(6152, 0x00AD)]
  public record Message00AD
  {
    public Structure04E? petCustomization { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AD>()
        .Structure(x => x.petCustomization);
    }
  }

  [Message(6152, 0x00AE)]
  public record Message00AE
  {
    public uint spellUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AE>()
        .Integer(x => x.spellUniqueId, 32);
    }
  }

  [Message(6152, 0x00AF)]
  public record Message00AF
  {
    public uint publicEventId { get; set; }
    public uint teamCount { get; set; }
    public Structure00C[]? teamStats { get; set; }
    public uint participantCount { get; set; }
    public Structure00D[]? participantStats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00AF>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.teamCount, 32)
        .Array(x => x.teamStats, x => x.teamCount).OfStructure()
        .Integer(x => x.participantCount, 32)
        .Array(x => x.participantStats, x => x.participantCount).OfStructure();
    }
  }

  [Message(6152, 0x00B0)]
  public record Message00B0
  {
    public uint objectId { get; set; }
    public uint type { get; set; }
    public uint location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B0>()
        .Integer(x => x.objectId, 32)
        .Integer(x => x.type, 3)
        .Integer(x => x.location, 32);
    }
  }

  [Message(6152, 0x00B1)]
  public record Message00B1
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
      builder.FieldsOf<Message00B1>()
        .Integer(x => x.objectiveId, 32)
        .Structure(x => x.objectiveStatus)
        .Integer(x => x.busy, 1)
        .Integer(x => x.elapsedTimeMs, 32)
        .Integer(x => x.notificationMode, 32)
        .Integer(x => x.locationCount, 32)
        .Array(x => x.locations, x => x.locationCount).OfInteger(32);
    }
  }

  [Message(6152, 0x00B2)]
  public record Message00B2
  {
    public uint objectiveId { get; set; }
    public uint notificationMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B2>()
        .Integer(x => x.objectiveId, 32)
        .Integer(x => x.notificationMode, 32);
    }
  }

  [Message(6152, 0x00B3)]
  public record Message00B3
  {
    public uint objectiveId { get; set; }
    public Structure004? objectiveStatus { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B3>()
        .Integer(x => x.objectiveId, 32)
        .Structure(x => x.objectiveStatus);
    }
  }

  [Message(6152, 0x00B4)]
  public record Message00B4
  {
    public uint publicEventId { get; set; }
    public uint busy { get; set; }
    public uint elapsedTimeMs { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B4>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.busy, 1)
        .Integer(x => x.elapsedTimeMs, 32);
    }
  }

  [Message(6152, 0x00B5)]
  public record Message00B5
  {
    public uint publicEventId { get; set; }
    public Structure00B? stats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B5>()
        .Integer(x => x.publicEventId, 32)
        .Structure(x => x.stats);
    }
  }

  [Message(6152, 0x00B6)]
  public record Message00B6
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
      builder.FieldsOf<Message00B6>()
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

  [Message(6152, 0x00B7)]
  public record Message00B7
  {
    public uint publicEventId { get; set; }
    public uint newTeamId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B7>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.newTeamId, 32);
    }
  }

  [Message(6152, 0x00B8)]
  public record Message00B8
  {
    public uint publicEventId { get; set; }
    public uint stat { get; set; }
    public uint value { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B8>()
        .Integer(x => x.publicEventId, 32)
        .Integer(x => x.stat, 32)
        .Integer(x => x.value, 32);
    }
  }

  [Message(6152, 0x00B9)]
  public record Message00B9
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00B9>();
    }
  }

  [Message(6152, 0x00BA)]
  public record Message00BA
  {
    public uint remaining { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BA>()
        .Integer(x => x.remaining, 32);
    }
  }

  [Message(6152, 0x00BB)]
  public record Message00BB
  {
    public uint pvpRatingsCount { get; set; }
    public Structure035[]? pvpRatingsData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BB>()
        .Integer(x => x.pvpRatingsCount, 32)
        .Array(x => x.pvpRatingsData, x => x.pvpRatingsCount).OfStructure();
    }
  }

  [Message(6152, 0x00BC)]
  public record Message00BC
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BC>();
    }
  }

  [Message(6152, 0x00BD)]
  public record Message00BD
  {
    public ulong uniqueId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BD>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.reason, 5);
    }
  }

  [Message(6152, 0x00BE)]
  public record Message00BE
  {
    public Structure034? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BE>()
        .Structure(x => x.location);
    }
  }

  [Message(6152, 0x00BF)]
  public record Message00BF
  {
    public Structure034? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00BF>()
        .Structure(x => x.location);
    }
  }

  [Message(6152, 0x00C0)]
  public record Message00C0
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C0>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6152, 0x00C1)]
  public record Message00C1
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C1>();
    }
  }

  [Message(6152, 0x00C2)]
  public record Message00C2
  {
    public uint ownerId { get; set; }
    public uint lootId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C2>()
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.lootId, 32);
    }
  }

  [Message(6152, 0x00C3)]
  public record Message00C3
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C3>();
    }
  }

  [Message(6152, 0x00C4)]
  public record Message00C4
  {
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C4>()
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6152, 0x00C5)]
  public record Message00C5
  {
    public byte resourceNdx { get; set; }
    public uint nextTick { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C5>()
        .Integer(x => x.resourceNdx, 8)
        .Integer(x => x.nextTick, 32);
    }
  }

  [Message(6152, 0x00C6)]
  public record Message00C6
  {
    public uint unitId { get; set; }
    public uint rezType { get; set; }
    public uint rezData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C6>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.rezType, 32)
        .Integer(x => x.rezData, 32);
    }
  }

  [Message(6152, 0x00C7)]
  public record Message00C7
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
      builder.FieldsOf<Message00C7>()
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

  [Message(6152, 0x00C8)]
  public record Message00C8
  {
    public uint direction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C8>()
        .Integer(x => x.direction, 3);
    }
  }

  [Message(6152, 0x00C9)]
  public record Message00C9
  {
    public uint ownerId { get; set; }
    public uint lootId { get; set; }
    public uint rollAction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00C9>()
        .Integer(x => x.ownerId, 32)
        .Integer(x => x.lootId, 32)
        .Integer(x => x.rollAction, 32);
    }
  }

  [Message(6152, 0x00CA)]
  public record Message00CA
  {
    public Structure034? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CA>()
        .Structure(x => x.location);
    }
  }

  [Message(6152, 0x00CB)]
  public record Message00CB
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CB>();
    }
  }

  [Message(6152, 0x00CD)]
  public record Message00CD
  {
    public Structure02A? characterIdentity { get; set; }
    public uint portalUnitId { get; set; }
    public uint difficulty { get; set; }
    public uint gameMode { get; set; }
    public uint transferFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CD>()
        .Structure(x => x.characterIdentity)
        .Integer(x => x.portalUnitId, 32)
        .Integer(x => x.difficulty, 32)
        .Integer(x => x.gameMode, 32)
        .Integer(x => x.transferFlags, 32);
    }
  }

  [Message(6152, 0x00CE)]
  public record Message00CE
  {
    public uint portalUnitId { get; set; }
    public uint allowedWorldDifficultyFlags { get; set; }
    public uint allowedWorldGameModeFlags { get; set; }
    public uint allowedFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CE>()
        .Integer(x => x.portalUnitId, 32)
        .Integer(x => x.allowedWorldDifficultyFlags, 32)
        .Integer(x => x.allowedWorldGameModeFlags, 32)
        .Integer(x => x.allowedFlags, 32);
    }
  }

  [Message(6152, 0x00CF)]
  public record Message00CF
  {
    public Structure034? location { get; set; }
    public uint quantity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00CF>()
        .Structure(x => x.location)
        .Integer(x => x.quantity, 32);
    }
  }

  [Message(6152, 0x00D0)]
  public record Message00D0
  {
    public string? toCharacterName { get; set; }
    public string? toCharacterRealmName { get; set; }
    public string? subject { get; set; }
    public string? body { get; set; }
    public ulong moneyToGive { get; set; }
    public ulong codAmount { get; set; }
    public uint deliverySpeed { get; set; }
    public uint mailboxUnitId { get; set; }
    public ulong[]? attachments { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D0>()
        .String(x => x.toCharacterName, true)
        .String(x => x.toCharacterRealmName, true)
        .String(x => x.subject, true)
        .String(x => x.body, true)
        .Integer(x => x.moneyToGive, 64)
        .Integer(x => x.codAmount, 64)
        .Integer(x => x.deliverySpeed, 2)
        .Integer(x => x.mailboxUnitId, 32)
        .Array(x => x.attachments, 12).OfInteger(64);
    }
  }

  [Message(6152, 0x00D1)]
  public record Message00D1
  {
    public uint abilityPoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D1>()
        .Integer(x => x.abilityPoints, 32);
    }
  }

  [Message(6152, 0x00D2)]
  public record Message00D2
  {
    public uint actionBarIndex { get; set; }
    public uint shortcutType { get; set; }
    public uint objectId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D2>()
        .Integer(x => x.actionBarIndex, 32)
        .Integer(x => x.shortcutType, 32)
        .Integer(x => x.objectId, 32);
    }
  }

  [Message(6152, 0x00D3)]
  public record Message00D3
  {
    public uint whichSet { get; set; }
    public uint associatedUnitId { get; set; }
    public uint actionBarCount { get; set; }
    public uint[]? actionBar { get; set; }
    public uint[]? shortcutType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D3>()
        .Integer(x => x.whichSet, 4)
        .Integer(x => x.associatedUnitId, 32)
        .Integer(x => x.actionBarCount, 32)
        .Array(x => x.actionBar, x => x.actionBarCount).OfInteger(32)
        .Array(x => x.shortcutType, x => x.actionBarCount).OfInteger(32);
    }
  }

  [Message(6152, 0x00D4)]
  public record Message00D4
  {
    public uint whichSet { get; set; }
    public uint actionBarShortcutSetId { get; set; }
    public uint associatedUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D4>()
        .Integer(x => x.whichSet, 4)
        .Integer(x => x.actionBarShortcutSetId, 32)
        .Integer(x => x.associatedUnitId, 32);
    }
  }

  [Message(6152, 0x00D5)]
  public record Message00D5
  {
    public uint bindPointId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D5>()
        .Integer(x => x.bindPointId, 32);
    }
  }

  [Message(6152, 0x00D6)]
  public record Message00D6
  {
    public byte index { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D6>()
        .Integer(x => x.index, 8);
    }
  }

  [Message(6152, 0x00D7)]
  public record Message00D7
  {
    public uint phasesIPerceive { get; set; }
    public uint phasesThatPerceiveMe { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D7>()
        .Integer(x => x.phasesIPerceive, 32)
        .Integer(x => x.phasesThatPerceiveMe, 32);
    }
  }

  [Message(6152, 0x00D8)]
  public record Message00D8
  {
    public uint on { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D8>()
        .Integer(x => x.on, 1);
    }
  }

  [Message(6152, 0x00D9)]
  public record Message00D9
  {
    public uint spellID { get; set; }
    public uint active { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00D9>()
        .Integer(x => x.spellID, 32)
        .Integer(x => x.active, 1);
    }
  }

  [Message(6152, 0x00DA)]
  public record Message00DA
  {
    public uint spellId { get; set; }
    public uint reason { get; set; }
    public uint data00 { get; set; }
    public uint add { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DA>()
        .Integer(x => x.spellId, 32)
        .Integer(x => x.reason, 3)
        .Integer(x => x.data00, 32)
        .Integer(x => x.add, 1);
    }
  }

  [Message(6152, 0x00DB)]
  public record Message00DB
  {
    public uint sheathState { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DB>()
        .Integer(x => x.sheathState, 1);
    }
  }

  [Message(6152, 0x00DC)]
  public record Message00DC
  {
    public uint tutorialId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DC>()
        .Integer(x => x.tutorialId, 32);
    }
  }

  [Message(6152, 0x00DD)]
  public record Message00DD
  {
    public uint spellId { get; set; }
    public uint active { get; set; }
    public uint abilityPoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DD>()
        .Integer(x => x.spellId, 32)
        .Integer(x => x.active, 1)
        .Integer(x => x.abilityPoints, 32);
    }
  }

  [Message(6152, 0x00DE)]
  public record Message00DE
  {
    public uint[]? points { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DE>()
        .Array(x => x.points, 6).OfInteger(32);
    }
  }

  [Message(6152, 0x00DF)]
  public record Message00DF
  {
    public ulong uniqueId { get; set; }
    public Structure034? toLocation { get; set; }
    public uint amount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00DF>()
        .Integer(x => x.uniqueId, 64)
        .Structure(x => x.toLocation)
        .Integer(x => x.amount, 32);
    }
  }

  [Message(6152, 0x00E0)]
  public record Message00E0
  {
    public uint on { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E0>()
        .Integer(x => x.on, 1);
    }
  }

  [Message(6152, 0x00E1)]
  public record Message00E1
  {
    public ulong uniqueItemId { get; set; }
    public uint stackCount { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E1>()
        .Integer(x => x.uniqueItemId, 64)
        .Integer(x => x.stackCount, 32)
        .Integer(x => x.reason, 5);
    }
  }

  [Message(6152, 0x00E2)]
  public record Message00E2
  {
    public uint profile { get; set; }
    public uint scanTarget { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E2>()
        .Integer(x => x.profile, 32)
        .Integer(x => x.scanTarget, 1);
    }
  }

  [Message(6152, 0x00E3)]
  public record Message00E3
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E3>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x00E4)]
  public record Message00E4
  {
    public uint fromCheat { get; set; }
    public Structure034? fromLocation { get; set; }
    public Structure034? toLocation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E4>()
        .Integer(x => x.fromCheat, 1)
        .Structure(x => x.fromLocation)
        .Structure(x => x.toLocation);
    }
  }

  [Message(6152, 0x00E5)]
  public record Message00E5
  {
    public uint materialId { get; set; }
    public uint count { get; set; }
    public Structure034? location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E5>()
        .Integer(x => x.materialId, 32)
        .Integer(x => x.count, 32)
        .Structure(x => x.location);
    }
  }

  [Message(6152, 0x00E6)]
  public record Message00E6
  {
    public uint newtargetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E6>()
        .Integer(x => x.newtargetUnitId, 32);
    }
  }

  [Message(6152, 0x00E7)]
  public record Message00E7
  {
    public uint taxiNodeId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E7>()
        .Integer(x => x.taxiNodeId, 32);
    }
  }

  [Message(6152, 0x00E8)]
  public record Message00E8
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E8>();
    }
  }

  [Message(6152, 0x00E9)]
  public record Message00E9
  {
    public uint taxiNodeCount { get; set; }
    public uint[]? taxiNodeData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00E9>()
        .Integer(x => x.taxiNodeCount, 32)
        .Array(x => x.taxiNodeData, x => x.taxiNodeCount).OfInteger(32);
    }
  }

  [Message(6152, 0x00EA)]
  public record Message00EA
  {
    public uint unitId { get; set; }
    public uint titleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EA>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.titleId, 32);
    }
  }

  [Message(6152, 0x00EB)]
  public record Message00EB
  {
    public uint titleId { get; set; }
    public uint alreadyowned { get; set; }
    public uint revoked { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EB>()
        .Integer(x => x.titleId, 32)
        .Integer(x => x.alreadyowned, 1)
        .Integer(x => x.revoked, 1);
    }
  }

  [Message(6152, 0x00EC)]
  public record Message00EC
  {
    public uint titleCount { get; set; }
    public Structure041[]? titleData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EC>()
        .Integer(x => x.titleCount, 32)
        .Array(x => x.titleData, x => x.titleCount).OfStructure();
    }
  }

  [Message(6152, 0x00ED)]
  public record Message00ED
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00ED>();
    }
  }

  [Message(6152, 0x00EE)]
  public record Message00EE
  {
    public ulong uniqueItemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EE>()
        .Integer(x => x.uniqueItemId, 64);
    }
  }

  [Message(6152, 0x00EF)]
  public record Message00EF
  {
    public Structure0D4? p2pTradeItem { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00EF>()
        .Structure(x => x.p2pTradeItem);
    }
  }

  [Message(6152, 0x00F0)]
  public record Message00F0
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F0>();
    }
  }

  [Message(6152, 0x00F1)]
  public record Message00F1
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F1>();
    }
  }

  [Message(6152, 0x00F2)]
  public record Message00F2
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F2>();
    }
  }

  [Message(6152, 0x00F3)]
  public record Message00F3
  {
    public uint tradeTargetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F3>()
        .Integer(x => x.tradeTargetId, 32);
    }
  }

  [Message(6152, 0x00F4)]
  public record Message00F4
  {
    public uint tradeInitiator { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F4>()
        .Integer(x => x.tradeInitiator, 32);
    }
  }

  [Message(6152, 0x00F5)]
  public record Message00F5
  {
    public ulong uniqueItemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F5>()
        .Integer(x => x.uniqueItemId, 64);
    }
  }

  [Message(6152, 0x00F6)]
  public record Message00F6
  {
    public ulong itemUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F6>()
        .Integer(x => x.itemUniqueId, 64);
    }
  }

  [Message(6152, 0x00F7)]
  public record Message00F7
  {
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F7>()
        .Integer(x => x.result, 32);
    }
  }

  [Message(6152, 0x00F8)]
  public record Message00F8
  {
    public ulong amount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F8>()
        .Integer(x => x.amount, 64);
    }
  }

  [Message(6152, 0x00F9)]
  public record Message00F9
  {
    public uint owner { get; set; }
    public ulong amount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00F9>()
        .Integer(x => x.owner, 32)
        .Integer(x => x.amount, 64);
    }
  }

  [Message(6152, 0x00FA)]
  public record Message00FA
  {
    public uint materialId { get; set; }
    public byte stackCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FA>()
        .Integer(x => x.materialId, 32)
        .Integer(x => x.stackCount, 8);
    }
  }

  [Message(6152, 0x00FB)]
  public record Message00FB
  {
    public uint spellId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FB>()
        .Integer(x => x.spellId, 32);
    }
  }

  [Message(6152, 0x00FC)]
  public record Message00FC
  {
    public uint unitId { get; set; }
    public uint tileId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FC>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.tileId, 32);
    }
  }

  [Message(6152, 0x00FD)]
  public record Message00FD
  {
    public uint actionBarCount { get; set; }
    public Structure03E[]? actionBar { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FD>()
        .Integer(x => x.actionBarCount, 32)
        .Array(x => x.actionBar, x => x.actionBarCount).OfStructure();
    }
  }

  [Message(6152, 0x00FE)]
  public record Message00FE
  {
    public uint attributePoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FE>()
        .Integer(x => x.attributePoints, 32);
    }
  }

  [Message(6152, 0x00FF)]
  public record Message00FF
  {
    public byte index { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message00FF>()
        .Integer(x => x.index, 8);
    }
  }

  [Message(6152, 0x0100)]
  public record Message0100
  {
    public uint delta { get; set; }
    public uint elderPoints { get; set; }
    public uint dailyElderPoints { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0100>()
        .Integer(x => x.delta, 32)
        .Integer(x => x.elderPoints, 32)
        .Integer(x => x.dailyElderPoints, 32);
    }
  }

  [Message(6152, 0x0101)]
  public record Message0101
  {
    public uint factionId { get; set; }
    public float diff { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0101>()
        .Integer(x => x.factionId, 32)
        .Float(x => x.diff);
    }
  }

  [Message(6152, 0x0102)]
  public record Message0102
  {
    public float score { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0102>()
        .Float(x => x.score);
    }
  }

  [Message(6152, 0x0103)]
  public record Message0103
  {
    public ulong uniqueId { get; set; }
    public float durability { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0103>()
        .Integer(x => x.uniqueId, 64)
        .Float(x => x.durability);
    }
  }

  [Message(6152, 0x0104)]
  public record Message0104
  {
    public ulong uniqueId { get; set; }
    public uint dyeData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0104>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.dyeData, 32);
    }
  }

  [Message(6152, 0x0105)]
  public record Message0105
  {
    public uint factionId { get; set; }
    public float diff { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0105>()
        .Integer(x => x.factionId, 32)
        .Float(x => x.diff);
    }
  }

  [Message(6152, 0x0106)]
  public record Message0106
  {
    public uint itemSetId { get; set; }
    public uint setPower { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0106>()
        .Integer(x => x.itemSetId, 32)
        .Integer(x => x.setPower, 32);
    }
  }

  [Message(6152, 0x0107)]
  public record Message0107
  {
    public uint totalXP { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0107>()
        .Integer(x => x.totalXP, 32);
    }
  }

  [Message(6152, 0x0108)]
  public record Message0108
  {
    public byte showRezFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0108>()
        .Integer(x => x.showRezFlags, 8);
    }
  }

  [Message(6152, 0x0109)]
  public record Message0109
  {
    public uint baseXpDelta { get; set; }
    public uint restedXpDelta { get; set; }
    public uint reason { get; set; }
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0109>()
        .Integer(x => x.baseXpDelta, 32)
        .Integer(x => x.restedXpDelta, 32)
        .Integer(x => x.reason, 32)
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6152, 0x010A)]
  public record Message010A
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010A>();
    }
  }

  [Message(6152, 0x010B)]
  public record Message010B
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010B>();
    }
  }

  [Message(6152, 0x010C)]
  public record Message010C
  {
    public uint vehicleUnitId { get; set; }
    public uint seat { get; set; }
    public byte position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010C>()
        .Integer(x => x.vehicleUnitId, 32)
        .Integer(x => x.seat, 2)
        .Integer(x => x.position, 8);
    }
  }

  [Message(6152, 0x010D)]
  public record Message010D
  {
    public uint ghostId { get; set; }
    public uint rezCost { get; set; }
    public uint timeUntilRezMS { get; set; }
    public uint dead { get; set; }
    public byte showRezFlags { get; set; }
    public uint timeUntilWakeHereMS { get; set; }
    public uint timeUntilForceRezMS { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010D>()
        .Integer(x => x.ghostId, 32)
        .Integer(x => x.rezCost, 32)
        .Integer(x => x.timeUntilRezMS, 32)
        .Integer(x => x.dead, 1)
        .Integer(x => x.showRezFlags, 8)
        .Integer(x => x.timeUntilWakeHereMS, 32)
        .Integer(x => x.timeUntilForceRezMS, 32);
    }
  }

  [Message(6152, 0x010E)]
  public record Message010E
  {
    public uint zoneMapId { get; set; }
    public uint count { get; set; }
    public byte[]? zoneMapBits { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010E>()
        .Integer(x => x.zoneMapId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.zoneMapBits, x => x.count).OfInteger(8);
    }
  }

  [Message(6152, 0x010F)]
  public record Message010F
  {
    public uint petId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message010F>()
        .Integer(x => x.petId, 32)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x0110)]
  public record Message0110
  {
    public ulong petId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0110>()
        .Integer(x => x.petId, 64);
    }
  }

  [Message(6152, 0x0111)]
  public record Message0111
  {
    public uint stance { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0111>()
        .Integer(x => x.stance, 32);
    }
  }

  [Message(6152, 0x0112)]
  public record Message0112
  {
    public Structure031? channel { get; set; }
    public string? nameActor { get; set; }
    public string? nameActedOn { get; set; }
    public uint action { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0112>()
        .Structure(x => x.channel)
        .String(x => x.nameActor, true)
        .String(x => x.nameActedOn, true)
        .Integer(x => x.action, 4);
    }
  }

  [Message(6152, 0x0113)]
  public record Message0113
  {
    public Structure031? channel { get; set; }
    public string? characterName { get; set; }
    public uint status { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0113>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true)
        .Integer(x => x.status, 1);
    }
  }

  [Message(6152, 0x0114)]
  public record Message0114
  {
    public Structure031? channel { get; set; }
    public uint count { get; set; }
    public string[]? names { get; set; }
    public uint more { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0114>()
        .Structure(x => x.channel)
        .Integer(x => x.count, 32)
        .Array(x => x.names, x => x.count).OfString(true)
        .Integer(x => x.more, 1);
    }
  }

  [Message(6152, 0x0115)]
  public record Message0115
  {
    public Structure031? channel { get; set; }
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0115>()
        .Structure(x => x.channel)
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6152, 0x0117)]
  public record Message0117
  {
    public string? name { get; set; }
    public string? password { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0117>()
        .String(x => x.name, true)
        .String(x => x.password, true);
    }
  }

  [Message(6152, 0x0118)]
  public record Message0118
  {
    public string? name { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0118>()
        .String(x => x.name, true)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6152, 0x0119)]
  public record Message0119
  {
    public Structure031? channel { get; set; }
    public string? name { get; set; }
    public uint memberCount { get; set; }
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0119>()
        .Structure(x => x.channel)
        .String(x => x.name, true)
        .Integer(x => x.memberCount, 32)
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6152, 0x011A)]
  public record Message011A
  {
    public Structure031? channel { get; set; }
    public string? characterName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011A>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true);
    }
  }

  [Message(6152, 0x011B)]
  public record Message011B
  {
    public Structure031? channel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011B>()
        .Structure(x => x.channel);
    }
  }

  [Message(6152, 0x011C)]
  public record Message011C
  {
    public Structure031? channel { get; set; }
    public uint leave { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011C>()
        .Structure(x => x.channel)
        .Integer(x => x.leave, 2);
    }
  }

  [Message(6152, 0x011D)]
  public record Message011D
  {
    public Structure031? channel { get; set; }
    public uint count { get; set; }
    public string[]? names { get; set; }
    public uint[]? flags { get; set; }
    public uint more { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011D>()
        .Structure(x => x.channel)
        .Integer(x => x.count, 32)
        .Array(x => x.names, x => x.count).OfString(true)
        .Array(x => x.flags, x => x.count).OfInteger(32)
        .Integer(x => x.more, 1);
    }
  }

  [Message(6152, 0x011E)]
  public record Message011E
  {
    public Structure031? channel { get; set; }
    public Structure032? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message011E>()
        .Structure(x => x.channel)
        .Structure(x => x.message);
    }
  }

  [Message(6152, 0x0120)]
  public record Message0120
  {
    public Structure031? channel { get; set; }
    public uint fromId { get; set; }
    public uint messageId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0120>()
        .Structure(x => x.channel)
        .Integer(x => x.fromId, 32)
        .Integer(x => x.messageId, 32);
    }
  }

  [Message(6152, 0x0122)]
  public record Message0122
  {
    public Structure031? channel { get; set; }
    public uint GM { get; set; }
    public uint self { get; set; }
    public Structure02A? fromIdentity { get; set; }
    public string? fromName { get; set; }
    public string? fromRealm { get; set; }
    public Structure032? message { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0122>()
        .Structure(x => x.channel)
        .Integer(x => x.GM, 1)
        .Integer(x => x.self, 1)
        .Structure(x => x.fromIdentity)
        .String(x => x.fromName, true)
        .String(x => x.fromRealm, true)
        .Structure(x => x.message)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x0124)]
  public record Message0124
  {
    public Structure031? channel { get; set; }
    public uint fromId { get; set; }
    public string? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0124>()
        .Structure(x => x.channel)
        .Integer(x => x.fromId, 32)
        .String(x => x.message, true);
    }
  }

  [Message(6152, 0x0126)]
  public record Message0126
  {
    public Structure031? channel { get; set; }
    public string? characterName { get; set; }
    public uint status { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0126>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true)
        .Integer(x => x.status, 1);
    }
  }

  [Message(6152, 0x0127)]
  public record Message0127
  {
    public Structure031? channel { get; set; }
    public string? characterName { get; set; }
    public uint status { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0127>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true)
        .Integer(x => x.status, 1);
    }
  }

  [Message(6152, 0x0128)]
  public record Message0128
  {
    public Structure031? channel { get; set; }
    public string? characterName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0128>()
        .Structure(x => x.channel)
        .String(x => x.characterName, true);
    }
  }

  [Message(6152, 0x0129)]
  public record Message0129
  {
    public Structure031? channel { get; set; }
    public string? password { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0129>()
        .Structure(x => x.channel)
        .String(x => x.password, true);
    }
  }

  [Message(6152, 0x012A)]
  public record Message012A
  {
    public Structure031? channel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012A>()
        .Structure(x => x.channel);
    }
  }

  [Message(6152, 0x012B)]
  public record Message012B
  {
    public Structure031? channel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012B>()
        .Structure(x => x.channel);
    }
  }

  [Message(6152, 0x012C)]
  public record Message012C
  {
    public Structure031? channel { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012C>()
        .Structure(x => x.channel)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6152, 0x012D)]
  public record Message012D
  {
    public string? characterTo { get; set; }
    public string? realmTo { get; set; }
    public Structure032? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message012D>()
        .String(x => x.characterTo, true)
        .String(x => x.realmTo, true)
        .Structure(x => x.message);
    }
  }

  [Message(6152, 0x0131)]
  public record Message0131
  {
    public string? characterTo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0131>()
        .String(x => x.characterTo, true);
    }
  }

  [Message(6152, 0x0132)]
  public record Message0132
  {
    public uint worldZoneId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0132>()
        .Integer(x => x.worldZoneId, 32);
    }
  }

  [Message(6152, 0x0134)]
  public record Message0134
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0134>();
    }
  }

  [Message(6152, 0x0135)]
  public record Message0135
  {
    public uint attachType { get; set; }
    public uint attachId { get; set; }
    public uint delay { get; set; }
    public uint parentUnit { get; set; }
    public uint useRotation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0135>()
        .Integer(x => x.attachType, 32)
        .Integer(x => x.attachId, 32)
        .Integer(x => x.delay, 32)
        .Integer(x => x.parentUnit, 32)
        .Integer(x => x.useRotation, 1);
    }
  }

  [Message(6152, 0x0136)]
  public record Message0136
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
      builder.FieldsOf<Message0136>()
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

  [Message(6152, 0x0137)]
  public record Message0137
  {
    public uint delay { get; set; }
    public uint spline { get; set; }
    public uint splineMode { get; set; }
    public float speed { get; set; }
    public uint target { get; set; }
    public uint useRotation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0137>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.spline, 32)
        .Integer(x => x.splineMode, 32)
        .Float(x => x.speed)
        .Integer(x => x.target, 1)
        .Integer(x => x.useRotation, 1);
    }
  }

  [Message(6152, 0x0138)]
  public record Message0138
  {
    public uint delay { get; set; }
    public uint type { get; set; }
    public ushort durationStart { get; set; }
    public ushort durationMid { get; set; }
    public ushort durationEnd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0138>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.type, 32)
        .Integer(x => x.durationStart, 16)
        .Integer(x => x.durationMid, 16)
        .Integer(x => x.durationEnd, 16);
    }
  }

  [Message(6152, 0x0139)]
  public record Message0139
  {
    public uint delay { get; set; }
    public uint unit { get; set; }
    public uint target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0139>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.unit, 32)
        .Integer(x => x.target, 1);
    }
  }

  [Message(6152, 0x013A)]
  public record Message013A
  {
    public uint delay { get; set; }
    public uint flags { get; set; }
    public uint endTran { get; set; }
    public ushort tranDurationStart { get; set; }
    public ushort tranDurationMid { get; set; }
    public ushort tranDurationEnd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013A>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.endTran, 32)
        .Integer(x => x.tranDurationStart, 16)
        .Integer(x => x.tranDurationMid, 16)
        .Integer(x => x.tranDurationEnd, 16);
    }
  }

  [Message(6152, 0x013B)]
  public record Message013B
  {
    public uint delay { get; set; }
    public uint visualHandle { get; set; }
    public uint from { get; set; }
    public uint to { get; set; }
    public uint missileRecId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013B>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.visualHandle, 32)
        .Integer(x => x.from, 32)
        .Integer(x => x.to, 32)
        .Integer(x => x.missileRecId, 32);
    }
  }

  [Message(6152, 0x013C)]
  public record Message013C
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
      builder.FieldsOf<Message013C>()
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

  [Message(6152, 0x013D)]
  public record Message013D
  {
    public uint delay { get; set; }
    public uint spawnHandle { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013D>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.spawnHandle, 32);
    }
  }

  [Message(6152, 0x013E)]
  public record Message013E
  {
    public byte unused { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013E>()
        .Integer(x => x.unused, 8);
    }
  }

  [Message(6152, 0x013F)]
  public record Message013F
  {
    public uint delay { get; set; }
    public uint unitId { get; set; }
    public uint hide { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message013F>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.unitId, 32)
        .Integer(x => x.hide, 1);
    }
  }

  [Message(6152, 0x0140)]
  public record Message0140
  {
    public uint delay { get; set; }
    public float yaw { get; set; }
    public float pitch { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0140>()
        .Integer(x => x.delay, 32)
        .Float(x => x.yaw)
        .Float(x => x.pitch);
    }
  }

  [Message(6152, 0x0141)]
  public record Message0141
  {
    public uint type { get; set; }
    public ushort durationStart { get; set; }
    public ushort durationMid { get; set; }
    public ushort durationEnd { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0141>()
        .Integer(x => x.type, 32)
        .Integer(x => x.durationStart, 16)
        .Integer(x => x.durationMid, 16)
        .Integer(x => x.durationEnd, 16);
    }
  }

  [Message(6152, 0x0142)]
  public record Message0142
  {
    public uint delay { get; set; }
    public uint visualHandle { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0142>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.visualHandle, 32);
    }
  }

  [Message(6152, 0x0143)]
  public record Message0143
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
      builder.FieldsOf<Message0143>()
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

  [Message(6152, 0x0144)]
  public record Message0144
  {
    public uint delay { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0144>()
        .Integer(x => x.delay, 32);
    }
  }

  [Message(6152, 0x0145)]
  public record Message0145
  {
    public uint destinationId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0145>()
        .Integer(x => x.destinationId, 32);
    }
  }

  [Message(6152, 0x0146)]
  public record Message0146
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0146>();
    }
  }

  [Message(6152, 0x0147)]
  public record Message0147
  {
    public uint delay { get; set; }
    public uint show { get; set; }
    public uint animate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0147>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.show, 1)
        .Integer(x => x.animate, 1);
    }
  }

  [Message(6152, 0x0148)]
  public record Message0148
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
      builder.FieldsOf<Message0148>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.actorHandle, 32)
        .Integer(x => x.spline, 32)
        .Float(x => x.splineSpeed)
        .Integer(x => x.splineMode, 32)
        .Integer(x => x.useRotation, 1)
        .Integer(x => x.strafe, 1);
    }
  }

  [Message(6152, 0x0149)]
  public record Message0149
  {
    public uint delay { get; set; }
    public uint unitId { get; set; }
    public float angle { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0149>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.unitId, 32)
        .Float(x => x.angle);
    }
  }

  [Message(6152, 0x014A)]
  public record Message014A
  {
    public uint delay { get; set; }
    public uint unitId { get; set; }
    public uint mode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message014A>()
        .Integer(x => x.delay, 32)
        .Integer(x => x.unitId, 32)
        .Integer(x => x.mode, 32);
    }
  }

  [Message(6152, 0x014B)]
  public record Message014B
  {
    public ushort flags { get; set; }
    public ushort cancel { get; set; }
    public uint duration { get; set; }
    public uint cinematicId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message014B>()
        .Integer(x => x.flags, 16)
        .Integer(x => x.cancel, 16)
        .Integer(x => x.duration, 32)
        .Integer(x => x.cinematicId, 32);
    }
  }

  [Message(6152, 0x014E)]
  public record Message014E
  {
    public uint targetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message014E>()
        .Integer(x => x.targetId, 32);
    }
  }

  [Message(6152, 0x0150)]
  public record Message0150
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0150>();
    }
  }

  [Message(6152, 0x0151)]
  public record Message0151
  {
    public uint avgMs { get; set; }
    public uint worstMs { get; set; }
    public float worstX { get; set; }
    public float worstY { get; set; }
    public float worstZ { get; set; }
    public float worstFacing { get; set; }
    public uint baseline { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0151>()
        .Integer(x => x.avgMs, 32)
        .Integer(x => x.worstMs, 32)
        .Float(x => x.worstX)
        .Float(x => x.worstY)
        .Float(x => x.worstZ)
        .Float(x => x.worstFacing)
        .Integer(x => x.baseline, 32);
    }
  }

  [Message(6152, 0x0152)]
  public record Message0152
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0152>();
    }
  }

  [Message(6152, 0x0156)]
  public record Message0156
  {
    public Structure0B6? order { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0156>()
        .Structure(x => x.order)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6152, 0x0157)]
  public record Message0157
  {
    public uint itemId { get; set; }
    public uint buyOrderCount { get; set; }
    public ulong[]? buyOrderPrices { get; set; }
    public uint sellOrderCount { get; set; }
    public ulong[]? sellOrderPrices { get; set; }
    public uint orderCount { get; set; }
    public Structure0B6[]? orders { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0157>()
        .Integer(x => x.itemId, 32)
        .Integer(x => x.buyOrderCount, 32)
        .Array(x => x.buyOrderPrices, 3).OfInteger(64)
        .Integer(x => x.sellOrderCount, 32)
        .Array(x => x.sellOrderPrices, 3).OfInteger(64)
        .Integer(x => x.orderCount, 32)
        .Array(x => x.orders, x => x.orderCount).OfStructure();
    }
  }

  [Message(6152, 0x0159)]
  public record Message0159
  {
    public string? copyName { get; set; }
    public string? newName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0159>()
        .String(x => x.copyName, true)
        .String(x => x.newName, true);
    }
  }

  [Message(6152, 0x015A)]
  public record Message015A
  {
    public uint index { get; set; }
    public uint[]? itemIds { get; set; }
    public uint displayFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message015A>()
        .Integer(x => x.index, 32)
        .Array(x => x.itemIds, 6).OfInteger(32)
        .Integer(x => x.displayFlags, 32);
    }
  }

  [Message(6152, 0x015B)]
  public record Message015B
  {
    public uint index { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message015B>()
        .Integer(x => x.index, 32);
    }
  }

  [Message(6152, 0x015C)]
  public record Message015C
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
      builder.FieldsOf<Message015C>()
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

  [Message(6152, 0x015E)]
  public record Message015E
  {
    public uint inventoryCount { get; set; }
    public Structure038[]? inventory { get; set; }
    public ulong[]? money { get; set; }
    public uint xp { get; set; }
    public uint restBonusXp { get; set; }
    public uint itemProficiencies { get; set; }
    public uint elderPoints { get; set; }
    public uint dailyElderPoints { get; set; }
    public Structure039? factionData { get; set; }
    public uint petCount { get; set; }
    public Structure037[]? petList { get; set; }
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
    public float gearScore { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message015E>()
        .Integer(x => x.inventoryCount, 32)
        .Array(x => x.inventory, x => x.inventoryCount).OfStructure()
        .Array(x => x.money, 6).OfInteger(64)
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
        .Array(x => x.tradeskillMaterials, 192).OfInteger(8)
        .Float(x => x.gearScore);
    }
  }

  [Message(6152, 0x015F)]
  public record Message015F
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
      builder.FieldsOf<Message015F>()
        .Integer(x => x.missileRecId, 32)
        .Integer(x => x.sourceUnitId, 32)
        .Structure(x => x.sourcePosition)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.targetPosition)
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.timeElapsed, 32);
    }
  }

  [Message(6152, 0x0160)]
  public record Message0160
  {
    public uint missileCount { get; set; }
    public Structure066[]? missiles { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0160>()
        .Integer(x => x.missileCount, 32)
        .Array(x => x.missiles, x => x.missileCount).OfStructure();
    }
  }

  [Message(6152, 0x0161)]
  public record Message0161
  {
    public uint visualCount { get; set; }
    public Structure065[]? visuals { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0161>()
        .Integer(x => x.visualCount, 32)
        .Array(x => x.visuals, x => x.visualCount).OfStructure();
    }
  }

  [Message(6152, 0x0162)]
  public record Message0162
  {
    public string? realmName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0162>()
        .String(x => x.realmName, true);
    }
  }

  [Message(6152, 0x0163)]
  public record Message0163
  {
    public uint unitId { get; set; }
    public uint unitType { get; set; }
    public Union006? unitInfo { get; set; }
    public uint createFlags { get; set; }
    public uint statCount { get; set; }
    public Structure08D[]? stats { get; set; }
    public uint time { get; set; }
    public ushort commandCount { get; set; }
    public Structure08E[]? commands { get; set; }
    public uint propertyCount { get; set; }
    public Structure0AF[]? properties { get; set; }
    public uint equipmentCount { get; set; }
    public Structure020[]? equipment { get; set; }
    public ushort spellCastInitCount { get; set; }
    public Structure068[]? spellInit { get; set; }
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
      builder.FieldsOf<Message0163>()
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
            .Match(x => x.structuredPlug, 17)
            .Match(x => x.pinataLoot, 18)
            .Match(x => x.bindPoint, 19)
            .Match(x => x.player, 20)
            .Match(x => x.hidden, 21)
            .Match(x => x.trigger, 22)
            .Match(x => x.ghost, 23)
            .Match(x => x.pet, 24)
            .Match(x => x.esperPet, 25)
            .Match(x => x.worldUnit, 26)
            .Match(x => x.scannerUnit, 27)
            .Match(x => x.camera, 28)
            .Match(x => x.trap, 29)
            .Match(x => x.destructibledoor, 30)
            .Match(x => x.pickup, 31)
            .Match(x => x.simpleCollidable, 32))
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

  [Message(6152, 0x0164)]
  public record Message0164
  {
    public uint serverUniqueId { get; set; }
    public uint sourceUnitId { get; set; }
    public uint visualEffectId { get; set; }
    public uint timeElapsed { get; set; }
    public Structure015? sourceLocation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0164>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.sourceUnitId, 32)
        .Integer(x => x.visualEffectId, 32)
        .Integer(x => x.timeElapsed, 32)
        .Structure(x => x.sourceLocation);
    }
  }

  [Message(6152, 0x0165)]
  public record Message0165
  {
    public uint sourceUnitId { get; set; }
    public uint spell4VisualGroupId { get; set; }
    public uint timeElapsed { get; set; }
    public uint visualCount { get; set; }
    public uint[]? serverUniqueIdList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0165>()
        .Integer(x => x.sourceUnitId, 32)
        .Integer(x => x.spell4VisualGroupId, 32)
        .Integer(x => x.timeElapsed, 32)
        .Integer(x => x.visualCount, 32)
        .Array(x => x.serverUniqueIdList, x => x.visualCount).OfInteger(32);
    }
  }

  [Message(6152, 0x019E)]
  public record Message019E
  {
    public uint creatureId { get; set; }
    public string? text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message019E>()
        .Integer(x => x.creatureId, 32)
        .String(x => x.text, true);
    }
  }

  [Message(6152, 0x019F)]
  public record Message019F
  {
    public Structure015? a { get; set; }
    public Structure015? b { get; set; }
    public Structure015? c { get; set; }
    public Structure015? d { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message019F>()
        .Structure(x => x.a)
        .Structure(x => x.b)
        .Structure(x => x.c)
        .Structure(x => x.d);
    }
  }

  [Message(6152, 0x01A0)]
  public record Message01A0
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A0>();
    }
  }

  [Message(6152, 0x01A1)]
  public record Message01A1
  {
    public uint primId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A1>()
        .Integer(x => x.primId, 32);
    }
  }

  [Message(6152, 0x01A2)]
  public record Message01A2
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A2>();
    }
  }

  [Message(6152, 0x01A3)]
  public record Message01A3
  {
    public uint type { get; set; }
    public Structure0C9? color { get; set; }
    public uint primId { get; set; }
    public uint lifetime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A3>()
        .Integer(x => x.type, 5)
        .Structure(x => x.color)
        .Integer(x => x.primId, 32)
        .Integer(x => x.lifetime, 32);
    }
  }

  [Message(6152, 0x01A4)]
  public record Message01A4
  {
    public Structure0C9? color { get; set; }
    public Structure015? a { get; set; }
    public Structure015? b { get; set; }
    public Structure015? c { get; set; }
    public Structure015? d { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A4>()
        .Structure(x => x.color)
        .Structure(x => x.a)
        .Structure(x => x.b)
        .Structure(x => x.c)
        .Structure(x => x.d);
    }
  }

  [Message(6152, 0x01A5)]
  public record Message01A5
  {
    public string? gatherMode { get; set; }
    public uint runTime { get; set; }
    public uint totalTime { get; set; }
    public uint totalCalls { get; set; }
    public uint totalItems { get; set; }
    public uint count { get; set; }
    public Structure0CA[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A5>()
        .String(x => x.gatherMode, true)
        .Integer(x => x.runTime, 32)
        .Integer(x => x.totalTime, 32)
        .Integer(x => x.totalCalls, 32)
        .Integer(x => x.totalItems, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.items, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x01A6)]
  public record Message01A6
  {
    public uint unitId { get; set; }
    public uint drawMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A6>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.drawMode, 2);
    }
  }

  [Message(6152, 0x01A7)]
  public record Message01A7
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A7>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x01A8)]
  public record Message01A8
  {
    public uint unitId { get; set; }
    public Structure015? position { get; set; }
    public Structure015? direction { get; set; }
    public float time { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A8>()
        .Integer(x => x.unitId, 32)
        .Structure(x => x.position)
        .Structure(x => x.direction)
        .Float(x => x.time);
    }
  }

  [Message(6152, 0x01A9)]
  public record Message01A9
  {
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01A9>()
        .Integer(x => x.characterId, 64);
    }
  }

  [Message(6152, 0x01AB)]
  public record Message01AB
  {
    public uint realmId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01AB>()
        .Integer(x => x.realmId, 32);
    }
  }

  [Message(6152, 0x01AC)]
  public record Message01AC
  {
    public uint unitId { get; set; }
    public uint wasDestroyed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01AC>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.wasDestroyed, 1);
    }
  }

  [Message(6152, 0x01AD)]
  public record Message01AD
  {
    public uint m_achievementId { get; set; }
    public uint m_value00 { get; set; }
    public uint m_value01 { get; set; }
    public ulong m_dateCompleted { get; set; }
    public uint m_deleted { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01AD>()
        .Integer(x => x.m_achievementId, 32)
        .Integer(x => x.m_value00, 32)
        .Integer(x => x.m_value01, 32)
        .Integer(x => x.m_dateCompleted, 64)
        .Integer(x => x.m_deleted, 1);
    }
  }

  [Message(6152, 0x01AE)]
  public record Message01AE
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01AE>();
    }
  }

  [Message(6152, 0x01AF)]
  public record Message01AF
  {
    public uint m_target { get; set; }
    public uint m_isCommunique { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01AF>()
        .Integer(x => x.m_target, 32)
        .Integer(x => x.m_isCommunique, 1);
    }
  }

  [Message(6152, 0x01B0)]
  public record Message01B0
  {
    public uint m_target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B0>()
        .Integer(x => x.m_target, 32);
    }
  }

  [Message(6152, 0x01B1)]
  public record Message01B1
  {
    public uint m_event { get; set; }
    public uint m_argCount { get; set; }
    public Structure047[]? m_args { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B1>()
        .Integer(x => x.m_event, 32)
        .Integer(x => x.m_argCount, 32)
        .Array(x => x.m_args, x => x.m_argCount).OfStructure();
    }
  }

  [Message(6152, 0x01B2)]
  public record Message01B2
  {
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B2>()
        .Integer(x => x.m_questId, 32);
    }
  }

  [Message(6152, 0x01B3)]
  public record Message01B3
  {
    public Structure034? m_location { get; set; }
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B3>()
        .Structure(x => x.m_location)
        .Integer(x => x.m_questId, 32);
    }
  }

  [Message(6152, 0x01B4)]
  public record Message01B4
  {
    public uint m_id { get; set; }
    public uint m_state { get; set; }
    public uint m_randomResultId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B4>()
        .Integer(x => x.m_id, 32)
        .Integer(x => x.m_state, 32)
        .Integer(x => x.m_randomResultId, 32);
    }
  }

  [Message(6152, 0x01B5)]
  public record Message01B5
  {
    public uint m_questId { get; set; }
    public uint m_rewardSelection { get; set; }
    public uint m_isCommunique { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B5>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_rewardSelection, 32)
        .Integer(x => x.m_isCommunique, 1);
    }
  }

  [Message(6152, 0x01B6)]
  public record Message01B6
  {
    public uint m_dailyRandomSeed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B6>()
        .Integer(x => x.m_dailyRandomSeed, 32);
    }
  }

  [Message(6152, 0x01B7)]
  public record Message01B7
  {
    public uint m_questId { get; set; }
    public uint m_bIgnored { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B7>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_bIgnored, 1);
    }
  }

  [Message(6152, 0x01B8)]
  public record Message01B8
  {
    public uint m_completedCount { get; set; }
    public Structure044[]? m_completed { get; set; }
    public uint m_inactiveCount { get; set; }
    public Structure045[]? m_inactive { get; set; }
    public uint m_activeCount { get; set; }
    public Structure046[]? m_active { get; set; }
    public uint m_periodicCount { get; set; }
    public uint[]? m_periodic { get; set; }
    public uint m_dailyRandomSeed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B8>()
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

  [Message(6152, 0x01B9)]
  public record Message01B9
  {
    public uint m_questId { get; set; }
    public uint m_bMentioned { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01B9>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_bMentioned, 1);
    }
  }

  [Message(6152, 0x01BA)]
  public record Message01BA
  {
    public uint m_questId { get; set; }
    public uint m_index { get; set; }
    public uint m_completed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01BA>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_index, 32)
        .Integer(x => x.m_completed, 32);
    }
  }

  [Message(6152, 0x01BB)]
  public record Message01BB
  {
    public uint m_sharer { get; set; }
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01BB>()
        .Integer(x => x.m_sharer, 32)
        .Integer(x => x.m_questId, 32);
    }
  }

  [Message(6152, 0x01BC)]
  public record Message01BC
  {
    public uint m_questId { get; set; }
    public uint m_bTracked { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01BC>()
        .Integer(x => x.m_questId, 32)
        .Integer(x => x.m_bTracked, 1);
    }
  }

  [Message(6152, 0x01BD)]
  public record Message01BD
  {
    public uint m_questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01BD>()
        .Integer(x => x.m_questId, 32);
    }
  }

  [Message(6152, 0x01C0)]
  public record Message01C0
  {
    public uint eventId { get; set; }
    public uint deleting { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01C0>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.deleting, 1);
    }
  }

  [Message(6152, 0x01CB)]
  public record Message01CB
  {
    public uint emotesId { get; set; }
    public uint seed { get; set; }
    public uint targetUnitId { get; set; }
    public uint targeted { get; set; }
    public uint silent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01CB>()
        .Integer(x => x.emotesId, 32)
        .Integer(x => x.seed, 32)
        .Integer(x => x.targetUnitId, 32)
        .Integer(x => x.targeted, 1)
        .Integer(x => x.silent, 1);
    }
  }

  [Message(6152, 0x01CC)]
  public record Message01CC
  {
    public uint emotesId { get; set; }
    public uint seed { get; set; }
    public uint sourceUnitId { get; set; }
    public uint targetUnitId { get; set; }
    public uint targeted { get; set; }
    public uint silent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01CC>()
        .Integer(x => x.emotesId, 32)
        .Integer(x => x.seed, 32)
        .Integer(x => x.sourceUnitId, 32)
        .Integer(x => x.targetUnitId, 32)
        .Integer(x => x.targeted, 1)
        .Integer(x => x.silent, 1);
    }
  }

  [Message(6152, 0x01D3)]
  public record Message01D3
  {
    public Structure02A? identity { get; set; }
    public uint type { get; set; }
    public string? note { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D3>()
        .Structure(x => x.identity)
        .Integer(x => x.type, 3)
        .String(x => x.note, true);
    }
  }

  [Message(6152, 0x01D4)]
  public record Message01D4
  {
    public string? characterName { get; set; }
    public string? realmName { get; set; }
    public uint type { get; set; }
    public string? note { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D4>()
        .String(x => x.characterName, true)
        .String(x => x.realmName, true)
        .Integer(x => x.type, 3)
        .String(x => x.note, true);
    }
  }

  [Message(6152, 0x01D5)]
  public record Message01D5
  {
    public Structure0B9? friendship { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D5>()
        .Structure(x => x.friendship);
    }
  }

  [Message(6152, 0x01D8)]
  public record Message01D8
  {
    public ushort friendCount { get; set; }
    public Structure0B9[]? friendships { get; set; }
    public uint friendLocked { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D8>()
        .Integer(x => x.friendCount, 16)
        .Array(x => x.friendships, x => x.friendCount).OfStructure()
        .Integer(x => x.friendLocked, 1);
    }
  }

  [Message(6152, 0x01D9)]
  public record Message01D9
  {
    public byte count { get; set; }
    public Structure02A[]? identities { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01D9>()
        .Integer(x => x.count, 8)
        .Array(x => x.identities, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x01DA)]
  public record Message01DA
  {
    public byte count { get; set; }
    public ulong[]? friendshipIds { get; set; }
    public uint[]? worldZoneIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DA>()
        .Integer(x => x.count, 8)
        .Array(x => x.friendshipIds, x => x.count).OfInteger(64)
        .Array(x => x.worldZoneIds, x => x.count).OfInteger(32);
    }
  }

  [Message(6152, 0x01DB)]
  public record Message01DB
  {
    public Structure02A? identity { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DB>()
        .Structure(x => x.identity)
        .Integer(x => x.type, 3);
    }
  }

  [Message(6152, 0x01DC)]
  public record Message01DC
  {
    public string? characterName { get; set; }
    public string? realmName { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DC>()
        .String(x => x.characterName, true)
        .String(x => x.realmName, true)
        .Integer(x => x.type, 3);
    }
  }

  [Message(6152, 0x01DD)]
  public record Message01DD
  {
    public ulong friendshipId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DD>()
        .Integer(x => x.friendshipId, 64);
    }
  }

  [Message(6152, 0x01DE)]
  public record Message01DE
  {
    public Structure02A? identity { get; set; }
    public string? name { get; set; }
    public uint classId { get; set; }
    public uint path { get; set; }
    public byte level { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DE>()
        .Structure(x => x.identity)
        .String(x => x.name, true)
        .Integer(x => x.classId, 5)
        .Integer(x => x.path, 3)
        .Integer(x => x.level, 8);
    }
  }

  [Message(6152, 0x01DF)]
  public record Message01DF
  {
    public Structure02A? identity { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01DF>()
        .Structure(x => x.identity)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6152, 0x01E0)]
  public record Message01E0
  {
    public Structure02A? identity { get; set; }
    public uint response { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E0>()
        .Structure(x => x.identity)
        .Integer(x => x.response, 3);
    }
  }

  [Message(6152, 0x01E1)]
  public record Message01E1
  {
    public string? name { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E1>()
        .String(x => x.name, true)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6152, 0x01E2)]
  public record Message01E2
  {
    public Structure02A? identity { get; set; }
    public uint level { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E2>()
        .Structure(x => x.identity)
        .Integer(x => x.level, 32);
    }
  }

  [Message(6152, 0x01E3)]
  public record Message01E3
  {
    public Structure02A? identity { get; set; }
    public string? note { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E3>()
        .Structure(x => x.identity)
        .String(x => x.note, true);
    }
  }

  [Message(6152, 0x01E4)]
  public record Message01E4
  {
    public string? characterName { get; set; }
    public string? realmName { get; set; }
    public string? note { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E4>()
        .String(x => x.characterName, true)
        .String(x => x.realmName, true)
        .String(x => x.note, true);
    }
  }

  [Message(6152, 0x01E5)]
  public record Message01E5
  {
    public ulong friendshipId { get; set; }
    public string? note { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E5>()
        .Integer(x => x.friendshipId, 64)
        .String(x => x.note, true);
    }
  }

  [Message(6152, 0x01E6)]
  public record Message01E6
  {
    public Structure02A? identity { get; set; }
    public float lastOnline { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E6>()
        .Structure(x => x.identity)
        .Float(x => x.lastOnline);
    }
  }

  [Message(6152, 0x01E7)]
  public record Message01E7
  {
    public ulong friendshipId { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01E7>()
        .Integer(x => x.friendshipId, 64)
        .Integer(x => x.type, 3);
    }
  }

  [Message(6152, 0x01EB)]
  public record Message01EB
  {
    public Structure012? gatewayAddress { get; set; }
    public byte[]? gatewayTicket { get; set; }
    public uint accountId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01EB>()
        .Structure(x => x.gatewayAddress)
        .Array(x => x.gatewayTicket, 16).Aligned(true).OfInteger(8)
        .Integer(x => x.accountId, 32);
    }
  }

  [Message(6152, 0x01EE)]
  public record Message01EE
  {
    public string? cheatString { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01EE>()
        .String(x => x.cheatString, true);
    }
  }

  [Message(6152, 0x01EF)]
  public record Message01EF
  {
    public string? debugString { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01EF>()
        .String(x => x.debugString, true);
    }
  }

  [Message(6152, 0x01F0)]
  public record Message01F0
  {
    public string? titleString { get; set; }
    public string? messageString { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F0>()
        .String(x => x.titleString, true)
        .String(x => x.messageString, true);
    }
  }

  [Message(6152, 0x01F1)]
  public record Message01F1
  {
    public uint itemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F1>()
        .Integer(x => x.itemId, 32);
    }
  }

  [Message(6152, 0x01F2)]
  public record Message01F2
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F2>();
    }
  }

  [Message(6152, 0x01F3)]
  public record Message01F3
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F3>();
    }
  }

  [Message(6152, 0x01F4)]
  public record Message01F4
  {
    public string? commandString { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F4>()
        .String(x => x.commandString, true);
    }
  }

  [Message(6152, 0x01F5)]
  public record Message01F5
  {
    public ulong groupId { get; set; }
    public Structure02B? member { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F5>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.member);
    }
  }

  [Message(6152, 0x01F7)]
  public record Message01F7
  {
    public ulong groupId { get; set; }
    public uint groupFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F7>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.groupFlags, 32);
    }
  }

  [Message(6152, 0x01F9)]
  public record Message01F9
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }
    public uint memberFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01F9>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.memberFlags, 32);
    }
  }

  [Message(6152, 0x01FB)]
  public record Message01FB
  {
    public uint portalUnitId { get; set; }
    public Structure02A? identity { get; set; }
    public uint available { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01FB>()
        .Integer(x => x.portalUnitId, 32)
        .Structure(x => x.identity)
        .Integer(x => x.available, 1);
    }
  }

  [Message(6152, 0x01FC)]
  public record Message01FC
  {
    public ulong groupId { get; set; }
    public uint realmId { get; set; }
    public uint worldId { get; set; }
    public uint portalUnitId { get; set; }
    public Structure02A? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message01FC>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.realmId, 32)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.portalUnitId, 32)
        .Structure(x => x.identity);
    }
  }

  [Message(6152, 0x0200)]
  public record Message0200
  {
    public ulong groupId { get; set; }
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0200>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6152, 0x0201)]
  public record Message0201
  {
    public ulong groupId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0201>()
        .Integer(x => x.groupId, 64);
    }
  }

  [Message(6152, 0x0202)]
  public record Message0202
  {
    public ulong groupId { get; set; }
    public uint worldDifficulty { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0202>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.worldDifficulty, 2);
    }
  }

  [Message(6152, 0x0204)]
  public record Message0204
  {
    public ulong groupId { get; set; }
    public uint worldGameMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0204>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.worldGameMode, 3);
    }
  }

  [Message(6152, 0x0206)]
  public record Message0206
  {
    public ulong groupId { get; set; }
    public uint worldDifficulty { get; set; }
    public uint worldGameMode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0206>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.worldDifficulty, 2)
        .Integer(x => x.worldGameMode, 3);
    }
  }

  [Message(6152, 0x0208)]
  public record Message0208
  {
    public ulong groupId { get; set; }
    public string? inviteeName { get; set; }
    public string? inviteeRealm { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0208>()
        .Integer(x => x.groupId, 64)
        .String(x => x.inviteeName, true)
        .String(x => x.inviteeRealm, true);
    }
  }

  [Message(6152, 0x020C)]
  public record Message020C
  {
    public ulong inviteId { get; set; }
    public uint accept { get; set; }
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message020C>()
        .Integer(x => x.inviteId, 64)
        .Integer(x => x.accept, 1)
        .Integer(x => x.role, 32);
    }
  }

  [Message(6152, 0x020E)]
  public record Message020E
  {
    public ulong inviteId { get; set; }
    public string? name { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message020E>()
        .Integer(x => x.inviteId, 64)
        .String(x => x.name, true)
        .Integer(x => x.result, 4);
    }
  }

  [Message(6152, 0x0210)]
  public record Message0210
  {
    public ulong inviteId { get; set; }
    public Structure02D? inviteStats { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0210>()
        .Integer(x => x.inviteId, 64)
        .Structure(x => x.inviteStats);
    }
  }

  [Message(6152, 0x0212)]
  public record Message0212
  {
    public Structure02A? identity { get; set; }
    public Structure02E? group { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0212>()
        .Structure(x => x.identity)
        .Structure(x => x.group);
    }
  }

  [Message(6152, 0x0213)]
  public record Message0213
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0213>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity);
    }
  }

  [Message(6152, 0x0215)]
  public record Message0215
  {
    public uint referenceType { get; set; }
    public uint referenceId { get; set; }
    public uint joinPhaseAllowed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0215>()
        .Integer(x => x.referenceType, 32)
        .Integer(x => x.referenceId, 32)
        .Integer(x => x.joinPhaseAllowed, 1);
    }
  }

  [Message(6152, 0x0216)]
  public record Message0216
  {
    public ulong groupId { get; set; }
    public uint disband { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0216>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.disband, 1);
    }
  }

  [Message(6152, 0x0218)]
  public record Message0218
  {
    public ulong groupId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0218>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.reason, 3);
    }
  }

  [Message(6152, 0x0219)]
  public record Message0219
  {
    public ulong groupId { get; set; }
    public uint normalRule { get; set; }
    public uint thresholdRule { get; set; }
    public uint thresholdQuality { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0219>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.normalRule, 3)
        .Integer(x => x.thresholdRule, 3)
        .Integer(x => x.thresholdQuality, 4);
    }
  }

  [Message(6152, 0x021A)]
  public record Message021A
  {
    public ulong groupId { get; set; }
    public uint normalRule { get; set; }
    public uint thresholdRule { get; set; }
    public uint thresholdQuality { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message021A>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.normalRule, 3)
        .Integer(x => x.thresholdRule, 3)
        .Integer(x => x.thresholdQuality, 4);
    }
  }

  [Message(6152, 0x021C)]
  public record Message021C
  {
    public ulong groupId { get; set; }
    public Structure02F? markers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message021C>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.markers);
    }
  }

  [Message(6152, 0x021D)]
  public record Message021D
  {
    public uint markerId { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message021D>()
        .Integer(x => x.markerId, 32)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x0220)]
  public record Message0220
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }
    public uint flags { get; set; }
    public uint isFromPromotion { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0220>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.flags, 32)
        .Integer(x => x.isFromPromotion, 1);
    }
  }

  [Message(6152, 0x0222)]
  public record Message0222
  {
    public ulong groupId { get; set; }
    public Structure02A? mentorIdentity { get; set; }
    public Structure02A? menteeIdentity { get; set; }
    public uint bCancelMentoring { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0222>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.mentorIdentity)
        .Structure(x => x.menteeIdentity)
        .Integer(x => x.bCancelMentoring, 1);
    }
  }

  [Message(6152, 0x0225)]
  public record Message0225
  {
    public ulong groupId { get; set; }
    public Structure02A? mentorIdentity { get; set; }
    public Structure02A? menteeIdentity { get; set; }
    public uint bCancelMentoring { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0225>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.mentorIdentity)
        .Structure(x => x.menteeIdentity)
        .Integer(x => x.bCancelMentoring, 1);
    }
  }

  [Message(6152, 0x0227)]
  public record Message0227
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0227>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6152, 0x022A)]
  public record Message022A
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message022A>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity);
    }
  }

  [Message(6152, 0x022B)]
  public record Message022B
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message022B>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity);
    }
  }

  [Message(6152, 0x022D)]
  public record Message022D
  {
    public ulong groupId { get; set; }
    public string? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message022D>()
        .Integer(x => x.groupId, 64)
        .String(x => x.message, true);
    }
  }

  [Message(6152, 0x022F)]
  public record Message022F
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }
    public string? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message022F>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .String(x => x.message, true);
    }
  }

  [Message(6152, 0x0231)]
  public record Message0231
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0231>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.reason, 3);
    }
  }

  [Message(6152, 0x0233)]
  public record Message0233
  {
    public Structure02A? identity { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0233>()
        .Structure(x => x.identity)
        .Structure(x => x.position);
    }
  }

  [Message(6152, 0x0234)]
  public record Message0234
  {
    public Structure02A? identity { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0234>()
        .Structure(x => x.identity)
        .Structure(x => x.position);
    }
  }

  [Message(6152, 0x0235)]
  public record Message0235
  {
    public ulong groupId { get; set; }
    public uint markerId { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0235>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.markerId, 32)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x0236)]
  public record Message0236
  {
    public uint questId { get; set; }
    public uint accept { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0236>()
        .Integer(x => x.questId, 32)
        .Integer(x => x.accept, 1);
    }
  }

  [Message(6152, 0x0237)]
  public record Message0237
  {
    public uint questId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0237>()
        .Integer(x => x.questId, 32);
    }
  }

  [Message(6152, 0x0238)]
  public record Message0238
  {
    public uint questId { get; set; }
    public uint role { get; set; }
    public uint result { get; set; }
    public uint context { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0238>()
        .Integer(x => x.questId, 32)
        .Integer(x => x.role, 32)
        .Integer(x => x.result, 32)
        .Integer(x => x.context, 32);
    }
  }

  [Message(6152, 0x0239)]
  public record Message0239
  {
    public uint questId { get; set; }
    public uint role { get; set; }
    public uint result { get; set; }
    public uint context { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0239>()
        .Integer(x => x.questId, 32)
        .Integer(x => x.role, 32)
        .Integer(x => x.result, 32)
        .Integer(x => x.context, 32);
    }
  }

  [Message(6152, 0x023A)]
  public record Message023A
  {
    public ulong groupId { get; set; }
    public uint size { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message023A>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.size, 32);
    }
  }

  [Message(6152, 0x023C)]
  public record Message023C
  {
    public ulong groupId { get; set; }
    public Structure02A? identity { get; set; }
    public uint level { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message023C>()
        .Integer(x => x.groupId, 64)
        .Structure(x => x.identity)
        .Integer(x => x.level, 32);
    }
  }

  [Message(6152, 0x023D)]
  public record Message023D
  {
    public ulong groupId { get; set; }
    public uint worldId { get; set; }
    public uint count { get; set; }
    public Structure02A[]? identity { get; set; }
    public Structure015[]? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message023D>()
        .Integer(x => x.groupId, 64)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.identity, x => x.count).OfStructure()
        .Array(x => x.position, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x0240)]
  public record Message0240
  {
    public Structure04F? guild { get; set; }
    public Structure036? item { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0240>()
        .Structure(x => x.guild)
        .Structure(x => x.item);
    }
  }

  [Message(6152, 0x0241)]
  public record Message0241
  {
    public Structure04F? guild { get; set; }
    public ulong characterItemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0241>()
        .Structure(x => x.guild)
        .Integer(x => x.characterItemId, 64);
    }
  }

  [Message(6152, 0x0242)]
  public record Message0242
  {
    public Structure053? guild { get; set; }
    public Structure057? item { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0242>()
        .Structure(x => x.guild)
        .Structure(x => x.item);
    }
  }

  [Message(6152, 0x0244)]
  public record Message0244
  {
    public Structure053? guild { get; set; }
    public ulong characterItemIdGuild { get; set; }
    public uint itemIdGuild { get; set; }
    public Structure034? locationTo { get; set; }
    public Structure034? locationFrom { get; set; }
    public uint stackCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0244>()
        .Structure(x => x.guild)
        .Integer(x => x.characterItemIdGuild, 64)
        .Integer(x => x.itemIdGuild, 32)
        .Structure(x => x.locationTo)
        .Structure(x => x.locationFrom)
        .Integer(x => x.stackCount, 32);
    }
  }

  [Message(6152, 0x0247)]
  public record Message0247
  {
    public Structure04F? guild { get; set; }
    public ulong characterItemId { get; set; }
    public uint stackCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0247>()
        .Structure(x => x.guild)
        .Integer(x => x.characterItemId, 64)
        .Integer(x => x.stackCount, 32);
    }
  }

  [Message(6152, 0x0248)]
  public record Message0248
  {
    public Structure053? guild { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0248>()
        .Structure(x => x.guild);
    }
  }

  [Message(6152, 0x024A)]
  public record Message024A
  {
    public Structure053? guild { get; set; }
    public uint location { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message024A>()
        .Structure(x => x.guild)
        .Integer(x => x.location, 8);
    }
  }

  [Message(6152, 0x024B)]
  public record Message024B
  {
    public Structure04F? guild { get; set; }
    public uint bankTabCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message024B>()
        .Structure(x => x.guild)
        .Integer(x => x.bankTabCount, 32);
    }
  }

  [Message(6152, 0x024C)]
  public record Message024C
  {
    public Structure04F? guild { get; set; }
    public string[]? bankTabName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message024C>()
        .Structure(x => x.guild)
        .Array(x => x.bankTabName, 10).OfString(true);
    }
  }

  [Message(6152, 0x024D)]
  public record Message024D
  {
    public Structure04F? guild { get; set; }
    public uint location { get; set; }
    public uint count { get; set; }
    public Structure036[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message024D>()
        .Structure(x => x.guild)
        .Integer(x => x.location, 8)
        .Integer(x => x.count, 32)
        .Array(x => x.items, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x024F)]
  public record Message024F
  {
    public uint unitId { get; set; }
    public Structure051? create { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message024F>()
        .Integer(x => x.unitId, 32)
        .Structure(x => x.create);
    }
  }

  [Message(6152, 0x0252)]
  public record Message0252
  {
    public Structure04F? guild { get; set; }
    public Structure052? emblem { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0252>()
        .Structure(x => x.guild)
        .Structure(x => x.emblem);
    }
  }

  [Message(6152, 0x0254)]
  public record Message0254
  {
    public Structure04F? guild { get; set; }
    public uint flags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0254>()
        .Structure(x => x.guild)
        .Integer(x => x.flags, 32);
    }
  }

  [Message(6152, 0x0256)]
  public record Message0256
  {
    public Structure04F? guild { get; set; }
    public uint influence { get; set; }
    public ulong money { get; set; }
    public uint warCoins { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0256>()
        .Structure(x => x.guild)
        .Integer(x => x.influence, 32)
        .Integer(x => x.money, 64)
        .Integer(x => x.warCoins, 32);
    }
  }

  [Message(6152, 0x0258)]
  public record Message0258
  {
    public uint accept { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0258>()
        .Integer(x => x.accept, 1);
    }
  }

  [Message(6152, 0x0259)]
  public record Message0259
  {
    public string? who { get; set; }
    public string? guild { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0259>()
        .String(x => x.who, true)
        .String(x => x.guild, true)
        .Integer(x => x.type, 3);
    }
  }

  [Message(6152, 0x025A)]
  public record Message025A
  {
    public Structure058? guild { get; set; }
    public Structure05B? self { get; set; }
    public Structure05C? selfPrivate { get; set; }
    public uint nameplate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message025A>()
        .Structure(x => x.guild)
        .Structure(x => x.self)
        .Structure(x => x.selfPrivate)
        .Integer(x => x.nameplate, 1);
    }
  }

  [Message(6152, 0x025C)]
  public record Message025C
  {
    public Structure04F? guild { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message025C>()
        .Structure(x => x.guild);
    }
  }

  [Message(6152, 0x025E)]
  public record Message025E
  {
    public uint count { get; set; }
    public uint nameplateIndex { get; set; }
    public Structure058[]? guilds { get; set; }
    public Structure05B[]? self { get; set; }
    public Structure05C[]? selfPrivate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message025E>()
        .Integer(x => x.count, 32)
        .Integer(x => x.nameplateIndex, 32)
        .Array(x => x.guilds, x => x.count).OfStructure()
        .Array(x => x.self, x => x.count).OfStructure()
        .Array(x => x.selfPrivate, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x0260)]
  public record Message0260
  {
    public Structure04F? guild { get; set; }
    public uint count { get; set; }
    public Structure05B[]? members { get; set; }
    public uint done { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0260>()
        .Structure(x => x.guild)
        .Integer(x => x.count, 32)
        .Array(x => x.members, x => x.count).OfStructure()
        .Integer(x => x.done, 1);
    }
  }

  [Message(6152, 0x0261)]
  public record Message0261
  {
    public Structure04F? guild { get; set; }
    public Structure05C? selfPrivate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0261>()
        .Structure(x => x.guild)
        .Structure(x => x.selfPrivate);
    }
  }

  [Message(6152, 0x0262)]
  public record Message0262
  {
    public Structure04F? guild { get; set; }
    public Structure02A? identity { get; set; }
    public ushort memberCount { get; set; }
    public ushort onlineMemberCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0262>()
        .Structure(x => x.guild)
        .Structure(x => x.identity)
        .Integer(x => x.memberCount, 16)
        .Integer(x => x.onlineMemberCount, 16);
    }
  }

  [Message(6152, 0x0263)]
  public record Message0263
  {
    public Structure04F? guild { get; set; }
    public Structure05B? member { get; set; }
    public ushort memberCount { get; set; }
    public ushort onlineMemberCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0263>()
        .Structure(x => x.guild)
        .Structure(x => x.member)
        .Integer(x => x.memberCount, 16)
        .Integer(x => x.onlineMemberCount, 16);
    }
  }

  [Message(6152, 0x0264)]
  public record Message0264
  {
    public Structure053? guild { get; set; }
    public Structure054? modify { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0264>()
        .Structure(x => x.guild)
        .Structure(x => x.modify);
    }
  }

  [Message(6152, 0x0266)]
  public record Message0266
  {
    public Structure053? guild { get; set; }
    public ulong moneyFromGuild { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0266>()
        .Structure(x => x.guild)
        .Integer(x => x.moneyFromGuild, 64);
    }
  }

  [Message(6152, 0x026A)]
  public record Message026A
  {
    public Structure04F? guild { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message026A>()
        .Structure(x => x.guild);
    }
  }

  [Message(6152, 0x026C)]
  public record Message026C
  {
    public uint unitId { get; set; }
    public string? guildName { get; set; }
    public uint type { get; set; }
    public Structure052? emblem { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message026C>()
        .Integer(x => x.unitId, 32)
        .String(x => x.guildName, true)
        .Integer(x => x.type, 3)
        .Structure(x => x.emblem);
    }
  }

  [Message(6152, 0x026D)]
  public record Message026D
  {
    public Structure04F? guild { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message026D>()
        .Structure(x => x.guild)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x026F)]
  public record Message026F
  {
    public Structure04F? guild { get; set; }
    public Structure050? operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message026F>()
        .Structure(x => x.guild)
        .Structure(x => x.operation);
    }
  }

  [Message(6152, 0x0270)]
  public record Message0270
  {
    public Structure04F? guild { get; set; }
    public Structure050? operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0270>()
        .Structure(x => x.guild)
        .Structure(x => x.operation);
    }
  }

  [Message(6152, 0x0271)]
  public record Message0271
  {
    public Structure053? guild { get; set; }
    public Structure050? operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0271>()
        .Structure(x => x.guild)
        .Structure(x => x.operation);
    }
  }

  [Message(6152, 0x0273)]
  public record Message0273
  {
    public Structure04F? guild { get; set; }
    public Structure05A? activePerk { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0273>()
        .Structure(x => x.guild)
        .Structure(x => x.activePerk);
    }
  }

  [Message(6152, 0x0276)]
  public record Message0276
  {
    public Structure04F? guild { get; set; }
    public uint guildPerkId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0276>()
        .Structure(x => x.guild)
        .Integer(x => x.guildPerkId, 32);
    }
  }

  [Message(6152, 0x0278)]
  public record Message0278
  {
    public Structure04F? guild { get; set; }
    public uint guildPerkId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0278>()
        .Structure(x => x.guild)
        .Integer(x => x.guildPerkId, 32);
    }
  }

  [Message(6152, 0x027B)]
  public record Message027B
  {
    public Structure04F? guild { get; set; }
    public uint pvpWins { get; set; }
    public uint pvpLosses { get; set; }
    public uint pvpDraws { get; set; }
    public uint pvpRating { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message027B>()
        .Structure(x => x.guild)
        .Integer(x => x.pvpWins, 32)
        .Integer(x => x.pvpLosses, 32)
        .Integer(x => x.pvpDraws, 32)
        .Integer(x => x.pvpRating, 32);
    }
  }

  [Message(6152, 0x027C)]
  public record Message027C
  {
    public Structure04F? guild { get; set; }
    public Structure059[]? ranks { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message027C>()
        .Structure(x => x.guild)
        .Array(x => x.ranks, 10).OfStructure();
    }
  }

  [Message(6152, 0x027E)]
  public record Message027E
  {
    public Structure04F? guild { get; set; }
    public uint rank { get; set; }
    public string? who { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message027E>()
        .Structure(x => x.guild)
        .Integer(x => x.rank, 32)
        .String(x => x.who, true)
        .Integer(x => x.result, 7);
    }
  }

  [Message(6152, 0x027F)]
  public record Message027F
  {
    public Structure04F? guild { get; set; }
    public uint rank { get; set; }
    public string? who { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message027F>()
        .Structure(x => x.guild)
        .Integer(x => x.rank, 32)
        .String(x => x.who, true)
        .Integer(x => x.result, 7);
    }
  }

  [Message(6152, 0x0280)]
  public record Message0280
  {
    public Structure053? guild { get; set; }
    public Structure055? standard { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0280>()
        .Structure(x => x.guild)
        .Structure(x => x.standard);
    }
  }

  [Message(6152, 0x0281)]
  public record Message0281
  {
    public Structure04F? guild { get; set; }
    public Structure055? standard { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0281>()
        .Structure(x => x.guild)
        .Structure(x => x.standard);
    }
  }

  [Message(6152, 0x0284)]
  public record Message0284
  {
    public uint unitId { get; set; }
    public byte guildCount { get; set; }
    public ulong[]? guildIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0284>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.guildCount, 8)
        .Array(x => x.guildIds, x => x.guildCount).OfInteger(64);
    }
  }

  [Message(6152, 0x0288)]
  public record Message0288
  {
    public uint count { get; set; }
    public Structure0BB[]? decors { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0288>()
        .Integer(x => x.count, 32)
        .Array(x => x.decors, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x0289)]
  public record Message0289
  {
    public uint count { get; set; }
    public Structure0BE[]? residences { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0289>()
        .Integer(x => x.count, 32)
        .Array(x => x.residences, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x028B)]
  public record Message028B
  {
    public ulong residenceId { get; set; }
    public Structure0BF? plotList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message028B>()
        .Integer(x => x.residenceId, 64)
        .Structure(x => x.plotList);
    }
  }

  [Message(6152, 0x028F)]
  public record Message028F
  {
    public ulong decorId { get; set; }
    public uint operation { get; set; }
    public float posX { get; set; }
    public float posY { get; set; }
    public float posZ { get; set; }
    public float orientX { get; set; }
    public float orientY { get; set; }
    public float orientZ { get; set; }
    public float orientW { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message028F>()
        .Integer(x => x.decorId, 64)
        .Integer(x => x.operation, 3)
        .Float(x => x.posX)
        .Float(x => x.posY)
        .Float(x => x.posZ)
        .Float(x => x.orientX)
        .Float(x => x.orientY)
        .Float(x => x.orientZ)
        .Float(x => x.orientW);
    }
  }

  [Message(6152, 0x0290)]
  public record Message0290
  {
    public ulong uniqueItemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0290>()
        .Integer(x => x.uniqueItemId, 64);
    }
  }

  [Message(6152, 0x0292)]
  public record Message0292
  {
    public uint housingNeighborhoodType { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0292>()
        .Integer(x => x.housingNeighborhoodType, 2)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x0296)]
  public record Message0296
  {
    public Structure0BD? neighborhood { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0296>()
        .Structure(x => x.neighborhood);
    }
  }

  [Message(6152, 0x0297)]
  public record Message0297
  {
    public ulong neighborhood { get; set; }
    public ulong residenceId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0297>()
        .Integer(x => x.neighborhood, 64)
        .Integer(x => x.residenceId, 64);
    }
  }

  [Message(6152, 0x0299)]
  public record Message0299
  {
    public uint realmId { get; set; }
    public uint count { get; set; }
    public Structure0BD[]? neighborhoods { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0299>()
        .Integer(x => x.realmId, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.neighborhoods, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x029A)]
  public record Message029A
  {
    public uint count { get; set; }
    public Structure0C2[]? neighbors { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message029A>()
        .Integer(x => x.count, 32)
        .Array(x => x.neighbors, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x029B)]
  public record Message029B
  {
    public uint count { get; set; }
    public Structure0C1[]? plugItems { get; set; }
    public uint listType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message029B>()
        .Integer(x => x.count, 32)
        .Array(x => x.plugItems, x => x.count).OfStructure()
        .Integer(x => x.listType, 2);
    }
  }

  [Message(6152, 0x029C)]
  public record Message029C
  {
    public ulong residenceId { get; set; }
    public uint wallpaperId { get; set; }
    public uint roofDecorInfoId { get; set; }
    public uint entrywayDecorInfoId { get; set; }
    public uint doorDecorInfoId { get; set; }
    public uint operation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message029C>()
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.wallpaperId, 32)
        .Integer(x => x.roofDecorInfoId, 32)
        .Integer(x => x.entrywayDecorInfoId, 32)
        .Integer(x => x.doorDecorInfoId, 32)
        .Integer(x => x.operation, 3);
    }
  }

  [Message(6152, 0x029D)]
  public record Message029D
  {
    public uint operation { get; set; }
    public Structure0BB? decor { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message029D>()
        .Integer(x => x.operation, 3)
        .Structure(x => x.decor);
    }
  }

  [Message(6152, 0x029F)]
  public record Message029F
  {
    public Structure0BC[]? wallpapers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message029F>()
        .Array(x => x.wallpapers, 4).OfStructure();
    }
  }

  [Message(6152, 0x02A1)]
  public record Message02A1
  {
    public uint plotInfo { get; set; }
    public ulong residenceId { get; set; }
    public uint plugItem { get; set; }
    public uint plotFlags { get; set; }
    public uint operation { get; set; }
    public Structure0BA[]? housingContributions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A1>()
        .Integer(x => x.plotInfo, 32)
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.plugItem, 32)
        .Integer(x => x.plotFlags, 32)
        .Integer(x => x.operation, 3)
        .Array(x => x.housingContributions, 5).OfStructure();
    }
  }

  [Message(6152, 0x02A2)]
  public record Message02A2
  {
    public Structure02A? targetPlayerIdentity { get; set; }
    public string? targetPlayerName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A2>()
        .Structure(x => x.targetPlayerIdentity)
        .String(x => x.targetPlayerName, true);
    }
  }

  [Message(6152, 0x02A3)]
  public record Message02A3
  {
    public uint accepted { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A3>()
        .Integer(x => x.accepted, 1);
    }
  }

  [Message(6152, 0x02A4)]
  public record Message02A4
  {
    public Structure02A? identity { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A4>()
        .Structure(x => x.identity)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x02A5)]
  public record Message02A5
  {
    public Structure02A? targetPlayerIdentity { get; set; }
    public string? targetPlayerName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A5>()
        .Structure(x => x.targetPlayerIdentity)
        .String(x => x.targetPlayerName, true);
    }
  }

  [Message(6152, 0x02A6)]
  public record Message02A6
  {
    public Structure0C2? neighbor { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A6>()
        .Structure(x => x.neighbor)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6152, 0x02A7)]
  public record Message02A7
  {
    public Structure02A? targetPlayerIdentity { get; set; }
    public string? targetPlayerName { get; set; }
    public uint permissionLevel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A7>()
        .Structure(x => x.targetPlayerIdentity)
        .String(x => x.targetPlayerName, true)
        .Integer(x => x.permissionLevel, 32);
    }
  }

  [Message(6152, 0x02A8)]
  public record Message02A8
  {
    public Structure0C2? neighbor { get; set; }
    public uint updateType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02A8>()
        .Structure(x => x.neighbor)
        .Integer(x => x.updateType, 2);
    }
  }

  [Message(6152, 0x02AA)]
  public record Message02AA
  {
    public uint realmId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AA>()
        .Integer(x => x.realmId, 32);
    }
  }

  [Message(6152, 0x02AB)]
  public record Message02AB
  {
    public Structure02A? characterIdentity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AB>()
        .Structure(x => x.characterIdentity);
    }
  }

  [Message(6152, 0x02AC)]
  public record Message02AC
  {
    public ulong residenceId { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AC>()
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.type, 2);
    }
  }

  [Message(6152, 0x02AD)]
  public record Message02AD
  {
    public uint count { get; set; }
    public Structure0C3[]? residences { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AD>()
        .Integer(x => x.count, 32)
        .Array(x => x.residences, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x02AF)]
  public record Message02AF
  {
    public ulong residenceId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02AF>()
        .Integer(x => x.residenceId, 64)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x02B0)]
  public record Message02B0
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B0>();
    }
  }

  [Message(6152, 0x02B1)]
  public record Message02B1
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B1>();
    }
  }

  [Message(6152, 0x02B2)]
  public record Message02B2
  {
    public ulong residenceId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B2>()
        .Integer(x => x.residenceId, 64);
    }
  }

  [Message(6152, 0x02B4)]
  public record Message02B4
  {
    public ulong neighborhood { get; set; }
    public Structure02A? targetPlayerIdentity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B4>()
        .Integer(x => x.neighborhood, 64)
        .Structure(x => x.targetPlayerIdentity);
    }
  }

  [Message(6152, 0x02B6)]
  public record Message02B6
  {
    public Structure02A? identity { get; set; }
    public string? name { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B6>()
        .Structure(x => x.identity)
        .String(x => x.name, true)
        .Integer(x => x.result, 5);
    }
  }

  [Message(6152, 0x02B7)]
  public record Message02B7
  {
    public ulong residenceId { get; set; }
    public uint plotIndex { get; set; }
    public uint buildStage { get; set; }
    public uint buildState { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02B7>()
        .Integer(x => x.residenceId, 64)
        .Integer(x => x.plotIndex, 32)
        .Integer(x => x.buildStage, 32)
        .Integer(x => x.buildState, 3);
    }
  }

  [Message(6152, 0x02BF)]
  public record Message02BF
  {
    public uint type { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02BF>()
        .Integer(x => x.type, 3)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x02C0)]
  public record Message02C0
  {
    public uint type { get; set; }
    public uint result { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C0>()
        .Integer(x => x.type, 3)
        .Integer(x => x.result, 3)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x02C1)]
  public record Message02C1
  {
    public uint type { get; set; }
    public ulong iccomId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C1>()
        .Integer(x => x.type, 3)
        .Integer(x => x.iccomId, 64)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x02C2)]
  public record Message02C2
  {
    public ulong iccomId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C2>()
        .Integer(x => x.iccomId, 64);
    }
  }

  [Message(6152, 0x02C3)]
  public record Message02C3
  {
    public ulong iccomId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C3>()
        .Integer(x => x.iccomId, 64);
    }
  }

  [Message(6152, 0x02C4)]
  public record Message02C4
  {
    public ulong iccomId { get; set; }
    public uint messageId { get; set; }
    public uint messageNextId { get; set; }
    public string? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C4>()
        .Integer(x => x.iccomId, 64)
        .Integer(x => x.messageId, 32)
        .Integer(x => x.messageNextId, 32)
        .String(x => x.message, true);
    }
  }

  [Message(6152, 0x02C5)]
  public record Message02C5
  {
    public ulong iccomId { get; set; }
    public uint messageId { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C5>()
        .Integer(x => x.iccomId, 64)
        .Integer(x => x.messageId, 32)
        .Integer(x => x.result, 3);
    }
  }

  [Message(6152, 0x02C6)]
  public record Message02C6
  {
    public ulong iccomId { get; set; }
    public string? message { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C6>()
        .Integer(x => x.iccomId, 64)
        .String(x => x.message, true);
    }
  }

  [Message(6152, 0x02C7)]
  public record Message02C7
  {
    public uint msgId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C7>()
        .Integer(x => x.msgId, 32);
    }
  }

  [Message(6152, 0x02C8)]
  public record Message02C8
  {
    public uint count { get; set; }
    public Structure069[]? cooldownPersistenceData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C8>()
        .Integer(x => x.count, 32)
        .Array(x => x.cooldownPersistenceData, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x02C9)]
  public record Message02C9
  {
    public uint count { get; set; }
    public Structure068[]? spellList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02C9>()
        .Integer(x => x.count, 32)
        .Array(x => x.spellList, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x02D0)]
  public record Message02D0
  {
    public uint itemId { get; set; }
    public ulong auctionId { get; set; }
    public ulong bid { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D0>()
        .Integer(x => x.itemId, 32)
        .Integer(x => x.auctionId, 64)
        .Integer(x => x.bid, 64);
    }
  }

  [Message(6152, 0x02D1)]
  public record Message02D1
  {
    public uint result { get; set; }
    public Structure0B8? auction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D1>()
        .Integer(x => x.result, 7)
        .Structure(x => x.auction);
    }
  }

  [Message(6152, 0x02D2)]
  public record Message02D2
  {
    public Structure0B8? auction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D2>()
        .Structure(x => x.auction);
    }
  }

  [Message(6152, 0x02D3)]
  public record Message02D3
  {
    public Structure0B8? auction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D3>()
        .Structure(x => x.auction);
    }
  }

  [Message(6152, 0x02D4)]
  public record Message02D4
  {
    public uint totalResults { get; set; }
    public uint page { get; set; }
    public uint auctionCount { get; set; }
    public Structure0B8[]? auctions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D4>()
        .Integer(x => x.totalResults, 32)
        .Integer(x => x.page, 32)
        .Integer(x => x.auctionCount, 32)
        .Array(x => x.auctions, x => x.auctionCount).OfStructure();
    }
  }

  [Message(6152, 0x02D5)]
  public record Message02D5
  {
    public Structure0B8? auction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D5>()
        .Structure(x => x.auction);
    }
  }

  [Message(6152, 0x02D6)]
  public record Message02D6
  {
    public Structure0B8? auction { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D6>()
        .Structure(x => x.auction)
        .Integer(x => x.result, 7);
    }
  }

  [Message(6152, 0x02D7)]
  public record Message02D7
  {
    public ulong uniqueId { get; set; }
    public uint dynamicFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D7>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.dynamicFlags, 32);
    }
  }

  [Message(6152, 0x02D8)]
  public record Message02D8
  {
    public Structure0CC[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D8>()
        .Array(x => x.items, 2).OfStructure();
    }
  }

  [Message(6152, 0x02D9)]
  public record Message02D9
  {
    public ulong uniqueId { get; set; }
    public ulong locationData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02D9>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.locationData, 64);
    }
  }

  [Message(6152, 0x02DA)]
  public record Message02DA
  {
    public ulong uniqueId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DA>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6152, 0x02DB)]
  public record Message02DB
  {
    public ulong itemId { get; set; }
    public uint numMicrochips { get; set; }
    public uint[]? microchips { get; set; }
    public ulong thresholdData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DB>()
        .Integer(x => x.itemId, 64)
        .Integer(x => x.numMicrochips, 32)
        .Array(x => x.microchips, x => x.numMicrochips).OfInteger(32)
        .Integer(x => x.thresholdData, 64);
    }
  }

  [Message(6152, 0x02DC)]
  public record Message02DC
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DC>();
    }
  }

  [Message(6152, 0x02DD)]
  public record Message02DD
  {
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DD>()
        .Integer(x => x.characterId, 64);
    }
  }

  [Message(6152, 0x02DE)]
  public record Message02DE
  {
    public uint inputKeySetEnum { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DE>()
        .Integer(x => x.inputKeySetEnum, 32);
    }
  }

  [Message(6152, 0x02DF)]
  public record Message02DF
  {
    public uint count { get; set; }
    public Structure03D[]? bindings { get; set; }
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02DF>()
        .Integer(x => x.count, 32)
        .Array(x => x.bindings, x => x.count).OfStructure()
        .Integer(x => x.characterId, 64);
    }
  }

  [Message(6152, 0x02E2)]
  public record Message02E2
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02E2>();
    }
  }

  [Message(6152, 0x02EC)]
  public record Message02EC
  {
    public string? accountName { get; set; }
    public uint buildNumber { get; set; }
    public uint loginClientType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02EC>()
        .String(x => x.accountName, true)
        .Integer(x => x.buildNumber, 32)
        .Integer(x => x.loginClientType, 32);
    }
  }

  [Message(6152, 0x02ED)]
  public record Message02ED
  {
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02ED>()
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6152, 0x02EE)]
  public record Message02EE
  {
    public uint accountId { get; set; }
    public byte[]? sessionGUID { get; set; }
    public string? accountName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02EE>()
        .Integer(x => x.accountId, 32)
        .Array(x => x.sessionGUID, 16).Aligned(true).OfInteger(8)
        .String(x => x.accountName, true);
    }
  }

  [Message(6152, 0x02EF)]
  public record Message02EF
  {
    public Structure013? passwordDigest { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02EF>()
        .Structure(x => x.passwordDigest);
    }
  }

  [Message(6152, 0x02F0)]
  public record Message02F0
  {
    public ulong salt { get; set; }
    public ulong random { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02F0>()
        .Integer(x => x.salt, 64)
        .Integer(x => x.random, 64);
    }
  }

  [Message(6152, 0x02F2)]
  public record Message02F2
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02F2>();
    }
  }

  [Message(6152, 0x02F3)]
  public record Message02F3
  {
    public uint buildNumber { get; set; }
    public uint loginClientType { get; set; }
    public string? npUserId { get; set; }
    public string? npAuthToken { get; set; }
    public uint npIPv4CientAddress { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02F3>()
        .Integer(x => x.buildNumber, 32)
        .Integer(x => x.loginClientType, 32)
        .String(x => x.npUserId, false)
        .String(x => x.npAuthToken, false)
        .Integer(x => x.npIPv4CientAddress, 32);
    }
  }

  [Message(6152, 0x02F4)]
  public record Message02F4
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02F4>();
    }
  }

  [Message(6152, 0x02F5)]
  public record Message02F5
  {
    public string? reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02F5>()
        .String(x => x.reason, true);
    }
  }

  [Message(6152, 0x02F7)]
  public record Message02F7
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02F7>();
    }
  }

  [Message(6152, 0x02F8)]
  public record Message02F8
  {
    public uint requested { get; set; }
    public string? reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02F8>()
        .Integer(x => x.requested, 1)
        .String(x => x.reason, true);
    }
  }

  [Message(6152, 0x02FC)]
  public record Message02FC
  {
    public uint type { get; set; }
    public Structure02A? identity { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FC>()
        .Integer(x => x.type, 3)
        .Structure(x => x.identity);
    }
  }

  [Message(6152, 0x02FD)]
  public record Message02FD
  {
    public uint resultCode { get; set; }
    public Structure02A? identity { get; set; }
    public ushort[]? name { get; set; }
    public uint factionId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FD>()
        .Integer(x => x.resultCode, 3)
        .Structure(x => x.identity)
        .Array(x => x.name, 33).OfInteger(16)
        .Integer(x => x.factionId, 32);
    }
  }

  [Message(6152, 0x02FE)]
  public record Message02FE
  {
    public Structure0C4? @base { get; set; }
    public uint isClassPathSet { get; set; }
    public uint pathType { get; set; }
    public uint classId { get; set; }
    public uint level { get; set; }
    public uint isLastLoggedOnInDaysSet { get; set; }
    public float lastLoggedInDays { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message02FE>()
        .Structure(x => x.@base)
        .Integer(x => x.isClassPathSet, 1)
        .Integer(x => x.pathType, 3)
        .Integer(x => x.classId, 32)
        .Integer(x => x.level, 32)
        .Integer(x => x.isLastLoggedOnInDaysSet, 1)
        .Float(x => x.lastLoggedInDays);
    }
  }

  [Message(6152, 0x0301)]
  public record Message0301
  {
    public uint realmId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0301>()
        .Integer(x => x.realmId, 32);
    }
  }

  [Message(6152, 0x0302)]
  public record Message0302
  {
    public uint realmId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0302>()
        .Integer(x => x.realmId, 32)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x0304)]
  public record Message0304
  {
    public uint ackType { get; set; }
    public ulong uniqueId { get; set; }
    public uint error { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0304>()
        .Integer(x => x.ackType, 32)
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.error, 7);
    }
  }

  [Message(6152, 0x0305)]
  public record Message0305
  {
    public uint newMail { get; set; }
    public uint mailCount { get; set; }
    public Structure0D1[]? mailData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0305>()
        .Integer(x => x.newMail, 1)
        .Integer(x => x.mailCount, 32)
        .Array(x => x.mailData, x => x.mailCount).OfStructure();
    }
  }

  [Message(6152, 0x0308)]
  public record Message0308
  {
    public ulong uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0308>()
        .Integer(x => x.uniqueId, 64);
    }
  }

  [Message(6152, 0x0309)]
  public record Message0309
  {
    public ulong uniqueId { get; set; }
    public uint error { get; set; }
    public uint index { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0309>()
        .Integer(x => x.uniqueId, 64)
        .Integer(x => x.error, 7)
        .Integer(x => x.index, 32);
    }
  }

  [Message(6152, 0x030E)]
  public record Message030E
  {
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message030E>()
        .Integer(x => x.role, 32);
    }
  }

  [Message(6152, 0x0310)]
  public record Message0310
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0310>();
    }
  }

  [Message(6152, 0x0311)]
  public record Message0311
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0311>();
    }
  }

  [Message(6152, 0x0316)]
  public record Message0316
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0316>();
    }
  }

  [Message(6152, 0x0317)]
  public record Message0317
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0317>();
    }
  }

  [Message(6152, 0x0318)]
  public record Message0318
  {
    public uint matchingGameMapId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0318>()
        .Integer(x => x.matchingGameMapId, 32);
    }
  }

  [Message(6152, 0x0319)]
  public record Message0319
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0319>();
    }
  }

  [Message(6152, 0x031E)]
  public record Message031E
  {
    public uint pendingAllies { get; set; }
    public uint currentAllies { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message031E>()
        .Integer(x => x.pendingAllies, 32)
        .Integer(x => x.currentAllies, 32);
    }
  }

  [Message(6152, 0x0321)]
  public record Message0321
  {
    public uint response { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0321>()
        .Integer(x => x.response, 1);
    }
  }

  [Message(6152, 0x0323)]
  public record Message0323
  {
    public uint pendingAllies { get; set; }
    public uint pendingEnemies { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0323>()
        .Integer(x => x.pendingAllies, 32)
        .Integer(x => x.pendingEnemies, 32);
    }
  }

  [Message(6152, 0x0326)]
  public record Message0326
  {
    public uint ally { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0326>()
        .Integer(x => x.ally, 1);
    }
  }

  [Message(6152, 0x0329)]
  public record Message0329
  {
    public Structure0B3? maps { get; set; }
    public uint waitTime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0329>()
        .Structure(x => x.maps)
        .Integer(x => x.waitTime, 32);
    }
  }

  [Message(6152, 0x032A)]
  public record Message032A
  {
    public Structure02A? target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message032A>()
        .Structure(x => x.target);
    }
  }

  [Message(6152, 0x032C)]
  public record Message032C
  {
    public uint roles { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message032C>()
        .Integer(x => x.roles, 32);
    }
  }

  [Message(6152, 0x032F)]
  public record Message032F
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message032F>();
    }
  }

  [Message(6152, 0x0331)]
  public record Message0331
  {
    public Structure0B3? maps { get; set; }
    public uint waitTime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0331>()
        .Structure(x => x.maps)
        .Integer(x => x.waitTime, 32);
    }
  }

  [Message(6152, 0x0333)]
  public record Message0333
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0333>();
    }
  }

  [Message(6152, 0x0334)]
  public record Message0334
  {
    public uint[]? livesRemaining { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0334>()
        .Array(x => x.livesRemaining, 2).OfInteger(32);
    }
  }

  [Message(6152, 0x0335)]
  public record Message0335
  {
    public uint team { get; set; }
    public Structure0B4? stateInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0335>()
        .Integer(x => x.team, 32)
        .Structure(x => x.stateInfo);
    }
  }

  [Message(6152, 0x0336)]
  public record Message0336
  {
    public uint winner { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0336>()
        .Integer(x => x.winner, 32)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6152, 0x0337)]
  public record Message0337
  {
    public uint state { get; set; }
    public uint elapsed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0337>()
        .Integer(x => x.state, 32)
        .Integer(x => x.elapsed, 32);
    }
  }

  [Message(6152, 0x0339)]
  public record Message0339
  {
    public uint rating { get; set; }
    public uint wins { get; set; }
    public uint losses { get; set; }
    public uint draws { get; set; }
    public uint ratingType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0339>()
        .Integer(x => x.rating, 32)
        .Integer(x => x.wins, 32)
        .Integer(x => x.losses, 32)
        .Integer(x => x.draws, 32)
        .Integer(x => x.ratingType, 3);
    }
  }

  [Message(6152, 0x033A)]
  public record Message033A
  {
    public string[]? name { get; set; }
    public uint[]? rating { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message033A>()
        .Array(x => x.name, 2).OfString(true)
        .Array(x => x.rating, 2).OfInteger(32);
    }
  }

  [Message(6152, 0x033B)]
  public record Message033B
  {
    public Structure0B3? maps { get; set; }
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message033B>()
        .Structure(x => x.maps)
        .Integer(x => x.role, 32);
    }
  }

  [Message(6152, 0x033D)]
  public record Message033D
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message033D>();
    }
  }

  [Message(6152, 0x033E)]
  public record Message033E
  {
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message033E>()
        .Integer(x => x.reason, 5);
    }
  }

  [Message(6152, 0x033F)]
  public record Message033F
  {
    public Structure0B3? maps { get; set; }
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message033F>()
        .Structure(x => x.maps)
        .Integer(x => x.role, 32);
    }
  }

  [Message(6152, 0x0349)]
  public record Message0349
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0349>();
    }
  }

  [Message(6152, 0x034B)]
  public record Message034B
  {
    public Structure02A? identity { get; set; }
    public uint role { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message034B>()
        .Structure(x => x.identity)
        .Integer(x => x.role, 32);
    }
  }

  [Message(6152, 0x034E)]
  public record Message034E
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message034E>();
    }
  }

  [Message(6152, 0x0351)]
  public record Message0351
  {
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0351>()
        .Integer(x => x.reason, 5);
    }
  }

  [Message(6152, 0x0352)]
  public record Message0352
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0352>();
    }
  }

  [Message(6152, 0x0355)]
  public record Message0355
  {
    public uint matchingGameMapId { get; set; }
    public uint playerCount { get; set; }
    public Structure0B5[]? players { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0355>()
        .Integer(x => x.matchingGameMapId, 32)
        .Integer(x => x.playerCount, 32)
        .Array(x => x.players, x => x.playerCount).OfStructure();
    }
  }

  [Message(6152, 0x0358)]
  public record Message0358
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0358>();
    }
  }

  [Message(6152, 0x035A)]
  public record Message035A
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message035A>();
    }
  }

  [Message(6152, 0x035C)]
  public record Message035C
  {
    public Structure02A? target { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message035C>()
        .Structure(x => x.target);
    }
  }

  [Message(6152, 0x035E)]
  public record Message035E
  {
    public uint reason { get; set; }
    public uint remaining { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message035E>()
        .Integer(x => x.reason, 5)
        .Integer(x => x.remaining, 32);
    }
  }

  [Message(6152, 0x035F)]
  public record Message035F
  {
    public uint affirmative { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message035F>()
        .Integer(x => x.affirmative, 1);
    }
  }

  [Message(6152, 0x0362)]
  public record Message0362
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0362>();
    }
  }

  [Message(6152, 0x0364)]
  public record Message0364
  {
    public uint waitTime { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0364>()
        .Integer(x => x.waitTime, 32);
    }
  }

  [Message(6152, 0x0365)]
  public record Message0365
  {
    public uint count { get; set; }
    public Structure0D0[]? list { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0365>()
        .Integer(x => x.count, 32)
        .Array(x => x.list, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x0366)]
  public record Message0366
  {
    public uint msgId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0366>()
        .Integer(x => x.msgId, 32);
    }
  }

  [Message(6152, 0x0368)]
  public record Message0368
  {
    public uint mode { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0368>()
        .Integer(x => x.mode, 32);
    }
  }

  [Message(6152, 0x0369)]
  public record Message0369
  {
    public uint ticket { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0369>()
        .Integer(x => x.ticket, 32);
    }
  }

  [Message(6152, 0x036A)]
  public record Message036A
  {
    public uint ticket { get; set; }
    public uint immediate { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message036A>()
        .Integer(x => x.ticket, 32)
        .Integer(x => x.immediate, 1)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x036B)]
  public record Message036B
  {
    public uint time { get; set; }
    public uint commandCount { get; set; }
    public Structure08E[]? commands { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message036B>()
        .Integer(x => x.time, 32)
        .Integer(x => x.commandCount, 32)
        .Array(x => x.commands, x => x.commandCount).OfStructure();
    }
  }

  [Message(6152, 0x036C)]
  public record Message036C
  {
    public uint unitId { get; set; }
    public uint time { get; set; }
    public uint timeReset { get; set; }
    public uint serverControlled { get; set; }
    public uint commandCount { get; set; }
    public Structure08E[]? commands { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message036C>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.time, 32)
        .Integer(x => x.timeReset, 1)
        .Integer(x => x.serverControlled, 1)
        .Integer(x => x.commandCount, 32)
        .Array(x => x.commands, x => x.commandCount).OfStructure();
    }
  }

  [Message(6152, 0x036D)]
  public record Message036D
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message036D>();
    }
  }

  [Message(6152, 0x036E)]
  public record Message036E
  {
    public uint oldZoneId { get; set; }
    public uint newZoneId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message036E>()
        .Integer(x => x.oldZoneId, 32)
        .Integer(x => x.newZoneId, 32);
    }
  }

  [Message(6152, 0x036F)]
  public record Message036F
  {
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message036F>()
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6152, 0x0370)]
  public record Message0370
  {
    public string? msg { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0370>()
        .String(x => x.msg, true);
    }
  }

  [Message(6152, 0x0371)]
  public record Message0371
  {
    public uint oob { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0371>()
        .Integer(x => x.oob, 1);
    }
  }

  [Message(6152, 0x0372)]
  public record Message0372
  {
    public uint prereqId { get; set; }
    public uint prereqType { get; set; }
    public uint prefixId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0372>()
        .Integer(x => x.prereqId, 32)
        .Integer(x => x.prereqType, 8)
        .Integer(x => x.prefixId, 32);
    }
  }

  [Message(6152, 0x0374)]
  public record Message0374
  {
    public uint orderCount { get; set; }
    public Structure0B6[]? orders { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0374>()
        .Integer(x => x.orderCount, 32)
        .Array(x => x.orders, x => x.orderCount).OfStructure();
    }
  }

  [Message(6152, 0x0375)]
  public record Message0375
  {
    public uint auctionCount { get; set; }
    public Structure0B8[]? auctions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0375>()
        .Integer(x => x.auctionCount, 32)
        .Array(x => x.auctions, x => x.auctionCount).OfStructure();
    }
  }

  [Message(6152, 0x038D)]
  public record Message038D
  {
    public uint unitId { get; set; }
    public uint[]? patterns { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message038D>()
        .Integer(x => x.unitId, 32)
        .Array(x => x.patterns, 4).OfInteger(32);
    }
  }

  [Message(6152, 0x038F)]
  public record Message038F
  {
    public uint scannerBotId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message038F>()
        .Integer(x => x.scannerBotId, 32);
    }
  }

  [Message(6152, 0x0390)]
  public record Message0390
  {
    public uint scannerBotCooldown { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0390>()
        .Integer(x => x.scannerBotCooldown, 32);
    }
  }

  [Message(6152, 0x0391)]
  public record Message0391
  {
    public uint[]? patterns { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0391>()
        .Array(x => x.patterns, 4).OfInteger(32);
    }
  }

  [Message(6152, 0x0393)]
  public record Message0393
  {
    public uint result { get; set; }
    public uint improvementId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0393>()
        .Integer(x => x.result, 32)
        .Integer(x => x.improvementId, 32);
    }
  }

  [Message(6152, 0x0394)]
  public record Message0394
  {
    public uint unitId { get; set; }
    public uint groupCount { get; set; }
    public uint[]? groups { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0394>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.groupCount, 32)
        .Array(x => x.groups, x => x.groupCount).OfInteger(32);
    }
  }

  [Message(6152, 0x0395)]
  public record Message0395
  {
    public uint hubId { get; set; }
    public uint groupCount { get; set; }
    public Structure002[]? groups { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0395>()
        .Integer(x => x.hubId, 32)
        .Integer(x => x.groupCount, 32)
        .Array(x => x.groups, x => x.groupCount).OfStructure();
    }
  }

  [Message(6152, 0x0396)]
  public record Message0396
  {
    public uint hubId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0396>()
        .Integer(x => x.hubId, 32);
    }
  }

  [Message(6152, 0x0397)]
  public record Message0397
  {
    public uint groupId { get; set; }
    public uint tier { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0397>()
        .Integer(x => x.groupId, 32)
        .Integer(x => x.tier, 32);
    }
  }

  [Message(6152, 0x0398)]
  public record Message0398
  {
    public uint hubId { get; set; }
    public Structure002? group { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0398>()
        .Integer(x => x.hubId, 32)
        .Structure(x => x.group);
    }
  }

  [Message(6152, 0x0399)]
  public record Message0399
  {
    public uint improvementGroupId { get; set; }
    public string? unitName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0399>()
        .Integer(x => x.improvementGroupId, 32)
        .String(x => x.unitName, true);
    }
  }

  [Message(6152, 0x039A)]
  public record Message039A
  {
    public uint infrastructureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039A>()
        .Integer(x => x.infrastructureId, 32);
    }
  }

  [Message(6152, 0x039B)]
  public record Message039B
  {
    public uint infrastructureId { get; set; }
    public uint state { get; set; }
    public float percent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039B>()
        .Integer(x => x.infrastructureId, 32)
        .Integer(x => x.state, 2)
        .Float(x => x.percent);
    }
  }

  [Message(6152, 0x039C)]
  public record Message039C
  {
    public uint infrastructureId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039C>()
        .Integer(x => x.infrastructureId, 32);
    }
  }

  [Message(6152, 0x039D)]
  public record Message039D
  {
    public uint unitId { get; set; }
    public uint @event { get; set; }
    public uint count { get; set; }
    public uint[]? built { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039D>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.@event, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.built, x => x.count).OfInteger(32);
    }
  }

  [Message(6152, 0x039E)]
  public record Message039E
  {
    public uint missionId { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039E>()
        .Integer(x => x.missionId, 32)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x039F)]
  public record Message039F
  {
    public uint @event { get; set; }
    public Structure001? unit { get; set; }
    public float maxTypeHealth { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message039F>()
        .Integer(x => x.@event, 32)
        .Structure(x => x.unit)
        .Float(x => x.maxTypeHealth);
    }
  }

  [Message(6152, 0x03A0)]
  public record Message03A0
  {
    public uint @event { get; set; }
    public uint waveIndex { get; set; }
    public uint boss { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A0>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.waveIndex, 32)
        .Integer(x => x.boss, 1);
    }
  }

  [Message(6152, 0x03A1)]
  public record Message03A1
  {
    public uint @event { get; set; }
    public Structure001? unit { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A1>()
        .Integer(x => x.@event, 32)
        .Structure(x => x.unit);
    }
  }

  [Message(6152, 0x03A2)]
  public record Message03A2
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
      builder.FieldsOf<Message03A2>()
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

  [Message(6152, 0x03A3)]
  public record Message03A3
  {
    public uint @event { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A3>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.reason, 32);
    }
  }

  [Message(6152, 0x03A4)]
  public record Message03A4
  {
    public uint towerId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A4>()
        .Integer(x => x.towerId, 32);
    }
  }

  [Message(6152, 0x03A5)]
  public record Message03A5
  {
    public uint @event { get; set; }
    public uint credits { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A5>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.credits, 32);
    }
  }

  [Message(6152, 0x03A6)]
  public record Message03A6
  {
    public uint @event { get; set; }
    public uint built { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03A6>()
        .Integer(x => x.@event, 32)
        .Integer(x => x.built, 32);
    }
  }

  [Message(6152, 0x03AC)]
  public record Message03AC
  {
    public uint currPetPoints { get; set; }
    public uint maxPetPoints { get; set; }
    public uint count { get; set; }
    public Structure040[]? pets { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AC>()
        .Integer(x => x.currPetPoints, 32)
        .Integer(x => x.maxPetPoints, 32)
        .Integer(x => x.count, 32)
        .Array(x => x.pets, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x03AD)]
  public record Message03AD
  {
    public uint petId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AD>()
        .Integer(x => x.petId, 32);
    }
  }

  [Message(6152, 0x03AE)]
  public record Message03AE
  {
    public ulong[]? teamSlot { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AE>()
        .Array(x => x.teamSlot, 5).OfInteger(64);
    }
  }

  [Message(6152, 0x03AF)]
  public record Message03AF
  {
    public uint petBarIdx { get; set; }
    public uint petBarCmdIdx { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03AF>()
        .Integer(x => x.petBarIdx, 32)
        .Integer(x => x.petBarCmdIdx, 32);
    }
  }

  [Message(6152, 0x03B0)]
  public record Message03B0
  {
    public uint reason { get; set; }
    public uint petType { get; set; }
    public uint petObjectId { get; set; }
    public ushort flairSlotIndex { get; set; }
    public ushort flairId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03B0>()
        .Integer(x => x.reason, 32)
        .Integer(x => x.petType, 32)
        .Integer(x => x.petObjectId, 32)
        .Integer(x => x.flairSlotIndex, 16)
        .Integer(x => x.flairId, 16);
    }
  }

  [Message(6152, 0x03B1)]
  public record Message03B1
  {
    public uint petType { get; set; }
    public uint petObjectId { get; set; }
    public string? petName { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03B1>()
        .Integer(x => x.petType, 32)
        .Integer(x => x.petObjectId, 32)
        .String(x => x.petName, true);
    }
  }

  [Message(6152, 0x03B2)]
  public record Message03B2
  {
    public uint petFlairId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03B2>()
        .Integer(x => x.petFlairId, 32);
    }
  }

  [Message(6152, 0x03B3)]
  public record Message03B3
  {
    public uint petUnitId { get; set; }
    public uint stance { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03B3>()
        .Integer(x => x.petUnitId, 32)
        .Integer(x => x.stance, 32);
    }
  }

  [Message(6152, 0x03B4)]
  public record Message03B4
  {
    public uint petUnitId { get; set; }
    public uint stance { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03B4>()
        .Integer(x => x.petUnitId, 32)
        .Integer(x => x.stance, 32);
    }
  }

  [Message(6152, 0x03C2)]
  public record Message03C2
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C2>();
    }
  }

  [Message(6152, 0x03C3)]
  public record Message03C3
  {
    public uint pathEpsiodeId { get; set; }
    public uint missionCount { get; set; }
    public Structure03C[]? missions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C3>()
        .Integer(x => x.pathEpsiodeId, 32)
        .Integer(x => x.missionCount, 32)
        .Array(x => x.missions, x => x.missionCount).OfStructure();
    }
  }

  [Message(6152, 0x03C4)]
  public record Message03C4
  {
    public uint clueId { get; set; }
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C4>()
        .Integer(x => x.clueId, 32)
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x03C5)]
  public record Message03C5
  {
    public uint clueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C5>()
        .Integer(x => x.clueId, 32);
    }
  }

  [Message(6152, 0x03C6)]
  public record Message03C6
  {
    public uint locationId { get; set; }
    public uint clueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C6>()
        .Integer(x => x.locationId, 32)
        .Integer(x => x.clueId, 32);
    }
  }

  [Message(6152, 0x03C7)]
  public record Message03C7
  {
    public uint clueId { get; set; }
    public uint unitCount { get; set; }
    public uint[]? unitIds { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C7>()
        .Integer(x => x.clueId, 32)
        .Integer(x => x.unitCount, 32)
        .Array(x => x.unitIds, x => x.unitCount).OfInteger(32);
    }
  }

  [Message(6152, 0x03C8)]
  public record Message03C8
  {
    public uint missionCount { get; set; }
    public Structure03B[]? missions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C8>()
        .Integer(x => x.missionCount, 32)
        .Array(x => x.missions, x => x.missionCount).OfStructure();
    }
  }

  [Message(6152, 0x03C9)]
  public record Message03C9
  {
    public uint missionId { get; set; }
    public uint completed { get; set; }
    public uint userdata { get; set; }
    public uint statedata { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03C9>()
        .Integer(x => x.missionId, 32)
        .Integer(x => x.completed, 1)
        .Integer(x => x.userdata, 32)
        .Integer(x => x.statedata, 32);
    }
  }

  [Message(6152, 0x03CA)]
  public record Message03CA
  {
    public uint pathType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03CA>()
        .Integer(x => x.pathType, 32);
    }
  }

  [Message(6152, 0x03CB)]
  public record Message03CB
  {
    public uint zoneId { get; set; }
    public uint pathEpsiodeId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03CB>()
        .Integer(x => x.zoneId, 32)
        .Integer(x => x.pathEpsiodeId, 32);
    }
  }

  [Message(6152, 0x03CE)]
  public record Message03CE
  {
    public ushort type { get; set; }
    public ushort subType { get; set; }
    public float posx { get; set; }
    public float posy { get; set; }
    public float posz { get; set; }
    public string? text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03CE>()
        .Integer(x => x.type, 16)
        .Integer(x => x.subType, 16)
        .Float(x => x.posx)
        .Float(x => x.posy)
        .Float(x => x.posz)
        .String(x => x.text, true);
    }
  }

  [Message(6152, 0x03D1)]
  public record Message03D1
  {
    public Structure0B6? order { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D1>()
        .Structure(x => x.order);
    }
  }

  [Message(6152, 0x03D2)]
  public record Message03D2
  {
    public uint result { get; set; }
    public Structure0B6? order { get; set; }
    public ulong actualCost { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D2>()
        .Integer(x => x.result, 7)
        .Structure(x => x.order)
        .Integer(x => x.actualCost, 64);
    }
  }

  [Message(6152, 0x03D3)]
  public record Message03D3
  {
    public ulong itemUniqueId { get; set; }
    public ulong minBid { get; set; }
    public ulong buyout { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D3>()
        .Integer(x => x.itemUniqueId, 64)
        .Integer(x => x.minBid, 64)
        .Integer(x => x.buyout, 64);
    }
  }

  [Message(6152, 0x03D4)]
  public record Message03D4
  {
    public uint result { get; set; }
    public Structure0B8? auction { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03D4>()
        .Integer(x => x.result, 7)
        .Structure(x => x.auction);
    }
  }

  [Message(6152, 0x03DC)]
  public record Message03DC
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint teamId { get; set; }
    public uint choice { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03DC>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.teamId, 32)
        .Integer(x => x.choice, 32);
    }
  }

  [Message(6152, 0x03DE)]
  public record Message03DE
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint teamId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03DE>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.teamId, 32);
    }
  }

  [Message(6152, 0x03E2)]
  public record Message03E2
  {
    public uint objectiveId { get; set; }
    public uint busy { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E2>()
        .Integer(x => x.objectiveId, 32)
        .Integer(x => x.busy, 1);
    }
  }

  [Message(6152, 0x03E3)]
  public record Message03E3
  {
    public uint choice { get; set; }
    public uint count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E3>()
        .Integer(x => x.choice, 32)
        .Integer(x => x.count, 32);
    }
  }

  [Message(6152, 0x03E4)]
  public record Message03E4
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint winner { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E4>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.winner, 32);
    }
  }

  [Message(6152, 0x03E5)]
  public record Message03E5
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
      builder.FieldsOf<Message03E5>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.teamId, 32)
        .Integer(x => x.tallyCount, 32)
        .Array(x => x.tally, x => x.tallyCount).OfStructure()
        .Integer(x => x.canPlayerVote, 1)
        .Integer(x => x.elapsedTimeMs, 32);
    }
  }

  [Message(6152, 0x03E6)]
  public record Message03E6
  {
    public uint eventId { get; set; }
    public uint voteId { get; set; }
    public uint choice { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03E6>()
        .Integer(x => x.eventId, 32)
        .Integer(x => x.voteId, 32)
        .Integer(x => x.choice, 32);
    }
  }

  [Message(6152, 0x03F3)]
  public record Message03F3
  {
    public float px { get; set; }
    public float py { get; set; }
    public float pz { get; set; }
    public float vx { get; set; }
    public float vy { get; set; }
    public float vz { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03F3>()
        .Float(x => x.px)
        .Float(x => x.py)
        .Float(x => x.pz)
        .Float(x => x.vx)
        .Float(x => x.vy)
        .Float(x => x.vz);
    }
  }

  [Message(6152, 0x03F4)]
  public record Message03F4
  {
    public uint spline { get; set; }
    public uint splineMode { get; set; }
    public float speed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03F4>()
        .Integer(x => x.spline, 32)
        .Integer(x => x.splineMode, 32)
        .Float(x => x.speed);
    }
  }

  [Message(6152, 0x03F5)]
  public record Message03F5
  {
    public uint unit { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03F5>()
        .Integer(x => x.unit, 32);
    }
  }

  [Message(6152, 0x03F6)]
  public record Message03F6
  {
    public byte m_notification { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03F6>()
        .Integer(x => x.m_notification, 8);
    }
  }

  [Message(6152, 0x03F7)]
  public record Message03F7
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03F7>();
    }
  }

  [Message(6152, 0x03F9)]
  public record Message03F9
  {
    public uint m_textId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03F9>()
        .Integer(x => x.m_textId, 32);
    }
  }

  [Message(6152, 0x03FA)]
  public record Message03FA
  {
    public string? m_text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message03FA>()
        .String(x => x.m_text, true);
    }
  }

  [Message(6152, 0x040C)]
  public record Message040C
  {
    public Structure022? m_text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message040C>()
        .Structure(x => x.m_text);
    }
  }

  [Message(6152, 0x040D)]
  public record Message040D
  {
    public Structure022? m_text { get; set; }
    public uint m_creatureId { get; set; }
    public uint m_duration { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message040D>()
        .Structure(x => x.m_text)
        .Integer(x => x.m_creatureId, 32)
        .Integer(x => x.m_duration, 32);
    }
  }

  [Message(6152, 0x041D)]
  public record Message041D
  {
    public uint m_unitId { get; set; }
    public uint m_sequence { get; set; }
    public float m_start { get; set; }
    public float m_speed { get; set; }
    public uint m_layer { get; set; }
    public ushort m_seed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message041D>()
        .Integer(x => x.m_unitId, 32)
        .Integer(x => x.m_sequence, 32)
        .Float(x => x.m_start)
        .Float(x => x.m_speed)
        .Integer(x => x.m_layer, 32)
        .Integer(x => x.m_seed, 16);
    }
  }

  [Message(6152, 0x0425)]
  public record Message0425
  {
    public Structure022? m_text { get; set; }
    public uint m_speakerUnitId { get; set; }
    public uint m_isEmote { get; set; }
    public uint m_squelchChatLog { get; set; }
    public float m_radius { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0425>()
        .Structure(x => x.m_text)
        .Integer(x => x.m_speakerUnitId, 32)
        .Integer(x => x.m_isEmote, 1)
        .Integer(x => x.m_squelchChatLog, 1)
        .Float(x => x.m_radius);
    }
  }

  [Message(6152, 0x0426)]
  public record Message0426
  {
    public uint m_unitId { get; set; }
    public uint m_set { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0426>()
        .Integer(x => x.m_unitId, 32)
        .Integer(x => x.m_set, 1);
    }
  }

  [Message(6152, 0x0428)]
  public record Message0428
  {
    public uint m_commId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0428>()
        .Integer(x => x.m_commId, 32);
    }
  }

  [Message(6152, 0x0429)]
  public record Message0429
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0429>();
    }
  }

  [Message(6152, 0x042A)]
  public record Message042A
  {
    public Structure022? m_text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042A>()
        .Structure(x => x.m_text);
    }
  }

  [Message(6152, 0x042B)]
  public record Message042B
  {
    public Structure022? m_text { get; set; }
    public uint soundEventId { get; set; }
    public uint windowTypeId { get; set; }
    public uint durationMS { get; set; }
    public uint storyPanelStyleEnum { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042B>()
        .Structure(x => x.m_text)
        .Integer(x => x.soundEventId, 32)
        .Integer(x => x.windowTypeId, 32)
        .Integer(x => x.durationMS, 32)
        .Integer(x => x.storyPanelStyleEnum, 32);
    }
  }

  [Message(6152, 0x042C)]
  public record Message042C
  {
    public uint realmId { get; set; }
    public string? realmName { get; set; }
    public uint flags { get; set; }
    public uint realmStatus { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042C>()
        .Integer(x => x.realmId, 32)
        .String(x => x.realmName, true)
        .Integer(x => x.flags, 32)
        .Integer(x => x.realmStatus, 3);
    }
  }

  [Message(6152, 0x042D)]
  public record Message042D
  {
    public uint realmCount { get; set; }
    public Structure011[]? realmInfo { get; set; }
    public uint realmMessagesCount { get; set; }
    public string[]? realmMessages { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042D>()
        .Integer(x => x.realmCount, 32)
        .Array(x => x.realmInfo, x => x.realmCount).OfStructure()
        .Integer(x => x.realmMessagesCount, 32)
        .Array(x => x.realmMessages, x => x.realmMessagesCount).OfString(true);
    }
  }

  [Message(6152, 0x042E)]
  public record Message042E
  {
    public uint serverUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042E>()
        .Integer(x => x.serverUniqueId, 32);
    }
  }

  [Message(6152, 0x042F)]
  public record Message042F
  {
    public uint visualCount { get; set; }
    public uint[]? serverUniqueIdList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message042F>()
        .Integer(x => x.visualCount, 32)
        .Array(x => x.serverUniqueIdList, x => x.visualCount).OfInteger(32);
    }
  }

  [Message(6152, 0x0430)]
  public record Message0430
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0430>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x0433)]
  public record Message0433
  {
    public uint serverUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0433>()
        .Integer(x => x.serverUniqueId, 32);
    }
  }

  [Message(6152, 0x0434)]
  public record Message0434
  {
    public uint sourceUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0434>()
        .Integer(x => x.sourceUnitId, 32);
    }
  }

  [Message(6152, 0x0439)]
  public record Message0439
  {
    public uint titleId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0439>()
        .Integer(x => x.titleId, 32);
    }
  }

  [Message(6152, 0x0440)]
  public record Message0440
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0440>();
    }
  }

  [Message(6152, 0x0446)]
  public record Message0446
  {
    public uint itemFamily { get; set; }
    public uint itemCategory { get; set; }
    public uint itemType { get; set; }
    public uint itemIdCount { get; set; }
    public uint[]? itemIds { get; set; }
    public uint propertyCount { get; set; }
    public Structure0B7[]? properties { get; set; }
    public uint sortBy { get; set; }
    public uint reverseSort { get; set; }
    public uint page { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0446>()
        .Integer(x => x.itemFamily, 32)
        .Integer(x => x.itemCategory, 32)
        .Integer(x => x.itemType, 32)
        .Integer(x => x.itemIdCount, 32)
        .Array(x => x.itemIds, x => x.itemIdCount).OfInteger(32)
        .Integer(x => x.propertyCount, 32)
        .Array(x => x.properties, x => x.propertyCount).OfStructure()
        .Integer(x => x.sortBy, 32)
        .Integer(x => x.reverseSort, 1)
        .Integer(x => x.page, 32);
    }
  }

  [Message(6152, 0x0447)]
  public record Message0447
  {
    public ulong characterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0447>()
        .Integer(x => x.characterId, 64);
    }
  }

  [Message(6152, 0x0449)]
  public record Message0449
  {
    public uint realmId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0449>()
        .Integer(x => x.realmId, 32);
    }
  }

  [Message(6152, 0x044A)]
  public record Message044A
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message044A>();
    }
  }

  [Message(6152, 0x044D)]
  public record Message044D
  {
    public uint count { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message044D>()
        .Integer(x => x.count, 32);
    }
  }

  [Message(6152, 0x0450)]
  public record Message0450
  {
    public uint targetId { get; set; }
    public uint activationType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0450>()
        .Integer(x => x.targetId, 32)
        .Integer(x => x.activationType, 32);
    }
  }

  [Message(6152, 0x0452)]
  public record Message0452
  {
    public uint petType { get; set; }
    public uint petObjectId { get; set; }
    public ushort flairSlotIndex { get; set; }
    public ushort flairId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0452>()
        .Integer(x => x.petType, 32)
        .Integer(x => x.petObjectId, 32)
        .Integer(x => x.flairSlotIndex, 16)
        .Integer(x => x.flairId, 16);
    }
  }

  [Message(6152, 0x0454)]
  public record Message0454
  {
    public uint unitId { get; set; }
    public uint explosion { get; set; }
    public uint count { get; set; }
    public Structure0CD[]? loot { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0454>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.explosion, 1)
        .Integer(x => x.count, 32)
        .Array(x => x.loot, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x0456)]
  public record Message0456
  {
    public uint serverUniqueId { get; set; }
    public uint bIgnoreCooldown { get; set; }
    public Structure015? primaryDestination { get; set; }
    public byte targetCount { get; set; }
    public Structure05F[]? targetInfo { get; set; }
    public byte initialPositionCount { get; set; }
    public Structure05D[]? initialPositions { get; set; }
    public byte telegraphPositionCount { get; set; }
    public Structure05E[]? telegraphPositions { get; set; }
    public byte missileCount { get; set; }
    public Structure063[]? missileInfo { get; set; }
    public uint phase { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0456>()
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

  [Message(6152, 0x0457)]
  public record Message0457
  {
    public uint serverUniqueId { get; set; }
    public uint effectId { get; set; }
    public uint targetId { get; set; }
    public byte damageCount { get; set; }
    public Structure062[]? damageInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0457>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.effectId, 32)
        .Integer(x => x.targetId, 32)
        .Integer(x => x.damageCount, 8)
        .Array(x => x.damageInfo, x => x.damageCount).OfStructure();
    }
  }

  [Message(6152, 0x0458)]
  public record Message0458
  {
    public uint serverUniqueId { get; set; }
    public uint result { get; set; }
    public uint unitThatCausedId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0458>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.result, 9)
        .Integer(x => x.unitThatCausedId, 32);
    }
  }

  [Message(6152, 0x0459)]
  public record Message0459
  {
    public uint serverUniqueId { get; set; }
    public uint result { get; set; }
    public uint unitThatCausedId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0459>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.result, 9)
        .Integer(x => x.unitThatCausedId, 32);
    }
  }

  [Message(6152, 0x045A)]
  public record Message045A
  {
    public uint serverUniqueId { get; set; }
    public uint missCount { get; set; }
    public Structure064[]? missInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message045A>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.missCount, 32)
        .Array(x => x.missInfo, x => x.missCount).OfStructure();
    }
  }

  [Message(6152, 0x045B)]
  public record Message045B
  {
    public uint clientUniqueId { get; set; }
    public uint result { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message045B>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.result, 9);
    }
  }

  [Message(6152, 0x045C)]
  public record Message045C
  {
    public uint clientUniqueId { get; set; }
    public uint serverUniqueId { get; set; }
    public uint casterId { get; set; }
    public uint primaryTargetId { get; set; }
    public Structure015? fieldPosition { get; set; }
    public float yaw { get; set; }
    public byte initialPositionCount { get; set; }
    public Structure05D[]? initialPositions { get; set; }
    public byte telegraphPositionCount { get; set; }
    public Structure05E[]? telegraphPositions { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message045C>()
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

  [Message(6152, 0x045D)]
  public record Message045D
  {
    public uint serverUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message045D>()
        .Integer(x => x.serverUniqueId, 32);
    }
  }

  [Message(6152, 0x045E)]
  public record Message045E
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
      builder.FieldsOf<Message045E>()
        .Integer(x => x.drainerUnitId, 32)
        .Integer(x => x.draineeUnitId, 32)
        .Integer(x => x.drainAmount, 32)
        .Integer(x => x.drainType, 32)
        .Integer(x => x.fillAmount, 32)
        .Integer(x => x.fillType, 32)
        .Integer(x => x.spellId, 32);
    }
  }

  [Message(6152, 0x045F)]
  public record Message045F
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
    public Structure05D[]? initialPositions { get; set; }
    public byte telegraphPositionCount { get; set; }
    public Structure05E[]? telegraphPositions { get; set; }
    public uint bUserInitiatedSpellCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message045F>()
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

  [Message(6152, 0x0461)]
  public record Message0461
  {
    public uint clientUniqueId { get; set; }
    public uint bCancelCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0461>()
        .Integer(x => x.clientUniqueId, 32)
        .Integer(x => x.bCancelCast, 1);
    }
  }

  [Message(6152, 0x0462)]
  public record Message0462
  {
    public uint serverUniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0462>()
        .Integer(x => x.serverUniqueId, 32);
    }
  }

  [Message(6152, 0x0463)]
  public record Message0463
  {
    public uint serverUniqueId { get; set; }
    public uint castResult { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0463>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.castResult, 32);
    }
  }

  [Message(6152, 0x0465)]
  public record Message0465
  {
    public uint serverUniqueId { get; set; }
    public uint result { get; set; }
    public uint validation { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0465>()
        .Integer(x => x.serverUniqueId, 32)
        .Integer(x => x.result, 3)
        .Integer(x => x.validation, 32);
    }
  }

  [Message(6152, 0x046E)]
  public record Message046E
  {
    public uint disableCooldowns { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message046E>()
        .Integer(x => x.disableCooldowns, 1);
    }
  }

  [Message(6152, 0x046F)]
  public record Message046F
  {
    public uint count { get; set; }
    public Structure067[]? spellTargets { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message046F>()
        .Integer(x => x.count, 32)
        .Array(x => x.spellTargets, x => x.count).OfStructure();
    }
  }

  [Message(6152, 0x0470)]
  public record Message0470
  {
    public uint spellId { get; set; }
    public uint rootSpellId { get; set; }
    public uint serverUID { get; set; }
    public uint newThresholdNdx { get; set; }
    public uint bClear { get; set; }
    public uint bForceCast { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0470>()
        .Integer(x => x.spellId, 32)
        .Integer(x => x.rootSpellId, 32)
        .Integer(x => x.serverUID, 32)
        .Integer(x => x.newThresholdNdx, 32)
        .Integer(x => x.bClear, 1)
        .Integer(x => x.bForceCast, 1);
    }
  }

  [Message(6152, 0x0471)]
  public record Message0471
  {
    public uint newId { get; set; }
    public uint worldId { get; set; }
    public uint splineType { get; set; }
    public uint nodeCount { get; set; }
    public Structure0D8[]? nodes { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0471>()
        .Integer(x => x.newId, 32)
        .Integer(x => x.worldId, 32)
        .Integer(x => x.splineType, 2)
        .Integer(x => x.nodeCount, 32)
        .Array(x => x.nodes, x => x.nodeCount).OfStructure();
    }
  }

  [Message(6152, 0x0472)]
  public record Message0472
  {
    public uint baseId { get; set; }
    public uint newId { get; set; }
    public Structure015? offset { get; set; }
    public uint nodeCount { get; set; }
    public float[]? nodeYs { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0472>()
        .Integer(x => x.baseId, 32)
        .Integer(x => x.newId, 32)
        .Structure(x => x.offset)
        .Integer(x => x.nodeCount, 32)
        .Array(x => x.nodeYs, x => x.nodeCount).OfFloat();
    }
  }

  [Message(6152, 0x0473)]
  public record Message0473
  {
    public uint splineId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0473>()
        .Integer(x => x.splineId, 32);
    }
  }

  [Message(6152, 0x0474)]
  public record Message0474
  {
    public uint splineId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0474>()
        .Integer(x => x.splineId, 32);
    }
  }

  [Message(6152, 0x0476)]
  public record Message0476
  {
    public ushort subType { get; set; }
    public uint unitId { get; set; }
    public uint questId { get; set; }
    public string? text { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0476>()
        .Integer(x => x.subType, 16)
        .Integer(x => x.unitId, 32)
        .Integer(x => x.questId, 32)
        .String(x => x.text, true);
    }
  }

  [Message(6152, 0x0477)]
  public record Message0477
  {
    public string? m_comment { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0477>()
        .String(x => x.m_comment, true);
    }
  }

  [Message(6152, 0x0478)]
  public record Message0478
  {
    public uint timeRemaining { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0478>()
        .Integer(x => x.timeRemaining, 32);
    }
  }

  [Message(6152, 0x0479)]
  public record Message0479
  {
    public string? m_comment { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0479>()
        .String(x => x.m_comment, true);
    }
  }

  [Message(6152, 0x047D)]
  public record Message047D
  {
    public uint timeOfDay { get; set; }
    public uint season { get; set; }
    public uint lengthOfDay { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message047D>()
        .Integer(x => x.timeOfDay, 32)
        .Integer(x => x.season, 32)
        .Integer(x => x.lengthOfDay, 32);
    }
  }

  [Message(6152, 0x047E)]
  public record Message047E
  {
    public float timeScale { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message047E>()
        .Float(x => x.timeScale);
    }
  }

  [Message(6152, 0x0480)]
  public record Message0480
  {
    public uint trackingSlotId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0480>()
        .Integer(x => x.trackingSlotId, 32);
    }
  }

  [Message(6152, 0x0481)]
  public record Message0481
  {
    public uint trackingSlotId { get; set; }
    public float posX { get; set; }
    public float posY { get; set; }
    public float posZ { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0481>()
        .Integer(x => x.trackingSlotId, 32)
        .Float(x => x.posX)
        .Float(x => x.posY)
        .Float(x => x.posZ);
    }
  }

  [Message(6152, 0x0482)]
  public record Message0482
  {
    public uint craftingStationId { get; set; }
    public uint itemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0482>()
        .Integer(x => x.craftingStationId, 32)
        .Integer(x => x.itemId, 32);
    }
  }

  [Message(6152, 0x0483)]
  public record Message0483
  {
    public uint craftingStationId { get; set; }
    public uint itemId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0483>()
        .Integer(x => x.craftingStationId, 32)
        .Integer(x => x.itemId, 32);
    }
  }

  [Message(6152, 0x0484)]
  public record Message0484
  {
    public uint bonusEnum { get; set; }
    public uint objectIdPrimary { get; set; }
    public uint objectIdSecondary { get; set; }
    public uint objectIdTertiary { get; set; }
    public float multiplier { get; set; }
    public uint intValue { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0484>()
        .Integer(x => x.bonusEnum, 32)
        .Integer(x => x.objectIdPrimary, 32)
        .Integer(x => x.objectIdSecondary, 32)
        .Integer(x => x.objectIdTertiary, 32)
        .Float(x => x.multiplier)
        .Integer(x => x.intValue, 32);
    }
  }

  [Message(6152, 0x0485)]
  public record Message0485
  {
    public uint bonusCount { get; set; }
    public Structure0C7[]? bonuses { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0485>()
        .Integer(x => x.bonusCount, 32)
        .Array(x => x.bonuses, x => x.bonusCount).OfStructure();
    }
  }

  [Message(6152, 0x0486)]
  public record Message0486
  {

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0486>();
    }
  }

  [Message(6152, 0x0487)]
  public record Message0487
  {
    public uint tradeskillId { get; set; }
    public uint tier { get; set; }
    public uint talent { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0487>()
        .Integer(x => x.tradeskillId, 32)
        .Integer(x => x.tier, 32)
        .Integer(x => x.talent, 32);
    }
  }

  [Message(6152, 0x0488)]
  public record Message0488
  {
    public uint craftingStationId { get; set; }
    public uint schematicId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0488>()
        .Integer(x => x.craftingStationId, 32)
        .Integer(x => x.schematicId, 32);
    }
  }

  [Message(6152, 0x0489)]
  public record Message0489
  {
    public uint craftingStationId { get; set; }
    public uint schematicId { get; set; }
    public uint microchipCount { get; set; }
    public uint[]? microchips { get; set; }
    public ulong thresholdData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0489>()
        .Integer(x => x.craftingStationId, 32)
        .Integer(x => x.schematicId, 32)
        .Integer(x => x.microchipCount, 32)
        .Array(x => x.microchips, x => x.microchipCount).OfInteger(32)
        .Integer(x => x.thresholdData, 64);
    }
  }

  [Message(6152, 0x048A)]
  public record Message048A
  {
    public uint success { get; set; }
    public uint hotCold { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message048A>()
        .Integer(x => x.success, 1)
        .Integer(x => x.hotCold, 32);
    }
  }

  [Message(6152, 0x048B)]
  public record Message048B
  {
    public uint schematicId { get; set; }
    public uint numAdditives { get; set; }
    public uint numCatalysts { get; set; }
    public uint[]? catalysts { get; set; }
    public uint useCatalyst { get; set; }
    public float vectorX { get; set; }
    public float vectorY { get; set; }
    public float craftRadiusMult { get; set; }
    public float critRadiusMult { get; set; }
    public float discoveryRadiusMult { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message048B>()
        .Integer(x => x.schematicId, 32)
        .Integer(x => x.numAdditives, 32)
        .Integer(x => x.numCatalysts, 32)
        .Array(x => x.catalysts, 5).OfInteger(32)
        .Integer(x => x.useCatalyst, 1)
        .Float(x => x.vectorX)
        .Float(x => x.vectorY)
        .Float(x => x.craftRadiusMult)
        .Float(x => x.critRadiusMult)
        .Float(x => x.discoveryRadiusMult);
    }
  }

  [Message(6152, 0x048C)]
  public record Message048C
  {
    public uint schematicId { get; set; }
    public float x { get; set; }
    public float y { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message048C>()
        .Integer(x => x.schematicId, 32)
        .Float(x => x.x)
        .Float(x => x.y);
    }
  }

  [Message(6152, 0x048D)]
  public record Message048D
  {
    public uint numTradeskills { get; set; }
    public Structure0C5[]? tradeskillData { get; set; }
    public uint schematicCount { get; set; }
    public uint[]? schematics { get; set; }
    public uint discoveryCount { get; set; }
    public Structure0C6[]? discoveries { get; set; }
    public uint craftedMaskSize { get; set; }
    public uint[]? craftedMask { get; set; }
    public uint relearnCooldownSecs { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message048D>()
        .Integer(x => x.numTradeskills, 32)
        .Array(x => x.tradeskillData, x => x.numTradeskills).OfStructure()
        .Integer(x => x.schematicCount, 32)
        .Array(x => x.schematics, x => x.schematicCount).OfInteger(32)
        .Integer(x => x.discoveryCount, 32)
        .Array(x => x.discoveries, x => x.discoveryCount).OfStructure()
        .Integer(x => x.craftedMaskSize, 32)
        .Array(x => x.craftedMask, x => x.craftedMaskSize).OfInteger(32)
        .Integer(x => x.relearnCooldownSecs, 32);
    }
  }

  [Message(6152, 0x048E)]
  public record Message048E
  {
    public uint tradeskillId { get; set; }
    public uint tradeskillIdToDrop { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message048E>()
        .Integer(x => x.tradeskillId, 32)
        .Integer(x => x.tradeskillIdToDrop, 32);
    }
  }

  [Message(6152, 0x048F)]
  public record Message048F
  {
    public ulong itemId { get; set; }
    public uint microchipCount { get; set; }
    public uint[]? microchips { get; set; }
    public ulong thresholdData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message048F>()
        .Integer(x => x.itemId, 64)
        .Integer(x => x.microchipCount, 32)
        .Array(x => x.microchips, x => x.microchipCount).OfInteger(32)
        .Integer(x => x.thresholdData, 64);
    }
  }

  [Message(6152, 0x0490)]
  public record Message0490
  {
    public uint tradeskillId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0490>()
        .Integer(x => x.tradeskillId, 32);
    }
  }

  [Message(6152, 0x0491)]
  public record Message0491
  {
    public ulong itemId { get; set; }
    public uint socketIndex { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0491>()
        .Integer(x => x.itemId, 64)
        .Integer(x => x.socketIndex, 32);
    }
  }

  [Message(6152, 0x0492)]
  public record Message0492
  {
    public uint tradeskillId { get; set; }
    public uint schematicId { get; set; }
    public float discoveredX { get; set; }
    public float discoveredY { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0492>()
        .Integer(x => x.tradeskillId, 32)
        .Integer(x => x.schematicId, 32)
        .Float(x => x.discoveredX)
        .Float(x => x.discoveredY);
    }
  }

  [Message(6152, 0x0493)]
  public record Message0493
  {
    public uint tradeskillId { get; set; }
    public uint xp { get; set; }
    public uint flags { get; set; }
    public uint proficiencyFlags { get; set; }
    public uint talentPoints { get; set; }
    public uint[]? talents { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0493>()
        .Integer(x => x.tradeskillId, 32)
        .Integer(x => x.xp, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.proficiencyFlags, 32)
        .Integer(x => x.talentPoints, 32)
        .Array(x => x.talents, 10).OfInteger(32);
    }
  }

  [Message(6152, 0x0494)]
  public record Message0494
  {
    public uint relearnCooldownSecs { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0494>()
        .Integer(x => x.relearnCooldownSecs, 32);
    }
  }

  [Message(6152, 0x049E)]
  public record Message049E
  {
    public uint self { get; set; }
    public Structure06E? passenger { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message049E>()
        .Integer(x => x.self, 32)
        .Structure(x => x.passenger);
    }
  }

  [Message(6152, 0x04A5)]
  public record Message04A5
  {
    public uint unitId { get; set; }
    public uint targetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04A5>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.targetId, 32);
    }
  }

  [Message(6152, 0x04A6)]
  public record Message04A6
  {
    public uint unitId { get; set; }
    public uint targetId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04A6>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.targetId, 32);
    }
  }

  [Message(6152, 0x04A8)]
  public record Message04A8
  {
    public uint playerId { get; set; }
    public uint targetId { get; set; }
    public uint state { get; set; }
    public uint result { get; set; }
    public uint extraData { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04A8>()
        .Integer(x => x.playerId, 32)
        .Integer(x => x.targetId, 32)
        .Integer(x => x.state, 5)
        .Integer(x => x.result, 32)
        .Integer(x => x.extraData, 32);
    }
  }

  [Message(6152, 0x04A9)]
  public record Message04A9
  {
    public uint unitId { get; set; }
    public uint state { get; set; }
    public uint bRemove { get; set; }
    public uint additionalDataId { get; set; }
    public uint spellUniqueId { get; set; }
    public uint spellEffectDuration { get; set; }
    public uint effectUniqueId { get; set; }
    public uint visualOverrideId0 { get; set; }
    public uint visualOverrideId1 { get; set; }
    public uint visualOverrideId2 { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04A9>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.state, 5)
        .Integer(x => x.bRemove, 1)
        .Integer(x => x.additionalDataId, 32)
        .Integer(x => x.spellUniqueId, 32)
        .Integer(x => x.spellEffectDuration, 32)
        .Integer(x => x.effectUniqueId, 32)
        .Integer(x => x.visualOverrideId0, 32)
        .Integer(x => x.visualOverrideId1, 32)
        .Integer(x => x.visualOverrideId2, 32);
    }
  }

  [Message(6152, 0x04AB)]
  public record Message04AB
  {
    public uint unitId { get; set; }
    public uint factionIdOverride { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04AB>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.factionIdOverride, 32);
    }
  }

  [Message(6152, 0x04AE)]
  public record Message04AE
  {
    public uint self { get; set; }
    public uint flags { get; set; }
    public uint uiFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04AE>()
        .Integer(x => x.self, 32)
        .Integer(x => x.flags, 32)
        .Integer(x => x.uiFlags, 32);
    }
  }

  [Message(6152, 0x04AF)]
  public record Message04AF
  {
    public uint self { get; set; }
    public uint miniMapMarkerId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04AF>()
        .Integer(x => x.self, 32)
        .Integer(x => x.miniMapMarkerId, 32);
    }
  }

  [Message(6152, 0x04B1)]
  public record Message04B1
  {
    public uint unitId { get; set; }
    public uint dead { get; set; }
    public uint reason { get; set; }
    public uint rezHealth { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04B1>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.dead, 1)
        .Integer(x => x.reason, 32)
        .Integer(x => x.rezHealth, 32);
    }
  }

  [Message(6152, 0x04B3)]
  public record Message04B3
  {
    public uint self { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04B3>()
        .Integer(x => x.self, 32);
    }
  }

  [Message(6152, 0x04B4)]
  public record Message04B4
  {
    public uint challengerId { get; set; }
    public uint opponentId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04B4>()
        .Integer(x => x.challengerId, 32)
        .Integer(x => x.opponentId, 32);
    }
  }

  [Message(6152, 0x04B5)]
  public record Message04B5
  {
    public uint challengerId { get; set; }
    public uint opponentId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04B5>()
        .Integer(x => x.challengerId, 32)
        .Integer(x => x.opponentId, 32);
    }
  }

  [Message(6152, 0x04B6)]
  public record Message04B6
  {
    public uint challengerId { get; set; }
    public uint opponentId { get; set; }
    public uint forfeiterId { get; set; }
    public uint reason { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04B6>()
        .Integer(x => x.challengerId, 32)
        .Integer(x => x.opponentId, 32)
        .Integer(x => x.forfeiterId, 32)
        .Integer(x => x.reason, 2);
    }
  }

  [Message(6152, 0x04B7)]
  public record Message04B7
  {
    public uint challengerId { get; set; }
    public uint opponentId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04B7>()
        .Integer(x => x.challengerId, 32)
        .Integer(x => x.opponentId, 32);
    }
  }

  [Message(6152, 0x04B9)]
  public record Message04B9
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04B9>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x04BA)]
  public record Message04BA
  {
    public uint unitId { get; set; }
    public uint inCombat { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04BA>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.inCombat, 1);
    }
  }

  [Message(6152, 0x04BB)]
  public record Message04BB
  {
    public uint self { get; set; }
    public uint vehicle { get; set; }
    public uint seatType { get; set; }
    public uint seatPosition { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04BB>()
        .Integer(x => x.self, 32)
        .Integer(x => x.vehicle, 32)
        .Integer(x => x.seatType, 32)
        .Integer(x => x.seatPosition, 32);
    }
  }

  [Message(6152, 0x04BD)]
  public record Message04BD
  {
    public uint uniqueId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04BD>()
        .Integer(x => x.uniqueId, 32);
    }
  }

  [Message(6152, 0x04BE)]
  public record Message04BE
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
    public Structure02A[]? masterList { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04BE>()
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

  [Message(6152, 0x04BF)]
  public record Message04BF
  {
    public Structure02A? character { get; set; }
    public uint itemId { get; set; }
    public uint rollType { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04BF>()
        .Structure(x => x.character)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.rollType, 32);
    }
  }

  [Message(6152, 0x04C0)]
  public record Message04C0
  {
    public uint uniqueId { get; set; }
    public Structure0CE? winningRoll { get; set; }
    public uint itemId { get; set; }
    public uint otherRollCount { get; set; }
    public Structure0CE[]? otherRolls { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04C0>()
        .Integer(x => x.uniqueId, 32)
        .Structure(x => x.winningRoll)
        .Integer(x => x.itemId, 32)
        .Integer(x => x.otherRollCount, 32)
        .Array(x => x.otherRolls, x => x.otherRollCount).OfStructure();
    }
  }

  [Message(6152, 0x04C1)]
  public record Message04C1
  {
    public uint unitId { get; set; }
    public uint lootFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04C1>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.lootFlags, 32);
    }
  }

  [Message(6152, 0x04C2)]
  public record Message04C2
  {
    public uint unitId { get; set; }
    public uint looter { get; set; }
    public Structure0CD? lootInfo { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04C2>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.looter, 32)
        .Structure(x => x.lootInfo);
    }
  }

  [Message(6152, 0x04C4)]
  public record Message04C4
  {
    public uint unitId { get; set; }
    public uint noDraw { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04C4>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.noDraw, 1);
    }
  }

  [Message(6152, 0x04C6)]
  public record Message04C6
  {
    public uint self { get; set; }
    public uint infoId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04C6>()
        .Integer(x => x.self, 32)
        .Integer(x => x.infoId, 32);
    }
  }

  [Message(6152, 0x04C7)]
  public record Message04C7
  {
    public uint self { get; set; }
    public uint scanstate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04C7>()
        .Integer(x => x.self, 32)
        .Integer(x => x.scanstate, 32);
    }
  }

  [Message(6152, 0x04C8)]
  public record Message04C8
  {
    public uint self { get; set; }
    public uint infoId { get; set; }
    public uint index { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04C8>()
        .Integer(x => x.self, 32)
        .Integer(x => x.infoId, 32)
        .Integer(x => x.index, 32);
    }
  }

  [Message(6152, 0x04C9)]
  public record Message04C9
  {
    public uint self { get; set; }
    public uint infoId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04C9>()
        .Integer(x => x.self, 32)
        .Integer(x => x.infoId, 32);
    }
  }

  [Message(6152, 0x04CA)]
  public record Message04CA
  {
    public uint self { get; set; }
    public uint groupId { get; set; }
    public uint remainingTimeMs { get; set; }
    public string? currentOwner { get; set; }
    public uint tierCount { get; set; }
    public Structure003[]? tiers { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04CA>()
        .Integer(x => x.self, 32)
        .Integer(x => x.groupId, 32)
        .Integer(x => x.remainingTimeMs, 32)
        .String(x => x.currentOwner, true)
        .Integer(x => x.tierCount, 32)
        .Array(x => x.tiers, x => x.tierCount).OfStructure();
    }
  }

  [Message(6152, 0x04CB)]
  public record Message04CB
  {
    public uint hub { get; set; }
    public uint[]? values { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04CB>()
        .Integer(x => x.hub, 32)
        .Array(x => x.values, 3).OfInteger(32);
    }
  }

  [Message(6152, 0x04CC)]
  public record Message04CC
  {
    public uint self { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04CC>()
        .Integer(x => x.self, 32)
        .Integer(x => x.type, 32);
    }
  }

  [Message(6152, 0x04CE)]
  public record Message04CE
  {
    public uint unitId { get; set; }
    public uint objectCount { get; set; }
    public Structure00F[]? objects { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04CE>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.objectCount, 32)
        .Array(x => x.objects, x => x.objectCount).OfStructure();
    }
  }

  [Message(6152, 0x04CF)]
  public record Message04CF
  {
    public uint unitId { get; set; }
    public uint objectId { get; set; }
    public uint type { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04CF>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.objectId, 32)
        .Integer(x => x.type, 3);
    }
  }

  [Message(6152, 0x04D0)]
  public record Message04D0
  {
    public uint unitId { get; set; }
    public uint pvpFlags { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04D0>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.pvpFlags, 32);
    }
  }

  [Message(6152, 0x04D6)]
  public record Message04D6
  {
    public uint self { get; set; }
    public uint passenger { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04D6>()
        .Integer(x => x.self, 32)
        .Integer(x => x.passenger, 32);
    }
  }

  [Message(6152, 0x04DB)]
  public record Message04DB
  {
    public uint unitId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04DB>()
        .Integer(x => x.unitId, 32)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x04E0)]
  public record Message04E0
  {
    public uint unitId { get; set; }
    public uint difficultyLevel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04E0>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.difficultyLevel, 32);
    }
  }

  [Message(6152, 0x04E3)]
  public record Message04E3
  {
    public uint unitId { get; set; }
    public uint factionIdOverride { get; set; }
    public float factionValue { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04E3>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.factionIdOverride, 32)
        .Float(x => x.factionValue);
    }
  }

  [Message(6152, 0x04F6)]
  public record Message04F6
  {
    public uint unitId { get; set; }
    public uint state { get; set; }
    public uint value { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04F6>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.state, 5)
        .Integer(x => x.value, 32);
    }
  }

  [Message(6152, 0x04F7)]
  public record Message04F7
  {
    public uint unitId { get; set; }
    public uint stealthed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04F7>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.stealthed, 1);
    }
  }

  [Message(6152, 0x04FD)]
  public record Message04FD
  {
    public uint unitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04FD>()
        .Integer(x => x.unitId, 32);
    }
  }

  [Message(6152, 0x04FE)]
  public record Message04FE
  {
    public uint self { get; set; }
    public uint race { get; set; }
    public uint sex { get; set; }
    public uint creatureId { get; set; }
    public uint displayInfoId { get; set; }
    public uint outfitInfoId { get; set; }
    public float scale { get; set; }
    public uint itemCount { get; set; }
    public Structure020[]? items { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message04FE>()
        .Integer(x => x.self, 32)
        .Integer(x => x.race, 5)
        .Integer(x => x.sex, 2)
        .Integer(x => x.creatureId, 32)
        .Integer(x => x.displayInfoId, 32)
        .Integer(x => x.outfitInfoId, 32)
        .Float(x => x.scale)
        .Integer(x => x.itemCount, 32)
        .Array(x => x.items, x => x.itemCount).OfStructure();
    }
  }

  [Message(6152, 0x0500)]
  public record Message0500
  {
    public uint unitId { get; set; }
    public uint newTargetId { get; set; }
    public uint threatLevel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0500>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.newTargetId, 32)
        .Integer(x => x.threatLevel, 32);
    }
  }

  [Message(6152, 0x0501)]
  public record Message0501
  {
    public uint srcUnitId { get; set; }
    public uint[]? threatUnitIds { get; set; }
    public uint[]? threatLevels { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0501>()
        .Integer(x => x.srcUnitId, 32)
        .Array(x => x.threatUnitIds, 5).OfInteger(32)
        .Array(x => x.threatLevels, 5).OfInteger(32);
    }
  }

  [Message(6152, 0x0502)]
  public record Message0502
  {
    public uint unitId { get; set; }
    public uint targetId { get; set; }
    public uint threatLevel { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0502>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.targetId, 32)
        .Integer(x => x.threatLevel, 32);
    }
  }

  [Message(6152, 0x0503)]
  public record Message0503
  {
    public uint unitId { get; set; }
    public uint groupCount { get; set; }
    public Structure0B1[]? vendorGroups { get; set; }
    public uint itemCount { get; set; }
    public Structure0B2[]? vendorItems { get; set; }
    public float buyMultiplier { get; set; }
    public float sellMultiplier { get; set; }
    public uint initialList { get; set; }
    public uint failed { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0503>()
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

  [Message(6152, 0x0505)]
  public record Message0505
  {
    public uint spellId { get; set; }
    public uint abilityChargeCount { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0505>()
        .Integer(x => x.spellId, 32)
        .Integer(x => x.abilityChargeCount, 32);
    }
  }

  [Message(6152, 0x0506)]
  public record Message0506
  {
    public uint numSlots { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0506>()
        .Integer(x => x.numSlots, 32);
    }
  }

  [Message(6152, 0x0507)]
  public record Message0507
  {
    public uint stat { get; set; }
    public ulong newValue { get; set; }
    public uint combatRewardId { get; set; }
    public uint targetUnitId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0507>()
        .Integer(x => x.stat, 5)
        .Integer(x => x.newValue, 64)
        .Integer(x => x.combatRewardId, 32)
        .Integer(x => x.targetUnitId, 32);
    }
  }

  [Message(6152, 0x0510)]
  public record Message0510
  {
    public uint unitId { get; set; }
    public uint clusterId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0510>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.clusterId, 32);
    }
  }

  [Message(6152, 0x0511)]
  public record Message0511
  {
    public uint unitId { get; set; }
    public uint equipmentCount { get; set; }
    public Structure020[]? equipment { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0511>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.equipmentCount, 32)
        .Array(x => x.equipment, x => x.equipmentCount).OfStructure();
    }
  }

  [Message(6152, 0x0512)]
  public record Message0512
  {
    public uint unitId { get; set; }
    public uint factionId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0512>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.factionId, 32);
    }
  }

  [Message(6152, 0x0513)]
  public record Message0513
  {
    public uint unitId { get; set; }
    public ulong groupId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0513>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.groupId, 64);
    }
  }

  [Message(6152, 0x0514)]
  public record Message0514
  {
    public uint unitId { get; set; }
    public string? name { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0514>()
        .Integer(x => x.unitId, 32)
        .String(x => x.name, true);
    }
  }

  [Message(6152, 0x0515)]
  public record Message0515
  {
    public uint unitId { get; set; }
    public uint propertyCount { get; set; }
    public Structure0AF[]? properties { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0515>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.propertyCount, 32)
        .Array(x => x.properties, x => x.propertyCount).OfStructure();
    }
  }

  [Message(6152, 0x0516)]
  public record Message0516
  {
    public uint unitId { get; set; }
    public uint checklistIdx { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0516>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.checklistIdx, 32);
    }
  }

  [Message(6152, 0x0517)]
  public record Message0517
  {
    public uint unitId { get; set; }
    public uint stat { get; set; }
    public float value { get; set; }
    public float max { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0517>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.stat, 5)
        .Float(x => x.value)
        .Float(x => x.max);
    }
  }

  [Message(6152, 0x0518)]
  public record Message0518
  {
    public uint unitId { get; set; }
    public Structure08D? stat { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0518>()
        .Integer(x => x.unitId, 32)
        .Structure(x => x.stat);
    }
  }

  [Message(6152, 0x0519)]
  public record Message0519
  {
    public uint unitId { get; set; }
    public uint ownerUnitId { get; set; }
    public ulong ownerGroupId { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0519>()
        .Integer(x => x.unitId, 32)
        .Integer(x => x.ownerUnitId, 32)
        .Integer(x => x.ownerGroupId, 64);
    }
  }

  [Message(6152, 0x051A)]
  public record Message051A
  {
    public uint clientUniqueId { get; set; }
    public Structure034? location { get; set; }
    public uint targetUnitId { get; set; }
    public Structure034? targetLocation { get; set; }
    public Structure015? position { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message051A>()
        .Integer(x => x.clientUniqueId, 32)
        .Structure(x => x.location)
        .Integer(x => x.targetUnitId, 32)
        .Structure(x => x.targetLocation)
        .Structure(x => x.position);
    }
  }

  [Message(6152, 0x0524)]
  public record Message0524
  {
    public uint constraintCount { get; set; }
    public Structure016[]? constraints { get; set; }
    public uint orCount { get; set; }
    public uint[]? orIndices { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0524>()
        .Integer(x => x.constraintCount, 32)
        .Array(x => x.constraints, x => x.constraintCount).OfStructure()
        .Integer(x => x.orCount, 32)
        .Array(x => x.orIndices, x => x.orCount).OfInteger(32);
    }
  }

  [Message(6152, 0x0525)]
  public record Message0525
  {
    public uint resultCount { get; set; }
    public Structure01F[]? results { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message0525>()
        .Integer(x => x.resultCount, 32)
        .Array(x => x.results, x => x.resultCount).OfStructure();
    }
  }

  [Message(6152, 0x052B)]
  public record Message052B
  {
    public uint targetUnitId { get; set; }
    public float meter { get; set; }
    public float successThreshold { get; set; }
    public float failureThreshold { get; set; }
    public uint rangeBand { get; set; }
    public float rate { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message052B>()
        .Integer(x => x.targetUnitId, 32)
        .Float(x => x.meter)
        .Float(x => x.successThreshold)
        .Float(x => x.failureThreshold)
        .Integer(x => x.rangeBand, 32)
        .Float(x => x.rate);
    }
  }

  [Message(6152, 0x052D)]
  public record Message052D
  {
    public uint hexGroupId { get; set; }
    public uint tooltipStringId { get; set; }
    public uint color { get; set; }
    public uint visible { get; set; }

    public static void Build(IMessageBuilder builder)
    {
      builder.FieldsOf<Message052D>()
        .Integer(x => x.hexGroupId, 32)
        .Integer(x => x.tooltipStringId, 32)
        .Integer(x => x.color, 32)
        .Integer(x => x.visible, 1);
    }
  }

}
