using System.Collections.ObjectModel;
using System.Linq;
using GausBestiary.Models.Providers;

namespace GausBestiary.AvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        private IDataProvider provider;
        private ObservableCollection<MonsterViewModel> monsters;
        public ObservableCollection<MonsterViewModel> Monsters => monsters;

        public MainWindowViewModel()
        {
            provider = new RegexDataProvider();
            monsters = new ObservableCollection<MonsterViewModel>(
                provider.GetMonsters()
                    .Select(monster => new MonsterViewModel(monster)));
        }
    }
}
