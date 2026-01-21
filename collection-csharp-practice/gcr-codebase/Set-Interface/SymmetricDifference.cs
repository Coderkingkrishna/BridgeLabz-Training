using System;
using System.Collections.Generic;

class SymmetricDifference
{
    static void Main()
    {
        HashSet<int> set1 = ReadSet("Enter elements of Set1:");
        HashSet<int> set2 = ReadSet("Enter elements of Set2:");

        HashSet<int> result = new HashSet<int>(set1);
        result.SymmetricExceptWith(set2);

        Console.WriteLine("Symmetric Difference:");
        foreach (int v in result)
            Console.Write(v + " ");
        Console.WriteLine();
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