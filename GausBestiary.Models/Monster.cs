using GausBestiary.Models.MonsterDetails;

namespace GausBestiary.Models;

/// <summary>
/// Stores a monster.
/// </summary>
public class Monster
{
    /// <summary>
    /// The internal Id for the monster.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The Bestiary Id for the SNES version of the monster.
    /// </summary>
    public int SnesId { get; set; }

    /// <summary>
    /// The Bestiary Id for the PlayStation version of the monster.
    /// </summary>
    public int PlayStationId { get; set; }

    /// <summary>
    /// The Bestiary Id for the GBA version of the monster.
    /// </summary>
    public int GbaId { get; set; }

    /// <summary>
    /// The Bestiary Id for the iOS/Android/PC version of the monster.
    /// </summary>
    public int MobileId { get; set; }

    /// <summary>
    /// The Bestiary Id for the Pixel Remaster version of the monster.
    /// </summary>
    public int PixelRemasterId { get; set; }

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

    /// <summary>
    /// A list of locations where the monster appears.
    /// </summary>
    public List<Location> Locations { get; set; }

    /// <summary>
    /// The type of the monster.
    /// </summary>
    public MonsterType Type { get; set; }

    /// <summary>
    /// The file name for the monster's sprite.
    /// </summary>
    public string Sprite { get; set; }

    /// <summary>
    /// Base statistics for the monster.
    /// </summary>
    public Stats Stats { get; set; }

    /// <summary>
    /// Rewards obtained from the monster.
    /// </summary>
    public Rewards Rewards { get; set; }

    /// <summary>
    /// Special defenses of the monster.
    /// </summary>
    public Defenses Defenses { get; set;  }

    /// <summary>
    /// Skills used by the monster, or by using Rage, Sketch, or Control.
    /// </summary>
    public Skills Skills { get; set; }

    /// <summary>
    /// Difficulty of escaping from the monster.
    /// </summary>
    public string RunDifficulty { get; set; }
}