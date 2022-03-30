namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Stores a healing spell used by the Rage command.
/// </summary>
public class HealingSpell : RageSkill
{
    /// <summary>
    /// The description of the spell.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The magic power of the spell, used for healing calculations.
    /// </summary>
    public string Power { get; set; }

    public HealingSpell(RageSkill baseRage)
    {
        this.RageId = baseRage.RageId;
        this.SnesName = baseRage.SnesName;
        this.PlayStationName = baseRage.PlayStationName;
        this.GbaName = baseRage.GbaName;
        this.MobileName = baseRage.MobileName;
        this.PixelRemasterName = baseRage.PixelRemasterName;
    }
}