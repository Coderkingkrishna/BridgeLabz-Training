using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        Console.WriteLine("Enter queue elements (comma separated):");
        string[] input = Console.ReadLine().Split(',');

        foreach (string s in input)
            queue.Enqueue(int.Parse(s.Trim()));

        Stack<int> stack = new Stack<int>();

        while (queue.Count > 0)
            stack.Push(queue.Dequeue());

        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());

        Console.WriteLine("Reversed Queue:");
        foreach (int v in queue)
            Console.Write(v + " ");
    }
}