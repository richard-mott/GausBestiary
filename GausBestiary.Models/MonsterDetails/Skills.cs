using GausBestiary.Models.ChanceEvents;
using GausBestiary.Models.RageSkills;

namespace GausBestiary.Models.MonsterDetails;

/// <summary>
/// Stores the monster's skills, including the skills used by Rage, Sketch, and Control.
/// </summary>
public class Skills
{
    /// <summary>
    /// The special attack, if any, that the monster uses in combat.
    /// </summary>
    public string SpecialAttack { get; set; }

    /// <summary>
    /// The skill that is used by the Rage command.
    /// </summary>
    public IRageSkill Rage { get; set; }

    /// <summary>
    /// The skills used by Sketch.
    /// </summary>
    public List<Sketch> Sketch { get; set; }

    /// <summary>
    /// The skills available when the monster is Controlled.
    /// </summary>
    public List<string> Control { get; set; }
}