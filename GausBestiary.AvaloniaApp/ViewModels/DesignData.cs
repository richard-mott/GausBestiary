using System.Collections.Generic;
using GausBestiary.AvaloniaApp.ViewModels.MonsterDetails;
using GausBestiary.Models;
using GausBestiary.Models.ChanceEvents;
using GausBestiary.Models.MonsterDetails;

namespace GausBestiary.AvaloniaApp.ViewModels;

public static class DesignData
{
    private static readonly Monster Monster = new Monster
    {
        MonsterId = 1,
        SnesId = 1,
        PlayStationId = 1,
        GbaId = 1,
        MobileId = 1,
        PixelRemasterId = 1,

        SnesName = "Design Monster",
        PlayStationName = "Design Monster",
        GbaName = "Design Monster",
        MobileName = "Design Monster",
        PixelRemasterName = "Design Monster",

        Locations = new List<Location>
        {
            new Location
            {
                World = World.WoB,
                PrimaryLocation = "Narshe",
                SecondaryLocations = new List<string> { "Biggs/Wedge/Terra raid", "Terra/Edgar/Banon scenario"}
            },
            new Location
            {
                World = World.WoB,
                PrimaryLocation = "South Figaro Overworld",
                SecondaryLocations = new List<string> { "Biggs/Wedge/Terra raid", "Terra/Edgar/Banon scenario"}
            },
            new Location
            {
                World = World.WoR,
                PrimaryLocation = "South Figaro Overworld",
                SecondaryLocations = new List<string> { "Biggs/Wedge/Terra raid", "Terra/Edgar/Banon scenario"}
            }
        },

        Stats = new Stats
        {
            Level = 1,
            HitPoints = 100,
            MagicPoints = 30,

            Attack = 35,
            Defense = 110,
            Evasion = 0,

            Magic = 12,
            MagicDefense = 40,
            MagicEvasion = 10,

            Speed = 25
        },

        Defenses = new Defenses
        {
            ElementalWeakness = Element.Fire | Element.Ice | Element.Lightning,
            ElementalImmunity = Element.Earth | Element.Holy,
            ElementalAbsorb = Element.Water | Element.Poison,

            InherentStatus = Status.Haste | Status.Regen,
            StatusVulnerability = Status.Imp | Status.Berserk,
            StatusImmunity = Status.Death | Status.Doom | Status.Sleep | Status.Stop,

            OtherImmunity = "Meteor Strike",
            MPKill = true,
            ImpCriticals = false
        },

        Rewards = new Rewards
        {
            Steal = new List<Item>
            {
                new Item("Potion", new Chance(7, 8)),
                new Item("Hi-Potion", new Chance(1, 8))
            },
            Drops = new List<Item>
            {
                new Item("Ether", new Chance(7, 8)),
                new Item("Hi-Ether", new Chance(1, 8))
            },
            Metamorphose = new Metamorphose("Antidote, Green Cherry, Eye Drops, Gold Needle", new Chance(255, 256))
        }
    };

    public static MonsterViewModel DesignMonster { get; } = new MonsterViewModel(Monster);
    public static StatsViewModel DesignStats { get; } = new StatsViewModel(Monster.Stats);
    public static DefensesViewModel DesignDefenses { get; } = new DefensesViewModel(Monster.Defenses);
    public static LocationsViewModel DesignLocations { get; } = new LocationsViewModel(Monster.Locations);
    public static RewardsViewModel DesignRewards { get; } = new RewardsViewModel(Monster.Rewards);
}
