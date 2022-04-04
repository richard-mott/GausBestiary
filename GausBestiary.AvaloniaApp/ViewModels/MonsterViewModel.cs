using GausBestiary.AvaloniaApp.ViewModels.MonsterDetails;
using GausBestiary.Models;

namespace GausBestiary.AvaloniaApp.ViewModels;

public class MonsterViewModel : ViewModelBase
{
    private readonly Monster monster;

    public string Name
    {
        get => monster.GbaName;
        set => monster.GbaName = value;
    }

    public StatsViewModel Stats { get; }
    public DefensesViewModel Defenses { get; }
    public LocationsViewModel Locations { get; }
    public RewardsViewModel Rewards { get; }
    public SkillsViewModel Skills { get; }

    public MonsterViewModel(Monster monster)
    {
        this.monster = monster;
        Stats = new StatsViewModel(monster.Stats);
        Defenses = new DefensesViewModel(monster.Defenses);
        Locations = new LocationsViewModel(monster.Locations);
        Rewards = new RewardsViewModel(monster.Rewards);
        Skills = new SkillsViewModel(monster.Skills);
    }
}
