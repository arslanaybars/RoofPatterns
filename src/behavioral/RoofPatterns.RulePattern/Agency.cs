namespace RoofPatterns.RulePattern;

public class Agency
{
    public Agency(string name, DateTime registrationDate, bool isVip = false)
    {
        Name = name;
        RegistrationDate = registrationDate;
        IsVip = isVip;
        CommissionRules = new();
    }

    public void AddCommissionRules(CommissionRule commissionRule)
    {
        CommissionRules.Add(commissionRule);
    }

    public string Name { get; init; } = null!;
    public DateTime RegistrationDate { get; init; }
    public bool IsVip { get; init; }

    public List<CommissionRule> CommissionRules { get; private set; }
}