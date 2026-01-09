using System;
using System.Collections.Generic;

class TwoSum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target: ");
        int target = int.Parse(Console.ReadLine());

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            if (map.ContainsKey(target - arr[i]))
            {
                Console.WriteLine(map[target - arr[i]] + " " + i);
                return;
            }
            map[arr[i]] = i;
        }
    }
}
