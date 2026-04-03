using System;

class SearchWord
{
    static void Main()
    {
        string[] sentences = { "I love C sharp", "Data Structures are important" };

        string word = "Data";

        foreach (string s in sentences)
        {
            if (s.Contains(word))
            {
                Console.WriteLine("Found in: " + s);
                return;
            }
        }
    }
}
