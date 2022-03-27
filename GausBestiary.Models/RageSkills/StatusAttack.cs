namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Stores a status-inflicting attack used by the Rage command.
/// </summary>
public class StatusAttack : IRageSkill
{
    /// <summary>
    /// The name of the attack.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The status inflicted by the attack.
    /// </summary>
    public Status Status { get; set; }
}