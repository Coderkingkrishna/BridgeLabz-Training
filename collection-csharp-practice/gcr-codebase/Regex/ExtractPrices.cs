using System;
using System.Text.RegularExpressions;

class ExtractPrices
{
    static void Main()
    {
        Console.Write("Enter the text: ");
        string text = Console.ReadLine();

        string pattern = @"\$?\s?\d+\.\d{2}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.Trim());
        }
    }
}
