using System;
using System.IO;

class WordCount
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        Console.Write("Enter word to search: ");
        string word = Console.ReadLine();

        int count = 0;

        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                foreach (string w in words)
                    if (w.Equals(word))
                        count++;
            }
        }

        Console.WriteLine("Word Count: " + count);
    }
}
