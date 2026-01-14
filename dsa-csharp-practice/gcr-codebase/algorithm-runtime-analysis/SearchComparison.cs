using System;

class SearchComparison
{
    // Linear Search
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    // Binary Search
    static int BinarySearch(int[] arr, int target)
    {
        int low = 0,
            high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        Console.Write("Enter dataset size (e.g. 1000, 10000, 1000000): ");
        int n = int.Parse(Console.ReadLine());

        int[] data = new int[n];

        // Fill dataset
        for (int i = 0; i < n; i++)
            data[i] = i + 1;

        int target = n; // worst case target

        // -Linear Search Timing -
        DateTime startLinear = DateTime.Now;
        LinearSearch(data, target);
        DateTime endLinear = DateTime.Now;

        double linearTime = (endLinear - startLinear).TotalMilliseconds;

        // -- Binary Search Timing --
        DateTime sortStart = DateTime.Now;
        Array.Sort(data); // required for binary search
        DateTime sortEnd = DateTime.Now;

        DateTime startBinary = DateTime.Now;
        BinarySearch(data, target);
        DateTime endBinary = DateTime.Now;

        double binaryTime = (endBinary - startBinary).TotalMilliseconds;
        double sortTime = (sortEnd - sortStart).TotalMilliseconds;

        // -- Results --
        Console.WriteLine("\n----- Time Comparison (ms) -----");
        Console.WriteLine("Linear Search Time     : " + linearTime + " ms");
        Console.WriteLine("Sorting Time           : " + sortTime + " ms");
        Console.WriteLine("Binary Search Time     : " + binaryTime + " ms");
    }
}
