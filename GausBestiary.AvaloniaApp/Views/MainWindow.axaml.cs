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

            var sketches = monsters
                .SelectMany(monster => monster.Skills.Sketch
                    .Select(sketch => $"{sketch.Ability} {sketch.Chance.Text}"))
                .Distinct()
                .OrderBy(sketch => sketch)
                .ToList();
        }
    }
}
