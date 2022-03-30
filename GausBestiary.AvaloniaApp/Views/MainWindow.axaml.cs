using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Avalonia;
using Avalonia.Controls;
using GausBestiary.Models;
using GausBestiary.Models.Providers;
using GausBestiary.Models.ProviderSettings;
using Microsoft.VisualBasic;

namespace GausBestiary.AvaloniaApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var provider = new RegexDataProvider();
            var monsters = provider.GetMonsters().ToList();

            var distinctWorlds = monsters
                .SelectMany(monster => monster.Locations
                    .Select(location => location.World))
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            
            var distinctPrimary = monsters
                .SelectMany(monster => monster.Locations
                    .Select(location => location.PrimaryLocation))
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            
            var distinctSecondary = monsters
                .SelectMany(monster => monster.Locations
                    .SelectMany(location => location.SecondaryLocations))
                .Distinct()
                .OrderBy(x => x)
                .ToList();
        }
    }
}
