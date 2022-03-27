using GausBestiary.Models.MonsterDetails;

namespace GausBestiary.Models;

/// <summary>
/// Stores a monster.
/// </summary>
public class Monster
{
    /// <summary>
    /// The Bestiary Id for the monster.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The default name of the monster.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The name of the monster in the SNES version of the game.
    /// </summary>
    public string SNESName { get; set; }

    /// <summary>
    /// A list of locations where the monster appears.
    /// </summary>
    public List<string> Locations { get; set; }

    /// <summary>
    /// The type of the monster.
    /// </summary>
    public string Type { get; set; }

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