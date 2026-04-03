using System;
using System.Linq;

class Challenge
{
    static void Main()
    {
        int[] arr = { 3, 4, -1, 1 };

        // First Missing Positive
        bool[] seen = new bool[arr.Length + 1];

        foreach (int x in arr)
            if (x > 0 && x <= arr.Length)
                seen[x] = true;

        for (int i = 1; i <= arr.Length; i++)
        {
            if (!seen[i])
            {
                Console.WriteLine("First Missing Positive: " + i);
                break;
            }
        }

        // Binary Search
        Array.Sort(arr);
        int target = 3;
        int index = Array.BinarySearch(arr, target);

        Console.WriteLine("Target Index: " + index);
    }
}
