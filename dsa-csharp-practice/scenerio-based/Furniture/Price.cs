using System;
using System.Collections.Generic;

class Price
{
    private Dictionary<int, int> prices = new Dictionary<int, int>();

    public void AddPrice(int length, int price)
    {
        prices[length] = price;
    }

    public int GetPrice(int length)
    {
        return prices.ContainsKey(length) ? prices[length] : 0;
    }
}
