using RoofPatterns.RulePattern.Rules;

namespace RoofPatterns.RulePattern;

public class CommissionCalculator
{
    public decimal CalculateDiscountPercentage(Flight flight, List<CommissionRule> commissionRules)
    {
        // var ruleType = typeof(ICommissionRule);
        // var rules = GetType().Assembly.GetTypes()
        //     .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
        //     .Select(r => Activator.CreateInstance(r) as ICommissionRule)
        //     .Where(r => r != null)
        //     .Select(r => r!);

        List<ICommissionRule> rules = commissionRules
            .SelectMany(rule => typeof(CommissionRule).GetProperties()
                .Where(p => typeof(ICommissionRule).IsAssignableFrom(p.PropertyType) &&
                            p.GetValue(rule) != null)
                .Select(p => p.GetValue(rule) as ICommissionRule)
                .Where(r => r != null)
                .Select(r => r!))
            .ToList();


        // airline commission rules
        var engine = new CommissionRuleEngine(rules);

        var commission = commissionRules.Max(commissionRule => engine.IsApplicable(flight, commissionRule));

        return commission;
    }
}