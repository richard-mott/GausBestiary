using GausBestiary.AvaloniaApp.ViewModels.MonsterDetails;
using GausBestiary.Models;
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
        }
    };

    public static MonsterViewModel DesignMonster { get; } = new MonsterViewModel(Monster);
    public static StatsViewModel DesignStats { get; } = new StatsViewModel(Monster.Stats);
    public static DefensesViewModel DesignDefenses { get; } = new DefensesViewModel(Monster.Defenses);
}
