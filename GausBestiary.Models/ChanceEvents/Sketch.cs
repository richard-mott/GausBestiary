namespace GausBestiary.Models.ChanceEvents;

/// <summary>
/// Stores an Ability and the chance of it being used when the monster is Sketched.
/// </summary>
public class Sketch
{
    /// <summary>
    /// The name of the ability.
    /// </summary>
    public string Ability { get; set; }

    /// <summary>
    /// The chance the ability will be used when the monster is Sketched.
    /// </summary>
    public Chance Chance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ability">The name of the ability.</param>
    /// <param name="success">The number of times out of <paramref name="maxChance"/> the <paramref name="ability"/> is used.</param>
    /// <param name="maxChance">The maximum possible number of outcomes.</param>
    public Sketch(string ability, int success, int maxChance)
    {
        Ability = ability;
        Chance = new Chance(success, maxChance);
    }
}