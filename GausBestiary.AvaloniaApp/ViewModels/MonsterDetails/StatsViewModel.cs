using GausBestiary.Models;
using GausBestiary.Models.MonsterDetails;

namespace GausBestiary.AvaloniaApp.ViewModels.MonsterDetails;

public class StatsViewModel : ViewModelBase
{
    private Stats stats;

    public string Level => stats.Level.ToString().PadLeft(3);
    public string HitPoints => stats.HitPoints.ToString().PadLeft(3);
    public string MagicPoints => stats.MagicPoints.ToString().PadLeft(3);

    public string Attack => stats.Attack.ToString().PadLeft(3);
    public string Defense => stats.Defense.ToString().PadLeft(3);
    public string Evasion => stats.Evasion.ToString().PadLeft(3);

    public string Magic => stats.Magic.ToString().PadLeft(3);
    public string MagicDefense => stats.MagicDefense.ToString().PadLeft(3);
    public string MagicEvasion => stats.MagicEvasion.ToString().PadLeft(3);

    public string Speed => stats.Speed.ToString().PadLeft(3);

    public StatsViewModel(Stats stats)
    {
        this.stats = stats;
    }

}
