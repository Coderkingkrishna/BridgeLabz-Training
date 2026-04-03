using System;
using System.Text.RegularExpressions;

class ExtractCapWord
{
    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();
        string pattern = @"\b[A-Z][a-z]*\b";
        MatchCollection matches = Regex.Matches(sentence, pattern);
        Console.WriteLine("Extracted Capitalized Words:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
