using System;

class FibonacciComparison
{
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static int FibonacciIterative(int n)
    {
        int a = 0,
            b = 1,
            sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    static void Main()
    {
        Console.Write("Enter Fibonacci number N: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 40)
        {
            DateTime rStart = DateTime.Now;
            FibonacciRecursive(n);
            DateTime rEnd = DateTime.Now;

            Console.WriteLine("Recursive Time (ms): " + (rEnd - rStart).TotalMilliseconds);
        }
        else
        {
            Console.WriteLine("Recursive skipped (too slow)");
        }

        DateTime iStart = DateTime.Now;
        FibonacciIterative(n);
        DateTime iEnd = DateTime.Now;

        Console.WriteLine("Iterative Time (ms): " + (iEnd - iStart).TotalMilliseconds);
    }
}
