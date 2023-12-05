using RoofPatterns.RulePattern.Rules;

namespace RoofPatterns.RulePattern;

public class CommissionRuleEngine
{
    readonly List<ICommissionRule> _commissionRules = new();

    public CommissionRuleEngine(IEnumerable<ICommissionRule> commissionRules)
    {
        _commissionRules.AddRange(commissionRules);
    }
    
    public decimal IsApplicable(Flight flight, CommissionRule commissionRule)
    {
        bool isApplicable = _commissionRules.All(rule => rule.IsApplicable(flight));

        return isApplicable ? commissionRule.Price : 0;
    }
}