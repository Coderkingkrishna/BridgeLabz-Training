using System;
using System.Collections.Generic;

class SetEquality
{
    static void Main()
    {
        HashSet<int> set1 = ReadSet("Enter elements of Set1 (comma separated):");
        HashSet<int> set2 = ReadSet("Enter elements of Set2 (comma separated):");

        bool isEqual = set1.SetEquals(set2);
        Console.WriteLine("Are sets equal: " + isEqual);
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
