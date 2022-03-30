using GausBestiary.Models.RageSkills;

namespace GausBestiary.Models.Providers;

public interface IDataProvider
{
    IEnumerable<Monster> GetMonsters();
    IEnumerable<RageSkill> GetRages();
}
