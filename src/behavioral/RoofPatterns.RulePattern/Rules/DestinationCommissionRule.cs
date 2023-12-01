namespace RoofPatterns.RulePattern.Rules;

public class DestinationCommissionRule(List<string> destinations) : ICommissionRule
{
    private List<string> Destinations { get; init; } = destinations;

    public bool IsApplicable(Flight flight)
    {
        return Destinations.Contains(flight.Destination);
    }
}