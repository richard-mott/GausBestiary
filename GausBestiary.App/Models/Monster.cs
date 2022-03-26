using System.Collections.Generic;
using GausBestiary.App.Models.MonsterDetails;

namespace GausBestiary.App.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SNESName { get; set; }

        public List<string> Locations { get; set; }
        public string Type { get; set; }
        public string Sprite { get; set; }

        public Stats Stats { get; set; }
        public Rewards Rewards { get; set; }
        public Defenses Defenses { get; set;  }
        public Skills Skills { get; set; }

        public string RunDifficulty { get; set; }
    }
}
