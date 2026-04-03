using System;

class LinearSearchNegative
{
    static void Main()
    {
        int[] arr = { 5, 2, -3, 7 };

        foreach (int x in arr)
        {
            if (x < 0)
            {
                Console.WriteLine("First Negative: " + x);
                return;
            }
        }
    }
}
