using System;
using System.Collections.Generic;
using System.IO;

class WordFrequencyFile
{
    static void Main()
    {
        Console.WriteLine("Enter file path:");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("File not found");
            return;
        }

        string text = File.ReadAllText(path).ToLower();
        char[] separators = { ' ', ',', '.', '!', '?', '\n', '\r' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }

        Console.WriteLine("Word Frequencies:");
        foreach (var pair in freq)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }
}