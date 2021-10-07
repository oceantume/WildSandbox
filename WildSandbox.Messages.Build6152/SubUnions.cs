using System;
using WildSandbox.Common.Messages;

namespace WildSandbox.Messages.Build6152
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
    public Structure018? race { get; set; }
    public Structure019? path { get; set; }
    public Structure01A? playerClass { get; set; }
    public Structure01B? zone { get; set; }
    public Structure01C? guild { get; set; }
    public Structure01D? player { get; set; }
    public Structure01E? subString { get; set; }
  }

  public record Union003
  {
    public Structure024? creature { get; set; }
    public Structure025? @string { get; set; }
    public Structure026? textid { get; set; }
    public Structure027? playerunit { get; set; }
    public Structure028? creatureunit { get; set; }
    public Structure029? localplayer { get; set; }
  }

  public record Union004
  {
    public Structure048? integer { get; set; }
    public Structure049? str { get; set; }
    public Structure04A? unit { get; set; }
    public Structure04B? boolean { get; set; }
    public Structure04C? itemdata { get; set; }
    public Structure04D? quest { get; set; }
  }

  public record Union005
  {
    public Structure061? empty { get; set; }
    public Structure062? damageDesc { get; set; }
  }

  public record Union006
  {
    public Structure06A? nonPlayer { get; set; }
    public Structure06B? chest { get; set; }
    public Structure06C? destructible { get; set; }
    public Structure06D? vehicle { get; set; }
    public Structure06F? door { get; set; }
    public Structure070? harvestUnit { get; set; }
    public Structure071? corpseUnit { get; set; }
    public Structure072? mount { get; set; }
    public Structure073? collectableUnit { get; set; }
    public Structure074? taxi { get; set; }
    public Structure075? simple { get; set; }
    public Structure076? platform { get; set; }
    public Structure077? mailBox { get; set; }
    public Structure078? aiTurret { get; set; }
    public Structure079? instancePortal { get; set; }
    public Structure07A? plug { get; set; }
    public Structure07B? residence { get; set; }
    public Structure07C? structuredPlug { get; set; }
    public Structure07D? pinataLoot { get; set; }
    public Structure07E? bindPoint { get; set; }
    public Structure07F? player { get; set; }
    public Structure080? hidden { get; set; }
    public Structure081? trigger { get; set; }
    public Structure083? ghost { get; set; }
    public Structure084? pet { get; set; }
    public Structure085? esperPet { get; set; }
    public Structure086? worldUnit { get; set; }
    public Structure087? scannerUnit { get; set; }
    public Structure088? camera { get; set; }
    public Structure089? trap { get; set; }
    public Structure08A? destructibledoor { get; set; }
    public Structure08B? pickup { get; set; }
    public Structure08C? simpleCollidable { get; set; }
  }

  public record Union007
  {
    public Structure08F? setTime { get; set; }
    public Structure090? setPlatform { get; set; }
    public Structure091? setPosition { get; set; }
    public Structure093? setPositionKeys { get; set; }
    public Structure094? setPositionPath { get; set; }
    public Structure095? setPositionSpline { get; set; }
    public Structure096? setPositionMultiSpline { get; set; }
    public Structure097? setPositionProjectile { get; set; }
    public Structure098? setVelocity { get; set; }
    public Structure099? setVelocityKeys { get; set; }
    public Structure09A? setVelocityDefault { get; set; }
    public Structure09B? setMove { get; set; }
    public Structure09C? setMoveKeys { get; set; }
    public Structure09D? setMoveDefault { get; set; }
    public Structure09E? setRotation { get; set; }
    public Structure0A0? setRotationKeys { get; set; }
    public Structure0A1? setRotationSpline { get; set; }
    public Structure0A2? setRotationMultiSpline { get; set; }
    public Structure0A3? setRotationFaceUnit { get; set; }
    public Structure0A4? setRotationFacePosition { get; set; }
    public Structure0A5? setRotationSpin { get; set; }
    public Structure0A6? setRotationDefault { get; set; }
    public Structure0A7? setScale { get; set; }
    public Structure0A8? setScaleKeys { get; set; }
    public Structure0A9? setState { get; set; }
    public Structure0AA? setStateKeys { get; set; }
    public Structure0AB? setStateDefault { get; set; }
    public Structure0AC? setMode { get; set; }
    public Structure0AD? setModeKeys { get; set; }
    public Structure0AE? setModeDefault { get; set; }
  }

}
