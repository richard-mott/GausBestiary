using System.Collections.Generic;
using Avalonia.Controls;
using GausBestiary.App.Models;
using GausBestiary.App.Models.Calculations;
using GausBestiary.App.Models.MonsterDetails;

namespace GausBestiary.App.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var monsterList = new List<Monster>
            {
                new Monster
                {
                    Id = 1,
                    Name = "Guard",
                    SNESName = "Guard",
                    Locations = new List<string>
                    {
                        "Narshe (Biggs, Wedge, Terra raid)",
                        "Vector (Skinny house left of inn)"
                    },
                    Stats = new Stats
                    {
                        Level = 5,
                        HitPoints = 40,
                        MagicPoints = 15,
                        Attack = 16,
                        Defense = 100,
                        Evasion = 0,
                        Magic = 6,
                        MagicDefense = 140,
                        MagicEvasion = 0,
                        Speed = 30
                    },
                    Rewards = new Rewards
                    {
                        Gil = 48,
                        Experience = 48,
                        Steal = new List<Item>
                        {
                            new Item("Potion", 7, 8),
                            new Item("Hi-Potion", 1, 8)
                        },
                        Drops = new List<Item>
                        {
                            new Item("Potion", 1, 8)
                        },
                        Metamorphose = new Metamorphose(
                            new[] { "Antidote", "Green Cherry", "Eye Drops", "Gold Needle" },
                            255, 256)
                    },
                    Defenses = new Defenses
                    {
                        ElementalImmunity = Element.None,
                        ElementalWeakness = Element.Poison,
                        ElementalAbsorb = Element.None,
                        StatusImmunity = Status.None,
                        StatusVulnerability = Status.Darkness 
                                              | Status.Zombie
                                              | Status.Poison
                                              | Status.MagiTek
                                              | Status.Invisible
                                              | Status.Imp
                                              | Status.Petrify
                                              | Status.Death
                                              | Status.Doom
                                              | Status.Critical
                                              | Status.Image
                                              | Status.Silence
                                              | Status.Berserk
                                              | Status.Confusion
                                              | Status.Sap
                                              | Status.Sleep
                                              | Status.Slow
                                              | Status.Stop,
                        StatusInherent = Status.None,
                        OtherImmunity = string.Empty,
                        MPKill = false,
                        ImpCriticals = false
                    },
                    Skills = new Skills
                    {
                        SpecialAttack = "Critical (150% damage)",
                        Rage = null,
                        Sketch = new List<Sketch>
                        {
                            new Sketch("Attack", 1, 1)
                        },
                        Control = new List<string> { "Attack" }
                    },
                    RunDifficulty = "Easy"
                }
            };
        }
    }
}
