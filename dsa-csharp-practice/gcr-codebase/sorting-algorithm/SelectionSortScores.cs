using System;

class SelectionSortScores
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] scores = new int[n];
        for (int i = 0; i < n; i++)
            scores[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < n; j++)
                if (scores[j] < scores[min])
                    min = j;

            int temp = scores[min];
            scores[min] = scores[i];
            scores[i] = temp;
        }

        Console.WriteLine("Sorted Exam Scores:");
        foreach (int x in scores)
            Console.Write(x + " ");
    }
}
