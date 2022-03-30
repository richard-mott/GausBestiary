namespace GausBestiary.Models;

/// <summary>
/// World types
/// </summary>
public enum World
{
    None  = 0,  // None: No world set
    WoB   = 1,  // World of Balance: Before the end of the Floating Continent
    WoR   = 2,  // World of Ruin: After the end of the Floating Continent
    Bonus = 3   // Bonus Content: Extra content included in the GBA version of the game
}

/// <summary>
/// Valid target types for an attack or spell.
/// </summary>
public enum Target
{
    Ally,
    Enemy
}

/// <summary>
/// Flags to track monster type.
/// </summary>
[Flags]
public enum MonsterType
{
    None     = 0,
    Normal   = 0b1,
    Boss     = 0b10,
    Humanoid = 0b100,
    Undead   = 0b1000
}

/// <summary>
/// Flags to track elements for weaknesses, immunities, and absorption.
/// </summary>
[Flags]
public enum Element
{
    None      = 0,
    Earth     = 0b1,
    Fire      = 0b10,
    Holy      = 0b100,
    Ice       = 0b1000,
    Lightning = 0b10000,
    Poison    = 0b100000,
    Water     = 0b1000000,
    Wind      = 0b10000000
}

/// <summary>
/// Flags to track status effects for vulnerabilities, immunities, and inherent statuses.
/// </summary>
[Flags]
public enum Status
{
    None      = 0,
    Berserk   = 0b1,
    Confusion = 0b10,
    Critical  = 0b100,
    Darkness  = 0b1000,
    Death     = 0b10000,
    Doom      = 0b100000,
    Float     = 0b1000000,
    Frozen    = 0b10000000,
    Haste     = 0b100000000,
    Image     = 0b1000000000,
    Imp       = 0b10000000000,
    Invisible = 0b100000000000,
    MagiTek   = 0b1000000000000,
    Petrify   = 0b10000000000000,
    Poison    = 0b100000000000000,
    Protect   = 0b1000000000000000,
    Reflect   = 0b10000000000000000,
    Regen     = 0b100000000000000000,
    Safe      = 0b1000000000000000000,
    Sap       = 0b10000000000000000000,
    Scan      = 0b100000000000000000000,
    Shell     = 0b1000000000000000000000,
    Silence   = 0b10000000000000000000000,
    Sleep     = 0b100000000000000000000000,
    Slow      = 0b1000000000000000000000000,
    Stop      = 0b10000000000000000000000000,
    Zombie    = 0b100000000000000000000000000
}