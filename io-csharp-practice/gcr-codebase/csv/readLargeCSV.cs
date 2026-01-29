using System;
using System.IO;

class ReadLargeCSV
{
    static void Main()
    {
        if (!File.Exists("students.csv"))
        {
            Console.WriteLine("File not found");
            return;
        }

        int count = 0;

        using (StreamReader sr = new StreamReader("students.csv"))
        {
            sr.ReadLine();

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                count++;
                if (count % 100 == 0)
                    Console.WriteLine("Processed: " + count);
            }
        }

        Console.WriteLine("Total records: " + count);
    }
}
