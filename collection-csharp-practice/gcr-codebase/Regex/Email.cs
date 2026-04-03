using System;
using System.Text.RegularExpressions;

class Email
{
    static void Main()
    {
        Console.Write("Enter the sentence containing email: ");
        string sentence = Console.ReadLine();
        string pattern = @"[a-zA-Z0-9.%+-_]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        MatchCollection matches = Regex.Matches(sentence, pattern);
        Console.WriteLine("Extracted email addresses:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
