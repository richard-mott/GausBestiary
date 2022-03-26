namespace GausBestiary.App.Models.MonsterDetails
{
    public class Defenses
    {
        public Element ElementalWeakness { get; set; }
        public Element ElementalImmunity { get; set; }
        public Element ElementalAbsorb { get; set; }

        public Status StatusVulnerability { get; set; }
        public Status StatusImmunity { get; set; }
        public Status StatusInherent { get; set; }

        public string OtherImmunity { get; set; }
        public bool MPKill { get; set; }
        public bool ImpCriticals { get; set; }
    }
}
