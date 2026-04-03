using System;
using System.Collections.Generic;

class HospitalTriage
{
    static void Main()
    {
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        Console.WriteLine("Enter number of patients:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter patient name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter severity:");
            int severity = int.Parse(Console.ReadLine());

            pq.Enqueue(name, -severity);
        }

        Console.WriteLine("Treatment Order:");
        while (pq.Count > 0)
            Console.WriteLine(pq.Dequeue());
    }
}