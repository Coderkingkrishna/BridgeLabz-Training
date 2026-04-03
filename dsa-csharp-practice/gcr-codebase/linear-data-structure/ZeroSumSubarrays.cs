using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum = 0;
        bool found = false;

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];

            if (sum == 0 || map.ContainsKey(sum))
                found = true;

            map[sum] = i;
        }

        Console.WriteLine(found ? "Yes" : "No");
    }
}
