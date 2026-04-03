using System;
using System.IO;

class ReadCSV
{
    static void Main()
    {
        StreamReader sr = new StreamReader("students.csv");
        sr.ReadLine();
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            var d = line.Split(',');
            Console.WriteLine(
                "ID: " + d[0] + " Name: " + d[1] + " Age: " + d[2] + " Marks: " + d[3]
            );
        }
    }
}
