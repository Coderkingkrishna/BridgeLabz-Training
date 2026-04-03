using System;

class CutResult
{
    public int Revenue { get; set; }
    public int Waste { get; set; }

    public CutResult(int revenue, int waste)
    {
        Revenue = revenue;
        Waste = waste;
    }
}
