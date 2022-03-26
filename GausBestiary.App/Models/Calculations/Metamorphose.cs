using System.Collections.Generic;
using System.Linq;

namespace GausBestiary.App.Models.Calculations
{
    public class Metamorphose
    {
        public List<string> Items { get; set; }
        public Formula Chance { get; set; }

        public Metamorphose(IEnumerable<string> items, int success, int maxChance)
        {
            Items = items.ToList();
            Chance = new Formula(success, maxChance);
        }
    }
}
