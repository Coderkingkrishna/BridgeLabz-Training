using System;
using System.Collections.Generic;

class AadharRadixSort
{
    static void Main()
    {
        Console.Write("Enter number of Aadhar entries: ");
        int n = int.Parse(Console.ReadLine());

        long[] aadharNumbers = new long[n];

        Console.WriteLine("Enter 12-digit Aadhar numbers:");
        for (int i = 0; i < n; i++)
        {
            aadharNumbers[i] = long.Parse(Console.ReadLine());
        }

        // Scenario A: Sort using Radix Sort
        RadixSort(aadharNumbers);

        Console.WriteLine("\nSorted Aadhar Numbers (Ascending):");
        PrintArray(aadharNumbers);

        // Scenario B: Binary Search
        Console.Write("\nEnter Aadhar number to search: ");
        long target = long.Parse(Console.ReadLine());

        int index = BinarySearch(aadharNumbers, target);

        if (index != -1)
            Console.WriteLine("Aadhar number found at position: " + index);
        else
            Console.WriteLine("Aadhar number not found.");
    }

    // ---------------- RADIX SORT ----------------
    static void RadixSort(long[] arr)
    {
        long max = GetMax(arr);

        // Process each digit (1, 10, 100, ...)
        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSort(arr, exp);
        }
    }

    static void CountingSort(long[] arr, long exp)
    {
        int n = arr.Length;
        long[] output = new long[n];
        int[] count = new int[10];

        // Count occurrences
        for (int i = 0; i < n; i++)
        {
            int digit = (int)((arr[i] / exp) % 10);
            count[digit]++;
        }

        // Prefix sum (stable ordering)
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        // Build output array (RIGHT to LEFT ensures stability)
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)((arr[i] / exp) % 10);
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }

        // Copy back
        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }

    static long GetMax(long[] arr)
    {
        long max = arr[0];
        foreach (long num in arr)
        {
            if (num > max)
                max = num;
        }
        return max;
    }

    // ---------------- BINARY SEARCH ----------------
    static int BinarySearch(long[] arr, long target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    static void PrintArray(long[] arr)
    {
        foreach (long num in arr)
        {
            Console.WriteLine(num);
        }
    }
}
