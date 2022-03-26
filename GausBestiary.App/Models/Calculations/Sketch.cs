namespace GausBestiary.App.Models.Calculations
{
    public class Sketch
    {
        public string Ability { get; set; }
        public Formula Chance { get; set; }

        public Sketch(string ability, int success, int maxChance)
        {
            Ability = ability;
            Chance = new Formula(success, maxChance);
        }
    }
}
