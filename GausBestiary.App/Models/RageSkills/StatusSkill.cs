namespace GausBestiary.App.Models.RageSkills
{
    public class StatusSkill : ISkill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Target { get; set; }
        public string HitRate { get; set; }
        public Status Status { get; set; }
        public bool IsUnblockable { get; set; }
    }
}
