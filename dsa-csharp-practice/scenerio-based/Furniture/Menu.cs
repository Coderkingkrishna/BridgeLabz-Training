using System;

class Menu
{
    public void Run()
    {
        Price chart = new Price();

        chart.AddPrice(1, 2);
        chart.AddPrice(2, 6);
        chart.AddPrice(3, 7);
        chart.AddPrice(4, 10);
        chart.AddPrice(5, 13);
        chart.AddPrice(6, 17);
        chart.AddPrice(7, 17);
        chart.AddPrice(8, 20);
        chart.AddPrice(9, 24);
        chart.AddPrice(10, 30);
        chart.AddPrice(11, 32);
        chart.AddPrice(12, 35);

        WoodenRod rod = new WoodenRod(12);
        WoodCutter cutter = new WoodCutter();

        Console.WriteLine("Scenario A: Max");
        Console.WriteLine("Max Revenue: " + cutter.MaxRevenue(rod.Length, chart));

        Console.WriteLine("\nScenario B: Waste <= 1ft");
        CutResult result = cutter.MaxRevenueWithWaste(rod.Length, chart, 1);
        Console.WriteLine("Revenue: " + result.Revenue);
        Console.WriteLine("Waste: " + result.Waste + " ft");

        Console.WriteLine("\n Scenario C: Best");
        Console.WriteLine("Suggested revenue with minimal waste:");
        Console.WriteLine("Revenue: " + result.Revenue + ", Waste: " + result.Waste + " ft");
    }
}
