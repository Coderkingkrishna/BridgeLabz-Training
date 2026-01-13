using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
                Console.WriteLine(line);
        }
    }
}
