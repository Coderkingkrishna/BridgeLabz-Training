using System;
using System.Collections.Generic;
using System.Text;

class RemoveDuplicatesSB
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        HashSet<char> seen = new HashSet<char>();
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                sb.Append(c);
            }
        }

        Console.WriteLine("Result: " + sb.ToString());
    }
}
