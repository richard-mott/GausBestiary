namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Stores a status-inflicting attack used by the Rage command.
/// </summary>
public class StatusAttack : RageSkill
{
    /// <summary>
    /// The status inflicted by the attack.
    /// </summary>
    public Status Status { get; set; }

    public StatusAttack(RageSkill baseRage)
    {
        this.RageId = baseRage.RageId;
        this.SnesName = baseRage.SnesName;
        this.PlayStationName = baseRage.PlayStationName;
        this.GbaName = baseRage.GbaName;
        this.MobileName = baseRage.MobileName;
        this.PixelRemasterName = baseRage.PixelRemasterName;
    }
}