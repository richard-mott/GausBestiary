using GausBestiary.Models.MonsterDetails;

namespace GausBestiary.AvaloniaApp.ViewModels.MonsterDetails;

public class DefensesViewModel : ViewModelBase
{
    private readonly Defenses defenses;

    public string ElementalWeakness => defenses.ElementalWeakness.ToString();
    public string ElementalImmunity => defenses.ElementalImmunity.ToString();
    public string ElementalAbsorb => defenses.ElementalAbsorb.ToString();
    public string StatusVulnerability => defenses.StatusVulnerability.ToString();
    public string StatusImmunity => defenses.StatusImmunity.ToString();
    public string InherentStatus => defenses.InherentStatus.ToString();
    public string OtherImmunity => defenses.OtherImmunity.ToString();
    public string MPKill => defenses.MPKill ? "Yes" : "No";
    public string ImpCriticals => defenses.ImpCriticals ? "Yes" : "No";
    
    public DefensesViewModel(Defenses defenses)
    {
        this.defenses = defenses;
    }
}
