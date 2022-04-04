using System.Collections.Generic;
using System.Linq;
using System.Text;
using GausBestiary.Models;
using GausBestiary.Models.MonsterDetails;

namespace GausBestiary.AvaloniaApp.ViewModels.MonsterDetails;

public class LocationsViewModel : ViewModelBase
{
    private readonly IEnumerable<Location> Locations;
    
    public string AllLocations { get; private set; }

    public LocationsViewModel(IEnumerable<Location> locations)
    {
        Locations = locations;
        AllLocations = GetAllLocations();
    }

    private string GetAllLocations()
    {
        var groupedLocations = Locations.ToList()
            .OrderBy(location => location.World)
            .ThenBy(location => location.PrimaryLocation)
            .GroupBy(location => location.World);

        var builder = new StringBuilder();

        foreach (var group in groupedLocations)
        {
            builder.AppendLine(GetWorld(group.Key));
            foreach (var location in group)
            {
                builder.AppendLine($"  {location.PrimaryLocation}");

                foreach (var secondary in location.SecondaryLocations)
                {
                    builder.AppendLine($"    {secondary}");
                }
            }
        }

        return builder.ToString().Trim();
    }

    private string GetWorld(World world)
    {
        switch (world)
        {
            case World.WoB:
                return "World of Balance";
            case World.WoR:
                return "World of Ruin";
            case World.Bonus:
                return "Bonus Content";
            default:
                return "None";
        }
    }
}
