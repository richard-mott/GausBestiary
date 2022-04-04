using System.Linq;
using GausBestiary.Models.MonsterDetails;

namespace GausBestiary.AvaloniaApp.ViewModels.MonsterDetails;

public class SkillsViewModel : ViewModelBase
{
    private readonly Skills Skills;

    public string SpecialAttack => Skills.SpecialAttack;
    public string Rage => Skills.Rage.PixelRemasterName;
    public string Sketch { get; private set; }
    
    public SkillsViewModel(Skills skills)
    {
        Skills = skills;
        BuildSketchText();
    }

    private void BuildSketchText()
    {
        Sketch = Skills.Sketch
            .OrderByDescending(sketch => sketch.Chance.Success)
            .ThenBy(sketch => sketch.Ability)
            .Select(sketch => $"{sketch.Ability} ({sketch.Chance.Text})")
            .Aggregate((current, next) => $"{current}\n{next}")
            .Trim();
    }
}
