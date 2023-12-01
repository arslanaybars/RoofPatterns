namespace RoofPatterns.RulePattern.Rules;

public class FlightTypeCommissionRule(bool isDomestic) : ICommissionRule
{
    private bool IsDomestic { get; init; } = isDomestic;

    public bool IsApplicable(Flight flight)
    {
        return flight.IsDomestic == IsDomestic;
    }
}