using System;
using System.Collections.Generic;

class PairSum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target sum: ");
        int sum = int.Parse(Console.ReadLine());

        HashSet<int> set = new HashSet<int>();

        foreach (int x in arr)
        {
            int required = sum - x;

            if (set.Contains(required))
            {
                Console.WriteLine("Pair is: " + required + " , " + x);
                return;
            }
            set.Add(x);
        }

        Console.WriteLine("Pair Not Found");
    }
}
