using Microsoft.VisualBasic;

namespace GausBestiary.Models.ProviderSettings;

internal static class RageSettings
{
    internal static string FileName => @"rages_regex.txt";

    internal static string AttackSpellRegexPattern =>
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
        @"(?:Description: (?<Description>.*?)" + ControlChars.NewLine + ")?";

    internal static string HealingSpellRegexPattern =>
        @"RageId: (?<RageId>\d{1,3})" + ControlChars.NewLine +
        @"GBA Name: (?<GBAName>.*?)" + ControlChars.NewLine +
        @"SNES Name: (?<SNESName>.*?)" + ControlChars.NewLine +
        @"Power: (?<Power>.*?)" + ControlChars.NewLine +
        @"Description: (?<Description>.*?)" + ControlChars.NewLine;

    internal static string MeleeAttackRegexPattern =>
        @"RageId: (?<RageId>\d{1,3})" + ControlChars.NewLine +
        @"GBA Name: (?<GBAName>.*?)" + ControlChars.NewLine +
        @"SNES Name: (?<SNESName>.*?)" + ControlChars.NewLine +
        @"Level: (?<Level>\d+)" + ControlChars.NewLine +
        @"Power: (?<Power>.*?)" + ControlChars.NewLine;

    internal static string StatusAttackRegexPattern =>
        @"RageId: (?<RageId>\d{1,3})" + ControlChars.NewLine +
        @"GBA Name: (?<GBAName>.*?)" + ControlChars.NewLine +
        @"SNES Name: (?<SNESName>.*?)" + ControlChars.NewLine +
        @"Status: (?<Status>.*?)" + ControlChars.NewLine;

    internal static string StatusSpellRegexPattern =>
        @"RageId: (?<RageId>\d{1,3})" + ControlChars.NewLine +
        @"GBA Name: (?<GBAName>.*?)" + ControlChars.NewLine +
        @"SNES Name: (?<SNESName>.*?)" + ControlChars.NewLine +
        @"Target: (?<Target>.*?)" + ControlChars.NewLine +
        @"Hit Rate: (?<HitRate>.*?)" + ControlChars.NewLine +
        @"Unblockable: (?<Unblockable>Yes|No)" + ControlChars.NewLine +
        @"Status: (?<Status>.*?)" + ControlChars.NewLine +
        @"(?:Description: (?<Description>.*?)" + ControlChars.NewLine + ")?";

    // Regex Identifiers
    internal static string RageId => @"RageId";
    internal static string GbaName => @"GBAName";
    internal static string SnesName => @"SNESName";
    internal static string Level => @"Level";
    internal static string Power => @"Power";
    internal static string HitRate => @"HitRate";
    internal static string Target => @"Target";
    internal static string Element => @"Element";
    internal static string Status => @"Status";
    internal static string IgnoresDefense => @"IgnoresDefense";
    internal static string Unblockable => @"Unblockable";
    internal static string SplitsDamage => @"SplitsDamage";
    internal static string Description => @"Description";
}
