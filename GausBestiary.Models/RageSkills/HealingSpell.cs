namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Stores a healing spell used by the Rage command.
/// </summary>
public class HealingSpell : IRageSkill
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
    /// The magic power of the spell, used for healing calculations.
    /// </summary>
    public string Power { get; set; }
}