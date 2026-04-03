using System;
using System.Collections.Generic;

class SetToSortedList
{
    static void Main()
    {
        Console.WriteLine("Enter elements of the set:");
        string[] input = Console.ReadLine().Split(',');

        HashSet<int> set = new HashSet<int>();
        foreach (string s in input)
            set.Add(int.Parse(s.Trim()));

        List<int> list = new List<int>(set);
        list.Sort();

        Console.WriteLine("Sorted List:");
        foreach (int v in list)
            Console.Write(v + " ");
        Console.WriteLine();
    }
}
