namespace RoofPatterns.RulePattern.Rules;

public class ProviderCommissionRule(List<string> providers) : ICommissionRule
{
    private List<string> Providers { get; init; } = providers;

    public bool IsApplicable(Flight flight)
    {
        return providers.Contains(flight.Provider);
    }
}