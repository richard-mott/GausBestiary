using GausBestiary.Models.ChanceEvents;

namespace GausBestiary.Models.MonsterDetails;

/// <summary>
/// Stores any rewards obtained from the monster.
/// </summary>
public class Rewards
{
    public int Gil { get; set; }
    public int Experience { get; set; }

    /// <summary>
    /// List of Items that can be stolen from the monster. <see cref="Item"/>
    /// </summary>
    public List<Item> Steal { get; set; }

    /// <summary>
    /// List of Items that can be received as drops from the monster. <see cref="Item"/>
    /// </summary>
    public List<Item> Drops { get; set; }

    /// <summary>
    /// Metamorphose results and chance of success for the monster. <see cref="Metamorphose"/>
    /// </summary>
    public Metamorphose Metamorphose { get; set; }
}