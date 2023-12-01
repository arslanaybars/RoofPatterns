namespace RoofPatterns.RulePattern.Rules;

public class AirlineCommissionRule(List<string> airlines) : ICommissionRule
{
    private List<string> Airlines { get; init; } = airlines;

    public bool IsApplicable(Flight flight)
    {
        return Airlines.Contains(flight.Airline);
    }
}