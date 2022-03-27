namespace GausBestiary.Models;

/// <summary>
/// Valid target types for an attack or spell.
/// </summary>
public enum Target
{
    Ally,
    Enemy
}

/// <summary>
/// Flags to track elements for weaknesses, immunities, and absorption.
/// </summary>
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

/// <summary>
/// Flags to track status effects for vulnerabilities, immunities, and inherent statuses.
/// </summary>
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