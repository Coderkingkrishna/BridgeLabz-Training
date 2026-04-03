using System;
using System.IO;

class FilterMarks
{
    static void Main()
    {
        foreach (var line in File.ReadAllLines("students.csv"))
        {
            if (line.StartsWith("ID"))
                continue;
            var d = line.Split(',');
            if (int.Parse(d[3]) > 80)
                Console.WriteLine(line);
        }
    }
}
