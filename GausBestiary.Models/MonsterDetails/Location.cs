namespace GausBestiary.Models.MonsterDetails;

public class Location
{
    public World World { get; set; }
    public string PrimaryLocation { get; set; }
    public List<string> SecondaryLocations { get; set; }

    public Location()
    {
        World = World.None;
        PrimaryLocation = string.Empty;
        SecondaryLocations = new List<string>();
    }
}
