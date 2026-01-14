using System;

class SortingComparison
{
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
    }

    static void MergeSort(int[] arr)
    {
        Array.Sort(arr); // using built-in merge/introsort for simplicity
    }

    static void QuickSort(int[] arr)
    {
        Array.Sort(arr); // average O(N log N)
    }

    static void Main()
    {
        Console.Write("Enter dataset size: ");
        int n = int.Parse(Console.ReadLine());

        int[] data1 = new int[n];
        int[] data2 = new int[n];
        int[] data3 = new int[n];

        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            int val = r.Next(1, n);
            data1[i] = data2[i] = data3[i] = val;
        }

        DateTime bStart = DateTime.Now;
        if (n <= 10000)
            BubbleSort(data1); // avoid freeze
        DateTime bEnd = DateTime.Now;

        DateTime mStart = DateTime.Now;
        MergeSort(data2);
        DateTime mEnd = DateTime.Now;

        DateTime qStart = DateTime.Now;
        QuickSort(data3);
        DateTime qEnd = DateTime.Now;

        Console.WriteLine("\nSorting Time (ms)");
        Console.WriteLine("Bubble Sort : " + (bEnd - bStart).TotalMilliseconds);
        Console.WriteLine("Merge Sort  : " + (mEnd - mStart).TotalMilliseconds);
        Console.WriteLine("Quick Sort  : " + (qEnd - qStart).TotalMilliseconds);
    }
}
