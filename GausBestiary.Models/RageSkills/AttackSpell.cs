namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Stores an attack spell used by the Rage command.
/// </summary>
public class AttackSpell : IRageSkill
{
    /// <summary>
    /// The name of the spell.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The description of the spell.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The magic power of the spell, used for damage calculations.
    /// </summary>
    public string Power { get; set; }

    /// <summary>
    /// The chance the spell hits an enemy.
    /// </summary>
    public string HitRate { get; set; }

    /// <summary>
    /// The element, if any, of the spell.
    /// </summary>
    public Element Element { get; set; }

    /// <summary>
    /// The status effect, if any, set by the spell.
    /// </summary>
    public Status Status { get; set; }

    /// <summary>
    /// Does the spell ignore the monster's Magic Defense?
    /// </summary>
    public bool IgnoresDefense { get; set; }

    /// <summary>
    /// Is the spell unblockable?
    /// </summary>
    public bool IsUnblockable { get; set; }

    /// <summary>
    /// Is damage split between all targets of the spell?
    /// </summary>
    public bool IsSplitDamage { get; set; }
}