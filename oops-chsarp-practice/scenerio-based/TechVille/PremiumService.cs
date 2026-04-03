using System;

public class PremiumService : RoutineService
{
    public double PremiumFee { get; private set; }
    public string Features { get; private set; }

    public PremiumService(string name, double baseCost, double premiumFee, string features)
        : base(name, baseCost)
    {
        this.PremiumFee = premiumFee;
        this.Features = features;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Premium Fee: \u20b9" + PremiumFee);
        Console.WriteLine("Features: " + Features);
    }

    public override string GetServiceType()
    {
        return "Premium";
    }

    public double GetTotalCost()
    {
        return BaseCost + PremiumFee;
    }
}
