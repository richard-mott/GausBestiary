using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GausBestiary.AvaloniaApp.Views.MonsterDetails;
public partial class RewardsView : UserControl
{
    public RewardsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
