using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    static Stack<int> s1 = new Stack<int>();
    static Stack<int> s2 = new Stack<int>();

    static void Enqueue(int x)
    {
        s1.Push(x);
    }

    static int Dequeue()
    {
        if (s2.Count == 0)
            while (s1.Count > 0)
                s2.Push(s1.Pop());

        return s2.Pop();
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element: ");
            Enqueue(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Dequeued Element: " + Dequeue());
    }
}
