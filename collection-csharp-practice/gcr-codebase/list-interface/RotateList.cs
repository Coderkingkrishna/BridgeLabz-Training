using System;
using System.Collections.Generic;

class RotateList
{
    public static void Run()
    {
        List<int> list = new List<int>();
        Console.WriteLine("Enter integers (comma separated):");
        string[] input = Console.ReadLine().Split(',');

        foreach (string s in input)
            list.Add(int.Parse(s.Trim()));

        Console.WriteLine("Enter rotation count:");
        int k = int.Parse(Console.ReadLine());
        k = k % list.Count;

        List<int> rotated = new List<int>();
        for (int i = k; i < list.Count; i++)
            rotated.Add(list[i]);
        for (int i = 0; i < k; i++)
            rotated.Add(list[i]);

        Console.WriteLine("Rotated List:");
        foreach (int val in rotated)
            Console.Write(val + " ");
        Console.WriteLine();
    }
}