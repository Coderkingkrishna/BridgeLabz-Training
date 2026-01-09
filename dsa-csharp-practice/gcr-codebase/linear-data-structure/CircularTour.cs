using System;

class CircularTour
{
    static void Main()
    {
        Console.Write("Enter number of petrol pumps: ");
        int n = int.Parse(Console.ReadLine());

        int[] petrol = new int[n];
        int[] dist = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Petrol: ");
            petrol[i] = int.Parse(Console.ReadLine());
            Console.Write("Distance: ");
            dist[i] = int.Parse(Console.ReadLine());
        }

        int start = 0,
            balance = 0,
            deficit = 0;

        for (int i = 0; i < n; i++)
        {
            balance += petrol[i] - dist[i];
            if (balance < 0)
            {
                start = i + 1;
                deficit += balance;
                balance = 0;
            }
        }

        Console.WriteLine((balance + deficit >= 0) ? start : -1);
    }
}
