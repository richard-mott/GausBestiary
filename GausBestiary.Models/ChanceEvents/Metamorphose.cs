namespace GausBestiary.Models.ChanceEvents;

/// <summary>
/// Stores a list of item rewards from using Metamorphose along with the chance it succeeds.
/// </summary>
public class Metamorphose
{
    /// <summary>
    /// The list of possible item rewards. All items have the same chance of being the reward.
    /// </summary>
    public List<string> Items { get; set; }

    /// <summary>
    /// The chance that Metamorphose succeeds.
    /// </summary>
    public Chance Chance { get; set; }

    /// <summary>
    /// Creates a Metamorphose result.
    /// </summary>
    /// <param name="items">The list of possible item rewards.</param>
    /// <param name="success">The number of times out of <paramref name="maxChance"/> that Metamorphose is successful.</param>
    /// <param name="maxChance">The maximum possible number of outcomes.</param>
    public Metamorphose(IEnumerable<string> items, int success, int maxChance)
    {
        Items = items.ToList();
        Chance = new Chance(success, maxChance);
    }
}