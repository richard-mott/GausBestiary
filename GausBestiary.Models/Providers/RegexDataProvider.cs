using System.Text.RegularExpressions;
using GausBestiary.Models.MonsterDetails;
using GausBestiary.Models.ProviderSettings;
using GausBestiary.Models.RageSkills;
using Microsoft.VisualBasic;

namespace GausBestiary.Models.Providers;

public class RegexDataProvider : IDataProvider
{
    
    private const string AttackSpellPattern =
        @"RageId: (?<RageId>\d{1,3})" + ControlChars.NewLine +
        @"GBA Name: (?<GBAName>.*?)" + ControlChars.NewLine +
        @"SNES Name: (?<SNESName>.*?)" + ControlChars.NewLine +
        @"Power: (?<Power>.*?)" + ControlChars.NewLine +
        @"Hit Rate: (?<HitRate>.*?)" + ControlChars.NewLine +
        @"Element: (?<Element>.*?)" + ControlChars.NewLine +
        @"Status: (?<Status>.*?)" + ControlChars.NewLine +
        @"Ignores Defense: (?<IgnoresDefense>Yes|No)" + ControlChars.NewLine +
        @"Unblockable: (?<Unblockable>Yes|No)" + ControlChars.NewLine +
        @"Splits Damage: (?<SplitsDamage>Yes|No)" + ControlChars.NewLine +
        @"(?:Description: (?<Description>.*?)\n)?";

    public IEnumerable<Monster> GetMonsters()
    {
        var bestiaryText = File.ReadAllText(BestiarySettings.FileName);
        var regex = new Regex(BestiarySettings.BestiaryRegexPattern);
        var matches = regex.Matches(bestiaryText);

        var monsters = new List<Monster>();
        foreach (Match match in matches)
        {
            var monster = GetBaseMonster(match);

            monster.Stats = GetMonsterStats(match);
            monster.Rewards = GetMonsterRewards(match);
            monster.Defenses = GetMonsterDefenses(match);
            monster.Skills = GetMonsterSkills(match);
            
            monsters.Add(monster);
        }

        return monsters;
    }

    public IEnumerable<RageSkill> GetRages()
    {
        var ragesText = File.ReadAllText(RageSettings.FileName);
        var rages = new List<RageSkill>
        {
            new RageSkill
            {
                RageId = 0,
                SnesName = "None",
                PlayStationName = "None",
                GbaName = "None",
                MobileName = "None",
                PixelRemasterName = "None"
            }
        };

        rages.AddRange(GetAttackSpells(ragesText));
        rages.AddRange(GetHealingSpells(ragesText));
        rages.AddRange(GetMeleeAttacks(ragesText));
        rages.AddRange(GetStatusAttacks(ragesText));
        rages.AddRange(GetStatusSpells(ragesText));

        return rages;
    }

    private Monster GetBaseMonster(Match match)
    {
        return new Monster
        {
            Id = GetNumber(match, BestiarySettings.MonsterId),
            SnesId = GetNumber(match, BestiarySettings.SnesId),
            PlayStationId = GetNumber(match, BestiarySettings.SnesId),
            GbaId = GetNumber(match, BestiarySettings.GbaId),
            MobileId = GetNumber(match, BestiarySettings.GbaId),
            PixelRemasterId = GetNumber(match, BestiarySettings.SnesId),
            SnesName = GetString(match, BestiarySettings.SnesName),
            PlayStationName = GetString(match, BestiarySettings.SnesName),
            GbaName = GetString(match, BestiarySettings.GbaName),
            MobileName = GetString(match, BestiarySettings.GbaName),
            PixelRemasterName = GetString(match, BestiarySettings.PixelRemasterName),
            Locations = GetMonsterLocations(GetString(match, BestiarySettings.Location)).ToList(),
            Type = GetMonsterType(GetString(match, BestiarySettings.Type)),
            RunDifficulty = GetString(match, BestiarySettings.RunDifficulty)
        };
    }

