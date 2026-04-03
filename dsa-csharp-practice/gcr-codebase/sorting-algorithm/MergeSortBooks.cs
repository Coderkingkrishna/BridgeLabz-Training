using System;

class MergeSortBooks
{
    static void MergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = (l + r) / 2;
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);
            Merge(arr, l, m, r);
        }
    }

    static void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
            L[i] = arr[l + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[m + 1 + j];

        int i1 = 0,
            i2 = 0,
            k = l;

        while (i1 < n1 && i2 < n2)
            arr[k++] = (L[i1] <= R[i2]) ? L[i1++] : R[i2++];

        while (i1 < n1)
            arr[k++] = L[i1++];
        while (i2 < n2)
            arr[k++] = R[i2++];
    }

    static void Main()
    {
        Console.Write("Enter number of books: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        for (int i = 0; i < n; i++)
            prices[i] = int.Parse(Console.ReadLine());

        MergeSort(prices, 0, n - 1);

        Console.WriteLine("Sorted Book Prices:");
        foreach (int x in prices)
            Console.Write(x + " ");
    }
}
