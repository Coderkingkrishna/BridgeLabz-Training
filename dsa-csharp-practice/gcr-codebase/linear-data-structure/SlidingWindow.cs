using System;
using System.Collections.Generic;

class SlidingWindow
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter window size k: ");
        int k = int.Parse(Console.ReadLine());

        LinkedList<int> dq = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            if (dq.Count > 0 && dq.First.Value <= i - k)
                dq.RemoveFirst();

            while (dq.Count > 0 && arr[dq.Last.Value] <= arr[i])
                dq.RemoveLast();

            dq.AddLast(i);

            if (i >= k - 1)
                Console.Write(arr[dq.First.Value] + " ");
        }
    }
}
