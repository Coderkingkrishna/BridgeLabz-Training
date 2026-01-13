using System;
using System.Text;

class ConcatenateStrings
{
    static void Main()
    {
        Console.Write("Enter number of strings: ");
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        Console.WriteLine("Enter strings:");
        for (int i = 0; i < n; i++)
            sb.Append(Console.ReadLine());

        Console.WriteLine("Concatenated String:");
        Console.WriteLine(sb.ToString());
    }
}
