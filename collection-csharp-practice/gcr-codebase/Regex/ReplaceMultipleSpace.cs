using System;
using System.Text.RegularExpressions;

class ReplaceMultipleSpace
{
    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();
        string pattern = @"\s+";
        string replacement = " ";
        string result = Regex.Replace(sentence, pattern, replacement);
        Console.WriteLine("Modified Sentence:");
        Console.WriteLine(result);
    }
}
