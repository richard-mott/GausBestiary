using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GausBestiary.AvaloniaApp.Views.MonsterDetails;
public partial class StatsView : UserControl
{
    public StatsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
