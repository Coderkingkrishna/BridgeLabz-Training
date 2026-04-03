using System;
using System.Text.RegularExpressions;

class CensorWords
{
    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();
        string[] censorWords = { "bad", "ugly", "nasty", "damn" };
        string pattern = @"\b(" + string.Join("|", censorWords) + @")\b";
        string replacement = new string('*', 4);
        string result = Regex.Replace(sentence, pattern, replacement, RegexOptions.IgnoreCase);
        Console.WriteLine("Censored Sentence:");
        Console.WriteLine(result);
    }
}
