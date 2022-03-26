using System.Collections.Generic;
using GausBestiary.App.Models.Calculations;
using GausBestiary.App.Models.RageSkills;

namespace GausBestiary.App.Models.MonsterDetails
{
    public class Skills
    {
        public string SpecialAttack { get; set; }
        public ISkill Rage { get; set; }
        public List<Sketch> Sketch { get; set; }
        public List<string> Control { get; set; }
    }
}
