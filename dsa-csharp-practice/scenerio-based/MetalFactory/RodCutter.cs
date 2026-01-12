using System;

class RodCutter
{
    public int GetMaxRevenue(Rod rod, PriceChart chart)
    {
        return CutRod(rod.Length, chart);
    }

    private int CutRod(int length, PriceChart chart)
    {
        if (length == 0)
            return 0;

        int maxRevenue = chart.GetPrice(length); // no cut case

        for (int cut = 1; cut < length; cut++)
        {
            int revenue = chart.GetPrice(cut) + CutRod(length - cut, chart);

            maxRevenue = Math.Max(maxRevenue, revenue);
        }

        return maxRevenue;
    }

    // Scenario C: No optimization
    public int NoCutRevenue(Rod rod, PriceChart chart)
    {
        return chart.GetPrice(rod.Length);
    }
}
