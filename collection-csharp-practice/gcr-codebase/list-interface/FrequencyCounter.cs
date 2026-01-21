using System;
using System.Collections.Generic;

class FrequencyCounter
{
    public static void Run()
    {
        Console.WriteLine("Enter strings (comma separated):");
        string[] input = Console.ReadLine().Split(',');

        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string s in input)
        {
            string key = s.Trim();
            if (freq.ContainsKey(key))
                freq[key]++;
            else
                freq[key] = 1;
        }

        Console.WriteLine("Frequencies:");
        foreach (var pair in freq)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }
}
