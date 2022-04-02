using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GausBestiary.AvaloniaApp.Views;
public partial class MonsterView : UserControl
{
    public MonsterView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
