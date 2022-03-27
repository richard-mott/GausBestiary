namespace GausBestiary.Models.MonsterDetails;

/// <summary>
/// Stores the special defenses of a monster.
/// </summary>
public class Defenses
{
    /// <summary>
    /// Combined flag for elemental weaknesses, if any. <see cref="Element"/>
    /// </summary>
    public Element ElementalWeakness { get; set; }

    /// <summary>
    /// Combined flag for elemental immunities, if any. <see cref="Element"/>
    /// </summary>
    public Element ElementalImmunity { get; set; }

    /// <summary>
    /// Combined flag for elemental absorption, if any. <see cref="Element"/>
    /// </summary>
    public Element ElementalAbsorb { get; set; }

    /// <summary>
    /// Combined flag for status vulnerabilities, if any. <see cref="Status"/>
    /// </summary>
    public Status StatusVulnerability { get; set; }

    /// <summary>
    /// Combined flag for status immunities, if any. <see cref="Status"/>
    /// </summary>
    public Status StatusImmunity { get; set; }

    /// <summary>
    /// Combined flag for inherent status effects, if any. <see cref="Status"/>
    /// </summary>
    public Status StatusInherent { get; set; }

    /// <summary>
    /// Any other immunities the monster may possess.
    /// </summary>
    public string OtherImmunity { get; set; }

    /// <summary>
    /// Does the monster die upon reaching zero (0) MP?
    /// </summary>
    public bool MPKill { get; set; }

    /// <summary>
    /// Does the monster deal automatic critical hits when affected by Imp?
    /// </summary>
    public bool ImpCriticals { get; set; }
}