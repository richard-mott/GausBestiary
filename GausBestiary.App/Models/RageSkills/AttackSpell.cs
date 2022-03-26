namespace GausBestiary.App.Models.RageSkills
{
    public class AttackSpell : ISkill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Power { get; set; }
        public string HitRate { get; set; }
        public Element Element { get; set; }
        public Status Status { get; set; }
        public bool IgnoresDefense { get; set; }
        public bool IsUnblockable { get; set; }
        public bool IsSplitDamage { get; set; }
    }
}
