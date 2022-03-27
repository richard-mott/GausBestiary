namespace GausBestiary.Models.RageSkills;

/// <summary>
/// Interface to allow different types of Rage skills to be assigned to a monster.
/// </summary>
public interface IRageSkill
{
    string Name { get; set; }
}