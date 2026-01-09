using System;
using System.Collections.Generic;

class LongestConsecutive
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            set.Add(arr[i]);
        }

        int longest = 0;

        foreach (int x in arr)
        {
            if (!set.Contains(x - 1))
            {
                int curr = x;
                int count = 1;

                while (set.Contains(curr + 1))
                {
                    curr++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        Console.WriteLine(longest);
    }
}
