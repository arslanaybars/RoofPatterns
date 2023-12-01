using RoofPatterns.RulePattern.Rules;

namespace RoofPatterns.RulePattern;

public class CommissionRule
{
    public string Name { get; set; } = null!;
    
    public ProviderCommissionRule? ProviderCommissionRule { get; set; }
    public AirlineCommissionRule? AirlineCommissionRule { get; set; }
    public DestinationCommissionRule? DestinationCommissionRule { get; set; }
    public FlightTypeCommissionRule? DomesticCommissionRule { get; set; }
    public OriginCommissionRule? OriginCommissionRule { get; set; }
    public ItineraryCommissionRule? RoundWayCommissionRule { get; set; }
    
    
    public decimal Price { get; set; }
    public bool IsPercentage { get; set; }
}