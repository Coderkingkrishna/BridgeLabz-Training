using System;
using System.Text.RegularExpressions;

class ExtractDate
{
    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();

        string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/\d{2}/\d{4}\b";

        MatchCollection matches = Regex.Matches(sentence, pattern);

        Console.WriteLine("Extracted Dates:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
