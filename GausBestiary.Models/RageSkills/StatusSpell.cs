namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Stores a status-inflicting spell used by the Rage command.
/// </summary>
public class StatusSpell : RageSkill
{
    /// <summary>
    /// The description of the spell.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The target type of the spell. <see cref="Target"/>
    /// </summary>
    public Target Target { get; set; }

    /// <summary>
    /// The chance the spell affects the target.
    /// </summary>
    public string HitRate { get; set; }

    /// <summary>
    /// The status inflicted by the spell.
    /// </summary>
    public Status Status { get; set; }

    /// <summary>
    /// Is the spell unblockable?
    /// </summary>
    public bool IsUnblockable { get; set; }

    public StatusSpell(RageSkill baseRage)
    {
        this.RageId = baseRage.RageId;
        this.SnesName = baseRage.SnesName;
        this.PlayStationName = baseRage.PlayStationName;
        this.GbaName = baseRage.GbaName;
        this.MobileName = baseRage.MobileName;
        this.PixelRemasterName = baseRage.PixelRemasterName;
    }
}