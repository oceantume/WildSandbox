using System;
using WildSandbox.Common.Messages;

namespace WildSandbox.Messages.Build6072
{
  public record Union001
  {
    public Structure005? empty { get; set; }
    public Structure006? capturePointDefendObjective { get; set; }
    public Structure007? capturePointObjective { get; set; }
    public Structure008? virtualItemDepotObjective { get; set; }
  }

  public record Union002
  {
    public Structure017? levelRange { get; set; }
    public Structure018? subString { get; set; }
  }

  public record Union003
  {
    public Structure01E? creature { get; set; }
    public Structure01F? @string { get; set; }
    public Structure020? textid { get; set; }
    public Structure021? playerunit { get; set; }
    public Structure022? creatureunit { get; set; }
    public Structure023? localplayer { get; set; }
  }

  public record Union004
  {
    public Structure03F? integer { get; set; }
    public Structure040? str { get; set; }
    public Structure041? unit { get; set; }
    public Structure042? boolean { get; set; }
    public Structure043? itemdata { get; set; }
    public Structure044? quest { get; set; }
  }

  public record Union005
  {
    public Structure056? empty { get; set; }
    public Structure057? damageDesc { get; set; }
  }

  public record Union006
  {
    public Structure05F? nonPlayer { get; set; }
    public Structure060? chest { get; set; }
    public Structure061? destructible { get; set; }
    public Structure062? vehicle { get; set; }
    public Structure064? door { get; set; }
    public Structure065? harvestUnit { get; set; }
    public Structure066? corpseUnit { get; set; }
    public Structure067? mount { get; set; }
    public Structure068? collectableUnit { get; set; }
    public Structure069? taxi { get; set; }
    public Structure06A? simple { get; set; }
    public Structure06B? platform { get; set; }
    public Structure06C? mailBox { get; set; }
    public Structure06D? aiTurret { get; set; }
    public Structure06E? instancePortal { get; set; }
    public Structure06F? plug { get; set; }
    public Structure070? residence { get; set; }
    public Structure071? pinataLoot { get; set; }
    public Structure072? bindPoint { get; set; }
    public Structure073? player { get; set; }
    public Structure074? hidden { get; set; }
    public Structure075? trigger { get; set; }
    public Structure077? ghost { get; set; }
    public Structure078? pet { get; set; }
    public Structure079? esperPet { get; set; }
    public Structure07A? worldUnit { get; set; }
    public Structure07B? scannerUnit { get; set; }
    public Structure07C? camera { get; set; }
    public Structure07D? trap { get; set; }
    public Structure07E? destructibledoor { get; set; }
    public Structure07F? pickup { get; set; }
    public Structure080? simpleCollidable { get; set; }
  }

  public record Union007
  {
    public Structure083? setTime { get; set; }
    public Structure084? setPlatform { get; set; }
    public Structure085? setPosition { get; set; }
    public Structure087? setPositionKeys { get; set; }
    public Structure088? setPositionPath { get; set; }
    public Structure089? setPositionSpline { get; set; }
    public Structure08A? setPositionProjectile { get; set; }
    public Structure08B? setVelocity { get; set; }
    public Structure08C? setVelocityKeys { get; set; }
    public Structure08D? setVelocityDefault { get; set; }
    public Structure08E? setMove { get; set; }
    public Structure08F? setMoveKeys { get; set; }
    public Structure090? setMoveDefault { get; set; }
    public Structure091? setRotation { get; set; }
    public Structure093? setRotationKeys { get; set; }
    public Structure094? setRotationSpline { get; set; }
    public Structure095? setRotationFaceUnit { get; set; }
    public Structure096? setRotationFacePosition { get; set; }
    public Structure097? setRotationSpin { get; set; }
    public Structure098? setRotationDefault { get; set; }
    public Structure099? setScale { get; set; }
    public Structure09A? setScaleKeys { get; set; }
    public Structure09B? setState { get; set; }
    public Structure09C? setStateKeys { get; set; }
    public Structure09D? setStateDefault { get; set; }
    public Structure09E? setMode { get; set; }
    public Structure09F? setModeKeys { get; set; }
    public Structure0A0? setModeDefault { get; set; }
  }

}
