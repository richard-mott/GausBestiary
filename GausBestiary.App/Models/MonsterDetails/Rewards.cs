using System.Collections.Generic;
using GausBestiary.App.Models.Calculations;

namespace GausBestiary.App.Models.MonsterDetails
{
    public class Rewards
    {
        public int Gil { get; set; }
        public int Experience { get; set; }

        public List<Item> Steal { get; set; }
        public List<Item> Drops { get; set; }
        public Metamorphose Metamorphose { get; set; }
    }
}
