﻿namespace GausBestiary.Models.ChanceEvents;

/// <summary>
/// Stores an Item and the chance of receiving it. Used for Steal and Drops.
/// </summary>
public class Item
{
    /// <summary>
    /// The name of the item.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The chance of receiving the item.
    /// </summary>
    public Chance Chance { get; set; }

    /// <summary>
    /// Creates an Item.
    /// </summary>
    /// <param name="name">The name of the item.</param>
    /// <param name="success">The number of times out of <paramref name="maxChance"/> the item is received.</param>
    /// <param name="maxChance">The maximum possible number of outcomes.</param>
    public Item(string name, int success, int maxChance)
    {
        Name = name;
        Chance = new Chance(success, maxChance);
    }
}