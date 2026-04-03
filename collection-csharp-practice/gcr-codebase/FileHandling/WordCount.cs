using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                foreach (
                    var word in line.ToLower()
                        .Split(
                            new char[] { ' ', ',', '.', '!' },
                            StringSplitOptions.RemoveEmptyEntries
                        )
                )
                {
                    if (freq.ContainsKey(word))
                        freq[word]++;
                    else
                        freq[word] = 1;
                }
            }
        }

        foreach (var w in freq.OrderByDescending(x => x.Value).Take(5))
        {
            Console.WriteLine(w.Key + " " + w.Value);
        }
    }
}
