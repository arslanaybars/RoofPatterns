namespace RoofPatterns.RulePattern.Rules;

public class OriginCommissionRule(List<string> origins) : ICommissionRule
{
    private List<string> Origins { get; init; } = origins;

    public bool IsApplicable(Flight flight)
    {
        return Origins.Contains(flight.Origin);
    }
}