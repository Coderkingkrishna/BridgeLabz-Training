using System;
using System.Collections.Generic;

class UnionIntersection
{
    static void Main()
    {
        HashSet<int> set1 = ReadSet("Enter elements of Set1:");
        HashSet<int> set2 = ReadSet("Enter elements of Set2:");

        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);

        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);

        Console.WriteLine("Union:");
        PrintSet(union);

        Console.WriteLine("Intersection:");
        PrintSet(intersection);
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

    static void PrintSet(HashSet<int> set)
    {
        foreach (int v in set)
            Console.Write(v + " ");
        Console.WriteLine();
    }
}