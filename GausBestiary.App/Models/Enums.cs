using System;

namespace GausBestiary.App.Models
{
    [Flags]
    public enum Element
    {
        None = 0,
        Earth = 1,
        Fire = 2,
        Holy = 4,
        Ice = 8,
        Lightning = 16,
        Poison = 32,
        Water = 64,
        Wind = 128
    }

    [Flags]
    public enum Status
    {
        None,
        Berserk,
        Confusion,
        Critical,
        Darkness,
        Death,
        Doom,
        Image,
        Imp,
        Invisible,
        MagiTek,
        Petrify,
        Poison,
        Sap,
        Silence,
        Sleep,
        Slow,
        Stop,
        Zombie
    }
}
