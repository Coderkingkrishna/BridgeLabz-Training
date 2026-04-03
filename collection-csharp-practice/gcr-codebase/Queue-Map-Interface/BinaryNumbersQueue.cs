using System;
using System.Collections.Generic;

class BinaryNumbersQueue
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        Console.WriteLine("Binary Numbers:");
        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            Console.Write(current + " ");

            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
    }
}