using System;
using System.Collections.Generic;

class ReverseListLinkedList
{
    public static void Run()
    {
        LinkedList<int> list = new LinkedList<int>();
        Console.WriteLine("Enter integers for LinkedList (comma separated):");
        string[] input = Console.ReadLine().Split(',');

        foreach (string s in input)
            list.AddLast(int.Parse(s.Trim()));

        LinkedList<int> reversed = new LinkedList<int>();
        foreach (int val in list)
            reversed.AddFirst(val);

        Console.WriteLine("Reversed LinkedList:");
        foreach (int val in reversed)
            Console.Write(val + " ");
        Console.WriteLine();
    }
}