namespace RoofPatterns.RulePattern.Rules;

public class ItineraryCommissionRule(bool isOneWay) : ICommissionRule
{
    private bool IsOneWay { get; init; } = isOneWay;

    public bool IsApplicable(Flight flight)
    {
        return flight.IsOneWay == IsOneWay;
    }
}