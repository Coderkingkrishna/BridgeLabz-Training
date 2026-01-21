using System;
using System.Collections.Generic;

class SubsetCheck
{
    static void Main()
    {
        HashSet<int> subset = ReadSet("Enter elements of first set:");
        HashSet<int> superset = ReadSet("Enter elements of second set:");

        bool isSubset = subset.IsSubsetOf(superset);
        Console.WriteLine("Is first set a subset of second: " + isSubset);
    }

    static HashSet<int> ReadSet(string message)
    {
        Console.WriteLine(message);
        string[] input = Console.ReadLine().Split(',');
        HashSet<int> set = new HashSet<int>();
        foreach (string s in input)
            set.Add(int.Parse(s.Trim()));
        return set;
    }
}