    private IEnumerable<Location> GetMonsterLocations(string locationText)
    {
        var splitLocations = locationText.Split(",");
        var regex = new Regex(BestiarySettings.LocationRegexPattern);

        var locations = new List<Location>();
        foreach (var location in splitLocations)
        {
            var match = regex.Match(location);
            var newLocation = new Location
            {
                World = (World)Enum.Parse(typeof(World), GetString(match, BestiarySettings.World)),
                PrimaryLocation = GetString(match, BestiarySettings.PrimaryLocation),
                SecondaryLocations = new List<string>(GetString(match, BestiarySettings.SecondaryLocation).Split("|"))
            };

            locations.Add(newLocation);
        }

        return locations;
    }

    private MonsterType GetMonsterType(string monsterType)
    {
        if (monsterType == "N/A")
        {
            return MonsterType.None;
        }

        return monsterType
            .Split(",")
            .Aggregate(MonsterType.None,
                (current, type) => 
                    current | (MonsterType)Enum.Parse(typeof(MonsterType), type));
    }

    private Stats GetMonsterStats(Match match)
    {
        return new Stats
        {
            Level = GetNumber(match, BestiarySettings.Level),
            HitPoints = GetNumber(match, BestiarySettings.HitPoints),
            MagicPoints = GetNumber(match, BestiarySettings.MagicPoints),
            Attack = GetNumber(match, BestiarySettings.Attack),
            Defense = GetNumber(match, BestiarySettings.Defense),
            Evasion = GetNumber(match, BestiarySettings.Evasion),
            Magic = GetNumber(match, BestiarySettings.Magic),
            MagicDefense = GetNumber(match, BestiarySettings.MagicDefense),
            MagicEvasion = GetNumber(match, BestiarySettings.MagicEvasion),
            Speed = GetNumber(match, BestiarySettings.Speed)
        };
    }

    private Rewards GetMonsterRewards(Match match)
    {
        return new Rewards
        {
            Gil = GetNumber(match, BestiarySettings.Gil),
            Experience = GetNumber(match, BestiarySettings.Experience)
            // Steal
            // Drops
            // Metamorphose
        };
    }

    private Defenses GetMonsterDefenses(Match match)
    {
        return new Defenses
        {
            ElementalWeakness = GetElement(match, BestiarySettings.ElementalWeakness),
            ElementalImmunity = GetElement(match, BestiarySettings.ElementalImmunity),
            ElementalAbsorb = GetElement(match, BestiarySettings.ElementalAbsorb),
            StatusVulnerability = GetStatus(match, BestiarySettings.StatusVulnerability),
            StatusImmunity = GetStatus(match, BestiarySettings.StatusImmunity),
            InherentStatus = GetStatus(match, BestiarySettings.InherentStatus),
            OtherImmunity = GetString(match, BestiarySettings.OtherImmunity),
            MPKill = GetBool(match, BestiarySettings.MPKill),
            ImpCriticals = GetBool(match, BestiarySettings.ImpCriticals)
        };
    }

    private Skills GetMonsterSkills(Match match)
    {
        var rages = GetRages();

        return new Skills
        {
            SpecialAttack = GetString(match, BestiarySettings.SpecialAttack),
            Rage = rages.First(rage => rage.GbaName == GetString(match, BestiarySettings.Rage) && rage.RageId == GetNumber(match, BestiarySettings.RageId)),
            // Sketch
            Control = GetString(match, BestiarySettings.Control)
                .Split(",")
                .Select(ability => ability.Trim())
                .ToList()
        };
    }

    private IEnumerable<RageSkill> GetAttackSpells(string ragesText)
    {
        var regex = new Regex(RageSettings.AttackSpellRegexPattern);
        var matches = regex.Matches(ragesText);

        var attackSpells = new List<AttackSpell>();
        foreach (Match match in matches)
        {
            var rage = GetBaseRageSkill(match);
            var attackSpell = new AttackSpell(GetBaseRageSkill(match))
            {
                Description = GetString(match, RageSettings.Description),
                Power = GetString(match, RageSettings.Power),
                HitRate = GetString(match, RageSettings.HitRate),
                Element = GetElement(match, RageSettings.Element),
                Status = GetStatus(match, RageSettings.Status),
                IgnoresDefense = GetBool(match, RageSettings.IgnoresDefense),
                IsUnblockable = GetBool(match, RageSettings.Unblockable),
                IsSplitDamage = GetBool(match, RageSettings.SplitsDamage)
            };

            attackSpells.Add(attackSpell);
        }

        return attackSpells;
    }

