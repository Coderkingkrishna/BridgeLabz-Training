using System;

class WoodCutter
{
    // Scenario A: Maximize revenue with cuts
    public int MaxRevenue(int length, Price chart)
    {
        if (length == 0)
            return 0;

        int best = chart.GetPrice(length);

        for (int cut = 1; cut < length; cut++)
        {
            int revenue = chart.GetPrice(cut) + MaxRevenue(length - cut, chart);

            best = Math.Max(best, revenue);
        }
        return best;
    }

    // Scenario B and c:
    public CutResult MaxRevenueWithWaste(int length, Price chart, int maxWaste)
    {
        CutResult best = new CutResult(chart.GetPrice(length), 0);

        for (int cut = 1; cut <= length; cut++)
        {
            int remaining = length - cut;

            if (remaining < 0)
                continue;

            int waste = remaining;

            if (waste > maxWaste)
                continue;

            int revenue = chart.GetPrice(cut);

            if (revenue > best.Revenue || (revenue == best.Revenue && waste < best.Waste))
            {
                best = new CutResult(revenue, waste);
            }
        }
        return best;
    }
}
