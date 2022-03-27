namespace GausBestiary.Models.MonsterDetails;

/// <summary>
/// Stores the base statistics for a monster.
/// </summary>
public class Stats
{
    public int Level { get; set; } 
    public int HitPoints { get; set; } 
    public int MagicPoints { get; set; }

    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Evasion { get; set; }

    public int Magic { get; set; }
    public int MagicDefense { get; set; }
    public int MagicEvasion { get; set; }

    public int Speed { get; set; }
}