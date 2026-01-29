using System;
using System.Collections.Generic;
using System.IO;

class MergeCSV
{
    static void Main()
    {
        if (!File.Exists("students1.csv") || !File.Exists("students2.csv"))
        {
            Console.WriteLine("Input file missing");
            return;
        }

        var map = new Dictionary<string, string>();

        foreach (var l in File.ReadAllLines("students1.csv"))
        {
            if (l.StartsWith("ID"))
                continue;

            var d = l.Split(',');
            if (d.Length >= 4)
                map[d[0]] = l;
        }

        using (StreamWriter sw = new StreamWriter("merged.csv"))
        {
            sw.WriteLine("ID,Name,Age,Marks,Grade");

            foreach (var l in File.ReadAllLines("students2.csv"))
            {
                if (l.StartsWith("ID"))
                    continue;

                var d = l.Split(',');
                if (d.Length >= 3 && map.ContainsKey(d[0]))
                    sw.WriteLine(map[d[0]] + "," + d[1] + "," + d[2]);
            }
        }

        Console.WriteLine("CSV files merged successfully");
    }
}
