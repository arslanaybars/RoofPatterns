using FluentAssertions;
using RoofPatterns.RulePattern.Rules;
using Xunit;

namespace RoofPatterns.RulePattern.Test;

public class CommissionCalculate
{
    private CommissionCalculator _calculator = new();

    [Fact]
    public void Returns5PctForDomesticOneWay()
    {
        var flight = new Flight
        {
            IsDomestic = true,
            IsOneWay = true,
            Origin = "SCL",
            Destination = "LIM",
            Airline = "THY"
        };

        var agency = new Agency("Agency 1", DateTime.Now);
        
        agency.AddCommissionRules(new CommissionRule
        {
            Name = "Commission Rule 1",
            AirlineCommissionRule = new AirlineCommissionRule(new List<string>
            {
                "THY"
            }),
            DomesticCommissionRule = new FlightTypeCommissionRule(true),
            OriginCommissionRule = new OriginCommissionRule(new List<string>
            {
                "SCL"
            }),
            DestinationCommissionRule = new DestinationCommissionRule(new List<string>
            {
                "LIM"
            }),
            Price = 5
        });
        
        agency.AddCommissionRules(new CommissionRule
        {
            Name = "Commission Rule 2",
            AirlineCommissionRule = new AirlineCommissionRule(new List<string>
            {
                "THY"
            }),
            DomesticCommissionRule = new FlightTypeCommissionRule(true),
            OriginCommissionRule = new OriginCommissionRule(new List<string>
            {
                "SCL"
            }),
            DestinationCommissionRule = new DestinationCommissionRule(new List<string>
            {
                "LIM"
            }),
            Price = 15
        });

        var result = _calculator.CalculateDiscountPercentage(flight, agency.CommissionRules);

        result.Should().Be(5);
    }
}