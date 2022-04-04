using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GausBestiary.AvaloniaApp.Views.MonsterDetails;
public partial class SkillsView : UserControl
{
    public SkillsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
