using Microsoft.VisualBasic;

namespace GausBestiary.Models.ProviderSettings;

internal static class BestiarySettings
{
    internal static string FileName => @"bestiary_regex.txt";

    internal static string BestiaryRegexPattern =>
        @"MonsterId: (?<MonsterId>\d{1,3})" + ControlChars.NewLine +
        @"SNES Id: (?<SnesId>\d{1,3})" + ControlChars.NewLine +
        @"GBA Id: (?<GbaId>\d{1,3})" + ControlChars.NewLine +
        @"SNES Name: (?<SnesName>.*?)" + ControlChars.NewLine +
        @"GBA Name: (?<GbaName>.*?)" + ControlChars.NewLine +
        @"PixelRemaster Name: (?<PixelRemasterName>.*?)" + ControlChars.NewLine +
        @"Location:(?<Location>.*?)" + ControlChars.NewLine +
        @"Level: (?<Level>\d+)" + ControlChars.NewLine +
        @"HP: (?<HP>\d+)" + ControlChars.NewLine +
        @"MP: (?<MP>\d+)" + ControlChars.NewLine +
        @"Attack: (?<Attack>\d+)" + ControlChars.NewLine +
        @"Defense: (?<Defense>\d+)" + ControlChars.NewLine +
        @"Evasion: (?<Evasion>\d+)" + ControlChars.NewLine +
        @"Magic: (?<Magic>\d+)" + ControlChars.NewLine +
        @"Magic Defense: (?<MagicDefense>\d+)" + ControlChars.NewLine +
        @"Magic Evasion: (?<MagicEvasion>\d+)" + ControlChars.NewLine +
        @"Speed: (?<Speed>\d+)" + ControlChars.NewLine +
        @"Gil: (?<Gil>\d+)" + ControlChars.NewLine +
        @"EXP: (?<Experience>\d+)" + ControlChars.NewLine +
        @"Steal: (?<Steal>.*?)" + ControlChars.NewLine +
        @"Drops: (?<Drops>.*?)" + ControlChars.NewLine +
        @"Elemental Immunity: (?<ElementalImmunity>.*?)" + ControlChars.NewLine +
        @"Weak Against: (?<ElementalWeakness>.*?)" + ControlChars.NewLine +
        @"Absorbs: (?<ElementalAbsorb>.*?)" + ControlChars.NewLine +
        @"Type: (?<Type>.*?)" + ControlChars.NewLine +
        @"Status Immunity: (?<StatusImmunity>.*?)" + ControlChars.NewLine +
        @"Vulnerable to: (?<StatusVulnerability>.*?)" + ControlChars.NewLine +
        @"Inherent Status: (?<InherentStatus>.*?)" + ControlChars.NewLine +
        @"Other Immunity: (?<OtherImmunity>.*?)" + ControlChars.NewLine +
        @"Special Attack: (?<SpecialAttack>.*?)" + ControlChars.NewLine +
        @"Rage: (?<Rage>.*?)" + ControlChars.NewLine +
        @"RageId: (?<RageId>\d{1,3})" + ControlChars.NewLine +
        @"Sketch: (?<Sketch>.*?)" + ControlChars.NewLine +
        @"Control: (?<Control>.*?)" + ControlChars.NewLine +
        @"Metamorphose: (?<Metamorphose>.*?)" + ControlChars.NewLine +
        @"MP Kill: (?<MPKill>No|Yes)" + ControlChars.NewLine +
        @"Imp Criticals: (?<ImpCriticals>No|Yes)" + ControlChars.NewLine +
        @"Run Difficulty: (?<RunDifficulty>.*?)" + ControlChars.NewLine;

    internal static string LocationRegexPattern =
        @"\[(?<World>\w+)\]\s" +
        @"(?<PrimaryLocation>.*?)" +
        @"(?:\s\((?<SecondaryLocation>.*?)\))*$";

    internal static string ChanceEventRegexPattern =
        @"(?<EventResult>.*?)\s" +
        @"\((?<Success>.*?)" +
        @"(?:\/(?<MaxChance>\d+))*\)";

    // Regex Identifiers: Bestiary
    internal static string MonsterId => @"MonsterId";
    internal static string SnesId => @"SnesId";
    internal static string GbaId => @"GbaId";
    internal static string SnesName => @"SnesName";
    internal static string GbaName => @"GbaName";
    internal static string PixelRemasterName => @"PixelRemasterName";
    internal static string Location => @"Location";
    internal static string Level => @"Level";
    internal static string HitPoints => @"HP";
    internal static string MagicPoints => @"MP";
    internal static string Attack => @"Attack";
    internal static string Defense => @"Defense";
    internal static string Evasion => @"Evasion";
    internal static string Magic => @"Magic";
    internal static string MagicDefense => @"MagicDefense";
    internal static string MagicEvasion => @"MagicEvasion";
    internal static string Speed => @"Speed";
    internal static string Gil => @"Gil";
    internal static string Experience => @"Experience";
    internal static string Steal => @"Steal";
    internal static string Drops => @"Drops";
    internal static string ElementalImmunity => @"ElementalImmunity";
    internal static string ElementalWeakness => @"ElementalWeakness";
    internal static string ElementalAbsorb => @"ElementalAbsorb";
    internal static string Type => @"Type";
    internal static string StatusImmunity => @"StatusImmunity";
    internal static string StatusVulnerability => @"StatusVulnerability";
    internal static string InherentStatus => @"InherentStatus";
    internal static string OtherImmunity => @"OtherImmunity";
    internal static string SpecialAttack => @"SpecialAttack";
    internal static string Rage => @"Rage";
    internal static string RageId => @"RageId";
    internal static string Sketch => @"Sketch";
    internal static string Control => @"Control";
    internal static string Metamorphose => @"Metamorphose";
    internal static string MPKill => @"MPKill";
    internal static string ImpCriticals => @"ImpCriticals";
    internal static string RunDifficulty => @"RunDifficulty";

    // Regex Identifiers: Location
    internal static string World => @"World";
    internal static string PrimaryLocation => @"PrimaryLocation";
    internal static string SecondaryLocation => @"SecondaryLocation";

    // Regex Identifiers: Chance Events
    internal static string EventResult => @"EventResult";
    internal static string Success => @"Success";
    internal static string MaxChance => @"MaxChance";
}
