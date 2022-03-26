namespace GausBestiary.App.Models.Calculations
{
    public class Item
    {
        public string Name { get; set; }
        public Formula Chance { get; set; }

        public Item(string name, int success, int maxChance)
        {
            Name = name;
            Chance = new Formula(success, maxChance);
        }
    }
}
