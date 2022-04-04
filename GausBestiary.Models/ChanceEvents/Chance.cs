namespace GausBestiary.Models.ChanceEvents;

/// <summary>
/// Stores and displays the chance of something occurring.
/// </summary>
public class Chance
{
    private int success;
    private int maxChance;

    /// <summary>
    /// The number of times out of MaxChance that this event occurs.
    /// </summary>
    public int Success
    {
        get => success;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), 
                    "Success must be greater than or equal to zero (0).");
            }

            success = value;
        }
    }
    
    /// <summary>
    /// The maximum possible number of outcomes.
    /// </summary>
    public int MaxChance
    {
        get => maxChance;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    "MaxChance must be greater than zero (0).");
            }

            maxChance = value;
        }
    }

    /// <summary>
    /// The chance of the event occurring, expressed as a percentage.
    /// </summary>
    public string Percentage => 
        $"{Math.Round((double)Success / MaxChance * 100, 1)}%";

    /// <summary>
    /// The chance of the event occurring, expressed as a string.
    /// <example>
    /// For example, (Never), (Always), or (1/8).
    /// </example>
    /// </summary>
    public string Text => 
        success == 0 
            ? "Never" 
            : success == maxChance 
                ? "Always" 
                : $"{Success}/{MaxChance}";

    /// <summary>
    /// Default constructor. Initializes to 0 / 8 chance of event occurring.
    /// </summary>
    public Chance()
    {
        Success = 0;
        MaxChance = 8;
    }

    /// <summary>
    /// Initializes to <paramref name="success"/> / <paramref name="maxChance"/> chance of event occurring.
    /// </summary>
    /// <param name="success">The number of times out of maxChance that this event occurs.</param>
    /// <param name="maxChance">The maximum possible number of outcomes.</param>
    public Chance(int success, int maxChance)
    {
        Success = success;
        MaxChance = maxChance;
    }
}