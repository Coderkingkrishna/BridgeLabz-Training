using System;

class BubbleSortMarks
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];
        for (int i = 0; i < n; i++)
            marks[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Marks:");
        foreach (int x in marks)
            Console.Write(x + " ");
    }
}
