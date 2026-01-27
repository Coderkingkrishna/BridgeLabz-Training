using System;
using System.Text.RegularExpressions;

class RepeatingWords
{
    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();

        string pattern = @"\b(\w+)\s+\1\b";

        MatchCollection matches = Regex.Matches(sentence, pattern, RegexOptions.IgnoreCase);

        Console.WriteLine("Repeating words:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }
}
