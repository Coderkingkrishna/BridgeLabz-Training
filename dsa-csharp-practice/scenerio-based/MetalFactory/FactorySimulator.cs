using System;

class FactorySimulator
{
    public void Run()
    {
        PriceChart chart = new PriceChart();

        chart.AddPrice(1, 1);
        chart.AddPrice(2, 5);
        chart.AddPrice(3, 8);
        chart.AddPrice(4, 9);
        chart.AddPrice(5, 10);
        chart.AddPrice(6, 17);
        chart.AddPrice(7, 17);
        chart.AddPrice(8, 20);

        RodCutter cutter = new RodCutter();

        Console.WriteLine("==Scenario A==");
        Rod rod8 = new Rod(8);
        Console.WriteLine("Max Revenue: " + cutter.GetMaxRevenue(rod8, chart));

        Console.WriteLine("\n== Scenario B: Custom ===");
        chart.AddPrice(9, 24);
        Rod rod9 = new Rod(9);
        Console.WriteLine("Max Revenue (Length 9): " + cutter.GetMaxRevenue(rod9, chart));

        Console.WriteLine("\n= Scenario C:=");
        Console.WriteLine("Revenue without cuts: " + cutter.NoCutRevenue(rod8, chart));
    }
}
