namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Base class to allow different types of Rage skills to be assigned to a monster.
/// </summary>
public class RageSkill
{
    /// <summary>
    /// Internal id for the skill
    /// </summary>
    public int RageId { get; set; }

    /// <summary>
    /// The name of the monster in the SNES version of the game.
    /// </summary>
    public string SnesName { get; set; }

    /// <summary>
    /// The name of the monster in the PlayStation version of the game.
    /// </summary>
    public string PlayStationName { get; set; }

    /// <summary>
    /// The name of the monster in the GBA version of the game.
    /// </summary>
    public string GbaName { get; set; }

    /// <summary>
    /// The name of the monster in the iOS/Android/PC version of the game.
    /// </summary>
    public string MobileName { get; set; }

    /// <summary>
    /// The name of the monster in the Pixel Remaster version of the game.
    /// </summary>
    public string PixelRemasterName { get; set; }
}