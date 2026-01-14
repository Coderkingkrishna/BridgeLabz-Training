using System;
using System.Text;

class StringConcatComparison
{
    static void Main()
    {
        Console.Write("Enter number of concatenations: ");
        int n = int.Parse(Console.ReadLine());

        // Using string
        DateTime sStart = DateTime.Now;
        string str = "";
        for (int i = 0; i < n; i++)
            str += "A";
        DateTime sEnd = DateTime.Now;

        // Using StringBuilder
        DateTime sbStart = DateTime.Now;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append("A");
        DateTime sbEnd = DateTime.Now;

        Console.WriteLine("\nTime Taken (ms)");
        Console.WriteLine("String        : " + (sEnd - sStart).TotalMilliseconds);
        Console.WriteLine("StringBuilder : " + (sbEnd - sbStart).TotalMilliseconds);
    }
}
