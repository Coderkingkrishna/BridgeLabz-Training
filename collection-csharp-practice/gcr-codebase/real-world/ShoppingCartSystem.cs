using System;
using System.Collections.Generic;

class ShoppingCartSystem
{
    static void Main()
    {
        Dictionary<string, double> prices = new Dictionary<string, double>();
        List<string> insertionOrder = new List<string>();
        SortedDictionary<double, List<string>> sortedByPrice =
            new SortedDictionary<double, List<string>>();

        Console.WriteLine("Enter number of products:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Product name:");
            string name = Console.ReadLine();

            Console.WriteLine("Price:");
            double price = double.Parse(Console.ReadLine());

            prices[name] = price;
            insertionOrder.Add(name);

            if (!sortedByPrice.ContainsKey(price))
                sortedByPrice[price] = new List<string>();

            sortedByPrice[price].Add(name);
        }

        Console.WriteLine("Insertion Order:");
        foreach (string p in insertionOrder)
            Console.WriteLine(p + " " + prices[p]);

        Console.WriteLine("Sorted By Price:");
        foreach (var p in sortedByPrice)
        foreach (string name in p.Value)
            Console.WriteLine(name + " " + p.Key);
    }
}
