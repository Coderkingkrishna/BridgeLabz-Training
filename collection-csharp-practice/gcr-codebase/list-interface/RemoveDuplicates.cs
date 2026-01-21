using System;
using System.Collections.Generic;

class RemoveDuplicates
{
    public static void Run()
    {
        List<int> list = new List<int>();
        Console.WriteLine("Enter integers (comma separated):");
        string[] input = Console.ReadLine().Split(',');

        foreach (string s in input)
            list.Add(int.Parse(s.Trim()));

        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int val in list)
        {
            if (!seen.Contains(val))
            {
                seen.Add(val);
                result.Add(val);
            }
        }

        Console.WriteLine("After removing duplicates:");
        foreach (int val in result)
            Console.Write(val + " ");
        Console.WriteLine();
    }
}
