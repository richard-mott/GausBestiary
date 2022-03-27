namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Stores a melee attack used by the Rage command.
/// </summary>
public class MeleeAttack : IRageSkill
{
    /// <summary>
    /// The name of the attack.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The level of the attack.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The attack power of the attack, used for damage calculations.
    /// </summary>
    public string Power { get; set; }
}