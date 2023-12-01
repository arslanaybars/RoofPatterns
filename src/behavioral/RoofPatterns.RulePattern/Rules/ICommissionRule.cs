namespace RoofPatterns.RulePattern.Rules;

public interface ICommissionRule
{
    bool IsApplicable(Flight flight);
}