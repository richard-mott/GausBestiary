using System.Collections.Generic;
using System.Linq;
using GausBestiary.Models.ChanceEvents;
using GausBestiary.Models.MonsterDetails;

namespace GausBestiary.AvaloniaApp.ViewModels.MonsterDetails;

public class RewardsViewModel : ViewModelBase
{
    private readonly Rewards Rewards;

    public string Gil => Rewards.Gil.ToString();
    public string Experience => Rewards.Experience.ToString();
    public string Steal { get; private set; }
    public string Drops { get; private set; }
    public string MetamorphoseTitle { get; private set; }
    public string MetamorphoseItems { get; private set; }

    public RewardsViewModel(Rewards rewards)
    {
        Rewards = rewards;
        Steal = GetItemList(Rewards.Steal);
        Drops = GetItemList(Rewards.Drops);
        MetamorphoseTitle = GetMetamorphoseTitle();
        MetamorphoseItems = GetMetamorphoseItems();
    }

    private string GetItemList(List<Item> items)
    {
        if (items.Count == 0)
        {
            return "Nothing";
        }

        return items
            .OrderByDescending(item => item.Chance.Success)
            .ThenBy(item => item.Name)
            .Select(item => $"{item.Name} ({item.Chance.Text})")
            .Aggregate((current, next) => $"{current}\n{next}")
            .Trim();
    }

    private string GetMetamorphoseTitle()
    {
        return $"Metamorphose ({Rewards.Metamorphose.Chance.Percentage})";
    }

    private string GetMetamorphoseItems()
    {
        return Rewards.Metamorphose.Items
            .OrderByDescending(item => item.Chance.Success)
            .ThenBy(item => item.Name)
            .Select(item => $"{item.Name} ({item.Chance.Text})")
            .Aggregate((current, next) => $"{current}\n{next}")
            .Trim();
    }
}
