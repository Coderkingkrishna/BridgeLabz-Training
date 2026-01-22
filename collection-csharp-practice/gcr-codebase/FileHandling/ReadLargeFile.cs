using System;
using System.IO;

class ReadLargeFile
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("large.txt"))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.ToLower().Contains("error"))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