    private IEnumerable<RageSkill> GetHealingSpells(string ragesText)
    {
        var regex = new Regex(RageSettings.HealingSpellRegexPattern);
        var matches = regex.Matches(ragesText);

        var healingSpells = new List<HealingSpell>();
        foreach (Match match in matches)
        {
            var healingSpell = new HealingSpell(GetBaseRageSkill(match))
            {
                Description = GetString(match, RageSettings.Description),
                Power = GetString(match, RageSettings.Power)
            };

            healingSpells.Add(healingSpell);
        }

        return healingSpells;
    }

    private IEnumerable<RageSkill> GetMeleeAttacks(string ragesText)
    {
        var regex = new Regex(RageSettings.MeleeAttackRegexPattern);
        var matches = regex.Matches(ragesText);

        var meleeAttacks = new List<MeleeAttack>();
        foreach (Match match in matches)
        {
            var meleeAttack = new MeleeAttack(GetBaseRageSkill(match))
            {
                Level = GetNumber(match, RageSettings.Level),
                Power = GetString(match, RageSettings.Power)
            };

            meleeAttacks.Add(meleeAttack);
        }

        return meleeAttacks;
    }

    private IEnumerable<RageSkill> GetStatusAttacks(string ragesText)
    {
        var regex = new Regex(RageSettings.StatusAttackRegexPattern);
        var matches = regex.Matches(ragesText);

        var statusAttacks = new List<StatusAttack>();
        foreach (Match match in matches)
        {
            var statusAttack = new StatusAttack(GetBaseRageSkill(match))
            {
                Status = GetStatus(match, RageSettings.Status)
            };

            statusAttacks.Add(statusAttack);
        }

        return statusAttacks;
    }

    private IEnumerable<RageSkill> GetStatusSpells(string ragesText)
    {
        var regex = new Regex(RageSettings.StatusSpellRegexPattern);
        var matches = regex.Matches(ragesText);

        var statusSpells = new List<StatusSpell>();
        foreach (Match match in matches)
        {
            var statusSpell = new StatusSpell(GetBaseRageSkill(match))
            {
                Description = GetString(match, RageSettings.Description),
                Target = GetTarget(match, RageSettings.Target),
                HitRate = GetString(match, RageSettings.HitRate),
                Status = GetStatus(match, RageSettings.Status),
                IsUnblockable = GetBool(match, RageSettings.Unblockable)
            };

            statusSpells.Add(statusSpell);
        }

        return statusSpells;
    }

    private RageSkill GetBaseRageSkill(Match match)
    {
        return new RageSkill
        {
            RageId = GetNumber(match, RageSettings.RageId),
            SnesName = GetString(match, RageSettings.SnesName),
            PlayStationName = GetString(match, RageSettings.SnesName),
            GbaName = GetString(match, RageSettings.GbaName),
            MobileName = GetString(match, RageSettings.GbaName),
            PixelRemasterName = GetString(match, RageSettings.GbaName)
        };
    }

    private Element GetElement(Match match, string identifier)
    {
        return GetString(match, identifier)
            .Split(",")
            .Aggregate(Element.None,
                (current, element) =>
                    current | (Element)Enum.Parse(typeof(Element), element));
    }

    private Status GetStatus(Match match, string identifier)
    {
        return GetString(match, identifier)
            .Split(",")
            .Aggregate(Status.None,
                (current, status) =>
                    current | (Status)Enum.Parse(typeof(Status), status));
    }

    private Target GetTarget(Match match, string identifier)
    {
        return (Target)Enum.Parse(typeof(Target), GetString(match, identifier));
    }

    private string GetString(Match match, string identifier)
    {
        return match.Groups[identifier].Value.Trim();
    }

    private int GetNumber(Match match, string identifier)
    {
        return int.Parse(GetString(match, identifier));
    }

    private bool GetBool(Match match, string identifier)
    {
        var value = GetString(match, identifier).ToLower();

        return value is "true" or "yes";
    }
}
