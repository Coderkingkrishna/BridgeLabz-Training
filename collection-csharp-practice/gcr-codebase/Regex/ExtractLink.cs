using System;
using System.Text.RegularExpressions;

class ExtractLink
{
    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();

        string pattern = @"https?://[^\s]+";

        MatchCollection matches = Regex.Matches(sentence, pattern);

        Console.WriteLine("Extracted Links:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
