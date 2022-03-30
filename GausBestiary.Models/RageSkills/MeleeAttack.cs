namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Stores a melee attack used by the Rage command.
/// </summary>
public class MeleeAttack : RageSkill
{
    /// <summary>
    /// The level of the attack.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The attack power of the attack, used for damage calculations.
    /// </summary>
    public string Power { get; set; }

    public MeleeAttack(RageSkill baseRage)
    {
        this.RageId = baseRage.RageId;
        this.SnesName = baseRage.SnesName;
        this.PlayStationName = baseRage.PlayStationName;
        this.GbaName = baseRage.GbaName;
        this.MobileName = baseRage.MobileName;
        this.PixelRemasterName = baseRage.PixelRemasterName;
    }
}