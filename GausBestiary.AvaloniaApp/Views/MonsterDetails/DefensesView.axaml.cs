using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GausBestiary.AvaloniaApp.Views.MonsterDetails;
public partial class DefensesView : UserControl
{
    public DefensesView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
