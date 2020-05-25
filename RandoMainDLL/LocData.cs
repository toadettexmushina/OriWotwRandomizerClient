﻿using System.Collections.Generic;
using RandoMainDLL.Memory;
namespace RandoMainDLL {
  public enum LocType {
    SpiritLight = 0,
    Shard = 1,
    Health = 2,
    Energy = 3,
    Ore = 4,
    ShardSlot = 5,
    Keystone = 6,
    Eyestone = 7,
    Quest = 8,
    Tree = 9,
    Shop = 10,
    Unknown = 15
  }
  public class LocData {
    public ZoneType Zone;
    public LocType Type;
    public LocData(ZoneType zone, LocType type) { Zone = zone; Type = type; }
    public static LocData Void = new LocData(ZoneType.Void, LocType.Unknown);

  }
  public static class LocDataStaticHelper {
    public static LocData Loc(this UberId uid) => All.GetOrElse(uid, LocData.Void);
    public static Dictionary<UberId, LocData> All = new Dictionary<UberId, LocData>() {
      {new UberId(21786, 60210), new LocData(ZoneType.Marsh, LocType.Health)},
      {new UberId(21786, 49485), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(21786, 25761), new LocData(ZoneType.Marsh, LocType.Health)},
      {new UberId(21786, 6987), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(23987, 59173), new LocData(ZoneType.Marsh, LocType.Shard)},
      {new UberId(21786, 29892), new LocData(ZoneType.Marsh, LocType.Ore)},
      {new UberId(21786, 7152), new LocData(ZoneType.Marsh, LocType.Energy)},
      {new UberId(9593, 5929), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(48248, 18767), new LocData(ZoneType.Marsh, LocType.Shop)},
      {new UberId(0, 77), new LocData(ZoneType.Marsh, LocType.Tree)},
      {new UberId(21786, 17920), new LocData(ZoneType.Marsh, LocType.Energy)},
      {new UberId(21786, 59513), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(9593, 42047), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(21786, 64677), new LocData(ZoneType.Marsh, LocType.Keystone)},
      {new UberId(9593, 23858), new LocData(ZoneType.Marsh, LocType.Ore)},
      {new UberId(21786, 23154), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(9593, 20382), new LocData(ZoneType.Marsh, LocType.Ore)},
      {new UberId(23987, 50415), new LocData(ZoneType.Marsh, LocType.Shard)},
      {new UberId(24922, 32076), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(24922, 62138), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(23987, 9864), new LocData(ZoneType.Marsh, LocType.Shard)},
      {new UberId(21786, 61706), new LocData(ZoneType.Marsh, LocType.Energy)},
      {new UberId(14019, 27539), new LocData(ZoneType.Marsh, LocType.Quest)},
      {new UberId(0, 121), new LocData(ZoneType.Marsh, LocType.Tree)},
      {new UberId(24922, 60358), new LocData(ZoneType.Burrows, LocType.Keystone)},
      {new UberId(24922, 47244), new LocData(ZoneType.Burrows, LocType.Keystone)},
      {new UberId(24922, 34250), new LocData(ZoneType.Burrows, LocType.Keystone)},
      {new UberId(24922, 33535), new LocData(ZoneType.Burrows, LocType.Keystone)},
      {new UberId(48248, 45538), new LocData(ZoneType.Burrows, LocType.Shop)},
      {new UberId(24922, 46311), new LocData(ZoneType.Burrows, LocType.Shard)},
      {new UberId(14019, 52747), new LocData(ZoneType.Burrows, LocType.Quest)},
      {new UberId(21786, 43668), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(21786, 28908), new LocData(ZoneType.Marsh, LocType.Health)},
      {new UberId(9593, 61304), new LocData(ZoneType.Marsh, LocType.Health)},
      {new UberId(21786, 22068), new LocData(ZoneType.Marsh, LocType.Keystone)},
      {new UberId(21786, 63545), new LocData(ZoneType.Marsh, LocType.Shard)},
      {new UberId(0, 100), new LocData(ZoneType.Marsh, LocType.Tree)},
      {new UberId(21786, 2046), new LocData(ZoneType.Marsh, LocType.Ore)},
      {new UberId(21786, 16206), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(21786, 2852), new LocData(ZoneType.Marsh, LocType.Keystone)},
      {new UberId(24922, 13993), new LocData(ZoneType.Marsh, LocType.ShardSlot)},
      {new UberId(9593, 17818), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(23987, 27134), new LocData(ZoneType.Marsh, LocType.Shard)},
      {new UberId(0, 5), new LocData(ZoneType.Marsh, LocType.Tree)},
      {new UberId(9593, 5253), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(9593, 25989), new LocData(ZoneType.Marsh, LocType.Ore)},
      {new UberId(9593, 27562), new LocData(ZoneType.Marsh, LocType.Energy)},
      {new UberId(21786, 20194), new LocData(ZoneType.Marsh, LocType.Health)},
      {new UberId(21786, 10413), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(21786, 18109), new LocData(ZoneType.Marsh, LocType.ShardSlot)},
      {new UberId(9593, 59344), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(21786, 27433), new LocData(ZoneType.Marsh, LocType.Eyestone)},
      {new UberId(21786, 37225), new LocData(ZoneType.Marsh, LocType.Eyestone)},
      {new UberId(21786, 10295), new LocData(ZoneType.Marsh, LocType.Energy)},
      {new UberId(0, 97), new LocData(ZoneType.Marsh, LocType.Tree)},
      {new UberId(21786, 50255), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(9593, 26457), new LocData(ZoneType.Marsh, LocType.Energy)},
      {new UberId(945, 10833), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(937, 61897), new LocData(ZoneType.Hollow, LocType.Health)},
      {new UberId(937, 16163), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 2538), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 8518), new LocData(ZoneType.Hollow, LocType.Energy)},
      {new UberId(23987, 61017), new LocData(ZoneType.Hollow, LocType.Shard)},
      {new UberId(937, 24175), new LocData(ZoneType.Hollow, LocType.Energy)},
      {new UberId(48248, 3638), new LocData(ZoneType.Hollow, LocType.Shop)},
      {new UberId(937, 2463), new LocData(ZoneType.Hollow, LocType.Health)},
      {new UberId(937, 48192), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 61744), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 37926), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 50176), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(0, 102), new LocData(ZoneType.Hollow, LocType.Tree)},
      {new UberId(937, 10729), new LocData(ZoneType.Hollow, LocType.Ore)},
      {new UberId(937, 13413), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 5568), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 45987), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 19529), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(937, 23772), new LocData(ZoneType.Hollow, LocType.Energy)},
      {new UberId(13428, 59730), new LocData(ZoneType.Hollow, LocType.Health)},
      {new UberId(937, 30182), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(0, 0), new LocData(ZoneType.Hollow, LocType.Tree)},
      {new UberId(58674, 20983), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(58674, 9583), new LocData(ZoneType.Hollow, LocType.Energy)},
      {new UberId(23987, 62973), new LocData(ZoneType.Hollow, LocType.Shard)},
      {new UberId(46462, 37897), new LocData(ZoneType.Hollow, LocType.Ore)},
      {new UberId(46462, 29054), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(46462, 20780), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(18793, 42980), new LocData(ZoneType.Hollow, LocType.SpiritLight)},
      {new UberId(14019, 2782), new LocData(ZoneType.Glades, LocType.Quest)},
      {new UberId(42178, 52786), new LocData(ZoneType.Glades, LocType.Energy)},
      {new UberId(44310, 29043), new LocData(ZoneType.Glades, LocType.Health)},
      {new UberId(44310, 17523), new LocData(ZoneType.Glades, LocType.Health)},
      {new UberId(42178, 23125), new LocData(ZoneType.Glades, LocType.Ore)},
      {new UberId(42178, 27110), new LocData(ZoneType.Glades, LocType.Ore)},
      {new UberId(23987, 23015), new LocData(ZoneType.Glades, LocType.Shard)},
      {new UberId(23987, 14014), new LocData(ZoneType.Glades, LocType.Shard)},
      {new UberId(42178, 51468), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 13327), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 57455), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 30520), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 59623), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 9780), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 18448), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 6117), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 51934), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 42762), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 30206), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 37028), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 63404), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(42178, 44748), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(0, 120), new LocData(ZoneType.Glades, LocType.Tree)},
      {new UberId(53632, 12019), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(937, 31036), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(937, 40657), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(937, 45744), new LocData(ZoneType.Glades, LocType.SpiritLight)},
      {new UberId(937, 17761), new LocData(ZoneType.Glades, LocType.Energy)},
      {new UberId(937, 6703), new LocData(ZoneType.Glades, LocType.Ore)},
      {new UberId(937, 11846), new LocData(ZoneType.Glades, LocType.Ore)},
      {new UberId(44310, 36911), new LocData(ZoneType.Glades, LocType.Health)},
      {new UberId(44310, 9902), new LocData(ZoneType.Glades, LocType.ShardSlot)},
      {new UberId(53632, 25556), new LocData(ZoneType.Wellspring, LocType.Ore)},
      {new UberId(53632, 1911), new LocData(ZoneType.Wellspring, LocType.Energy)},
      {new UberId(53632, 51706), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 58286), new LocData(ZoneType.Wellspring, LocType.Ore)},
      {new UberId(23987, 12104), new LocData(ZoneType.Wellspring, LocType.Shard)},
      {new UberId(53632, 17403), new LocData(ZoneType.Wellspring, LocType.Health)},
      {new UberId(53632, 42264), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(53632, 6500), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(53632, 6869), new LocData(ZoneType.Wellspring, LocType.Energy)},
      {new UberId(23987, 53934), new LocData(ZoneType.Wellspring, LocType.Shard)},
      {new UberId(53632, 62356), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(53632, 21124), new LocData(ZoneType.Wellspring, LocType.Ore)},
      {new UberId(23987, 31426), new LocData(ZoneType.Wellspring, LocType.Shard)},
      {new UberId(37858, 22107), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 45906), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 45656), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 25833), new LocData(ZoneType.Wellspring, LocType.Health)},
      {new UberId(37858, 41380), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 58846), new LocData(ZoneType.Wellspring, LocType.Ore)},
      {new UberId(37858, 57552), new LocData(ZoneType.Wellspring, LocType.Energy)},
      {new UberId(37858, 41911), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(48248, 1590), new LocData(ZoneType.Wellspring, LocType.Shop)},
      {new UberId(37858, 33063), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 31136), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(0, 57), new LocData(ZoneType.Wellspring, LocType.Tree)},
      {new UberId(37858, 64086), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 52110), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 47533), new LocData(ZoneType.Wellspring, LocType.Ore)},
      {new UberId(53632, 41227), new LocData(ZoneType.Wellspring, LocType.Quest)},
      {new UberId(37858, 59022), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(37858, 2797), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(14019, 24142), new LocData(ZoneType.Wellspring, LocType.Quest)},
      {new UberId(37858, 32932), new LocData(ZoneType.Wellspring, LocType.Ore)},
      {new UberId(37858, 56444), new LocData(ZoneType.Wellspring, LocType.SpiritLight)},
      {new UberId(945, 10682), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(945, 14530), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(945, 37243), new LocData(ZoneType.Pools, LocType.Health)},
      {new UberId(945, 21334), new LocData(ZoneType.Pools, LocType.Energy)},
      {new UberId(945, 58723), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(21786, 21727), new LocData(ZoneType.Marsh, LocType.SpiritLight)},
      {new UberId(5377, 34852), new LocData(ZoneType.Pools, LocType.Ore)},
      {new UberId(5377, 13832), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 17396), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 27204), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 19694), new LocData(ZoneType.Pools, LocType.Ore)},
      {new UberId(5377, 63201), new LocData(ZoneType.Pools, LocType.Health)},
      {new UberId(5377, 7540), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 12235), new LocData(ZoneType.Pools, LocType.Ore)},
      {new UberId(23987, 25996), new LocData(ZoneType.Pools, LocType.Shard)},
      {new UberId(5377, 45774), new LocData(ZoneType.Pools, LocType.Health)},
      {new UberId(5377, 40328), new LocData(ZoneType.Pools, LocType.Shard)},
      {new UberId(5377, 35440), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(48248, 1557), new LocData(ZoneType.Pools, LocType.Shop)},
      {new UberId(5377, 18345), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(14019, 28662), new LocData(ZoneType.Pools, LocType.Quest)},
      {new UberId(5377, 46926), new LocData(ZoneType.Pools, LocType.Keystone)},
      {new UberId(5377, 35091), new LocData(ZoneType.Pools, LocType.Keystone)},
      {new UberId(5377, 16426), new LocData(ZoneType.Pools, LocType.Keystone)},
      {new UberId(5377, 41881), new LocData(ZoneType.Pools, LocType.Keystone)},
      {new UberId(5377, 33110), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 31434), new LocData(ZoneType.Pools, LocType.Ore)},
      {new UberId(5377, 1600), new LocData(ZoneType.Pools, LocType.Energy)},
      {new UberId(5377, 628), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 21860), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(0, 104), new LocData(ZoneType.Pools, LocType.Tree)},
      {new UberId(5377, 52791), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 33180), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 32750), new LocData(ZoneType.Pools, LocType.Energy)},
      {new UberId(5377, 62180), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 65019), new LocData(ZoneType.Pools, LocType.Ore)},
      {new UberId(5377, 25391), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(5377, 44122), new LocData(ZoneType.Pools, LocType.SpiritLight)},
      {new UberId(58674, 8487), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 28710), new LocData(ZoneType.Woods, LocType.Ore)},
      {new UberId(58674, 22472), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 59691), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 40073), new LocData(ZoneType.Woods, LocType.Keystone)},
      {new UberId(58674, 11736), new LocData(ZoneType.Woods, LocType.Keystone)},
      {new UberId(58674, 43033), new LocData(ZoneType.Woods, LocType.Keystone)},
      {new UberId(58674, 19769), new LocData(ZoneType.Woods, LocType.Keystone)},
      {new UberId(58674, 42531), new LocData(ZoneType.Woods, LocType.Keystone)},
      {new UberId(58674, 780), new LocData(ZoneType.Woods, LocType.Keystone)},
      {new UberId(58674, 26274), new LocData(ZoneType.Woods, LocType.Ore)},
      {new UberId(58674, 42158), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 33893), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 30908), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 59714), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 20713), new LocData(ZoneType.Woods, LocType.Ore)},
      {new UberId(58674, 54516), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 23186), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 64057), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 17974), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(23987, 25183), new LocData(ZoneType.Woods, LocType.Shard)},
      {new UberId(58674, 29265), new LocData(ZoneType.Woods, LocType.ShardSlot)},
      {new UberId(58674, 32647), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(58674, 64484), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(28895, 55384), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 24533), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 3777), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 58675), new LocData(ZoneType.Reach, LocType.Ore)},
      {new UberId(28895, 45337), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 38143), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 47529), new LocData(ZoneType.Reach, LocType.Ore)},
      {new UberId(48248, 29604), new LocData(ZoneType.Reach, LocType.Shop)},
      {new UberId(28895, 4301), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 45066), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 36231), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 38049), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(42178, 40609), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 35045), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 54373), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 40744), new LocData(ZoneType.Reach, LocType.Health)},
      {new UberId(28895, 53283), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 46711), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(23987, 36359), new LocData(ZoneType.Reach, LocType.Shard)},
      {new UberId(28895, 46404), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 29898), new LocData(ZoneType.Reach, LocType.Keystone)},
      {new UberId(28895, 10823), new LocData(ZoneType.Reach, LocType.Keystone)},
      {new UberId(28895, 37444), new LocData(ZoneType.Reach, LocType.Keystone)},
      {new UberId(28895, 18358), new LocData(ZoneType.Reach, LocType.Keystone)},
      {new UberId(28895, 22761), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(23987, 897), new LocData(ZoneType.Reach, LocType.Shard)},
      {new UberId(23987, 19630), new LocData(ZoneType.Reach, LocType.Shard)},
      {new UberId(28287, 32414), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 1053), new LocData(ZoneType.Reach, LocType.Keystone)},
      {new UberId(28895, 50368), new LocData(ZoneType.Reach, LocType.Keystone)},
      {new UberId(28895, 22382), new LocData(ZoneType.Reach, LocType.Keystone)},
      {new UberId(28895, 9949), new LocData(ZoneType.Reach, LocType.Keystone)},
      {new UberId(28895, 23795), new LocData(ZoneType.Reach, LocType.Ore)},
      {new UberId(28895, 40089), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(28895, 40242), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(0, 51), new LocData(ZoneType.Reach, LocType.Tree)},
      {new UberId(28895, 39291), new LocData(ZoneType.Reach, LocType.Ore)},
      {new UberId(28895, 7597), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(14019, 32376), new LocData(ZoneType.Reach, LocType.Quest)},
      {new UberId(28895, 2129), new LocData(ZoneType.Reach, LocType.SpiritLight)},
      {new UberId(18793, 19004), new LocData(ZoneType.Depths, LocType.SpiritLight)},
      {new UberId(18793, 15396), new LocData(ZoneType.Depths, LocType.SpiritLight)},
      {new UberId(18793, 35351), new LocData(ZoneType.Depths, LocType.Ore)},
      {new UberId(18793, 1914), new LocData(ZoneType.Depths, LocType.Keystone)},
      {new UberId(18793, 58148), new LocData(ZoneType.Depths, LocType.Keystone)},
      {new UberId(18793, 26618), new LocData(ZoneType.Depths, LocType.Energy)},
      {new UberId(18793, 29979), new LocData(ZoneType.Depths, LocType.SpiritLight)},
      {new UberId(18793, 53953), new LocData(ZoneType.Depths, LocType.Keystone)},
      {new UberId(18793, 23986), new LocData(ZoneType.Depths, LocType.Keystone)},
      {new UberId(14019, 8192), new LocData(ZoneType.Depths, LocType.Quest)},
      {new UberId(18793, 18395), new LocData(ZoneType.Depths, LocType.SpiritLight)},
      {new UberId(18793, 42235), new LocData(ZoneType.Depths, LocType.Health)},
      {new UberId(18793, 6573), new LocData(ZoneType.Depths, LocType.SpiritLight)},
      {new UberId(18793, 62694), new LocData(ZoneType.Depths, LocType.Health)},
      {new UberId(18793, 836), new LocData(ZoneType.Depths, LocType.Ore)},
      {new UberId(23987, 986), new LocData(ZoneType.Depths, LocType.Shard)},
      {new UberId(18793, 31937), new LocData(ZoneType.Depths, LocType.ShardSlot)},
      {new UberId(18793, 28175), new LocData(ZoneType.Depths, LocType.Energy)},
      {new UberId(48248, 48423), new LocData(ZoneType.Depths, LocType.Shop)},
      {new UberId(18793, 2881), new LocData(ZoneType.Depths, LocType.SpiritLight)},
      {new UberId(18793, 23799), new LocData(ZoneType.Depths, LocType.SpiritLight)},
      {new UberId(0, 62), new LocData(ZoneType.Depths, LocType.Tree)},
      {new UberId(7228, 54494), new LocData(ZoneType.Wastes, LocType.Ore)},
      {new UberId(7228, 56821), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(7228, 52086), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 46919), new LocData(ZoneType.Wastes, LocType.Ore)},
      {new UberId(20120, 11785), new LocData(ZoneType.Wastes, LocType.Energy)},
      {new UberId(20120, 62264), new LocData(ZoneType.Wastes, LocType.Health)},
      {new UberId(20120, 57781), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 10397), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 224), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 12941), new LocData(ZoneType.Wastes, LocType.Health)},
      {new UberId(23987, 50364), new LocData(ZoneType.Wastes, LocType.Shard)},
      {new UberId(20120, 33275), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 57133), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 8910), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(48248, 61146), new LocData(ZoneType.Wastes, LocType.Shop)},
      {new UberId(0, 101), new LocData(ZoneType.Wastes, LocType.Tree)},
      {new UberId(20120, 19113), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 50026), new LocData(ZoneType.Wastes, LocType.Energy)},
      {new UberId(20120, 48829), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 17798), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 59046), new LocData(ZoneType.Wastes, LocType.Health)},
      {new UberId(20120, 40245), new LocData(ZoneType.Wastes, LocType.Ore)},
      {new UberId(7228, 20282), new LocData(ZoneType.Wastes, LocType.Keystone)},
      {new UberId(7228, 62117), new LocData(ZoneType.Wastes, LocType.Keystone)},
      {new UberId(23987, 48605), new LocData(ZoneType.Wastes, LocType.Shard)},
      {new UberId(7228, 35329), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 22354), new LocData(ZoneType.Wastes, LocType.Energy)},
      {new UberId(20120, 30740), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 52812), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(20120, 18965), new LocData(ZoneType.Wastes, LocType.Health)},
      {new UberId(20120, 2013), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(7228, 54275), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(7228, 48993), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(7228, 61548), new LocData(ZoneType.Wastes, LocType.SpiritLight)},
      {new UberId(14019, 20601), new LocData(ZoneType.Wastes, LocType.Quest)},
      {new UberId(7228, 8370), new LocData(ZoneType.Wastes, LocType.Ore)},
      {new UberId(10289, 44555), new LocData(ZoneType.Ruins, LocType.Energy)},
      {new UberId(36153, 3013), new LocData(ZoneType.Woods, LocType.Ore)},
      {new UberId(0, 8), new LocData(ZoneType.Woods, LocType.Tree)},
      {new UberId(36153, 36521), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(36153, 12077), new LocData(ZoneType.Woods, LocType.SpiritLight)},
      {new UberId(16155, 38979), new LocData(ZoneType.Ruins, LocType.Ore)},
      {new UberId(16155, 49381), new LocData(ZoneType.Ruins, LocType.SpiritLight)},
      {new UberId(16155, 46270), new LocData(ZoneType.Ruins, LocType.Health)},
      {new UberId(48248, 4045), new LocData(ZoneType.Ruins, LocType.Shop)},
      {new UberId(16155, 9230), new LocData(ZoneType.Ruins, LocType.Ore)},
      {new UberId(16155, 55446), new LocData(ZoneType.Ruins, LocType.SpiritLight)},
      {new UberId(36153, 23902), new LocData(ZoneType.Ruins, LocType.SpiritLight)},
      {new UberId(36153, 3662), new LocData(ZoneType.Ruins, LocType.SpiritLight)},
      {new UberId(2, 1), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(2, 2), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(2, 3), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(2, 5), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(2, 19), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(2, 22), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(2, 26), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(2, 40), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(1, 23), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(1, 74), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(1, 98), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(1, 105), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(1, 106), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(1, 115), new LocData(ZoneType.Glades, LocType.Shop)},
      {new UberId(1, 116), new LocData(ZoneType.Glades, LocType.Shop)},
  };

  }
}
