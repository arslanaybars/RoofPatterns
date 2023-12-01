namespace RoofPatterns.RulePattern;

public class Flight
{
    public string Provider { get; set; } = null!;
    public string Airline { get; set; } = null!;
    public bool IsDirectFlight { get; set; }
    public bool IsOneWay { get; set; }
    public bool IsDomestic { get; set; }
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
}