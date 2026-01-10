using System;

class InsertionSortIDs
{
    static void Main()
    {
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int[] ids = new int[n];
        for (int i = 0; i < n; i++)
            ids[i] = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            int key = ids[i];
            int j = i - 1;

            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            ids[j + 1] = key;
        }

        Console.WriteLine("Sorted Employee IDs:");
        foreach (int x in ids)
            Console.Write(x + " ");
    }
}
