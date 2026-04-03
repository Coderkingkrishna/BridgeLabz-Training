using System;
using System.Collections.Generic;

class NthFromEnd
{
    public static void Run()
    {
        LinkedList<string> list = new LinkedList<string>();
        Console.WriteLine("Enter elements (comma separated):");
        string[] input = Console.ReadLine().Split(',');

        foreach (string s in input)
            list.AddLast(s.Trim());

        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());

        LinkedListNode<string> fast = list.First;
        LinkedListNode<string> slow = list.First;

        for (int i = 0; i < n; i++)
        {
            if (fast == null)
            {
                Console.WriteLine("N is larger than list size");
                return;
            }
            fast = fast.Next;
        }

        while (fast != null)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        Console.WriteLine("Nth element from end: " + slow.Value);
    }
}
