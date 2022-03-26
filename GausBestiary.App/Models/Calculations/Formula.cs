using System;

namespace GausBestiary.App.Models.Calculations
{
    public class Formula
    {
        public int Success { get; set; }
        public int MaxChance { get; set; }

        public string Percentage => 
            ((double)Success / MaxChance).ToString("P");

        public string Text => $"({Success} / {MaxChance})";

        public Formula(int success, int maxChance)
        {
            Success = success;
            MaxChance = maxChance;
        }
    }
}
