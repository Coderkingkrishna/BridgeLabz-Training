using System;
using System.Collections.Generic;
using System.IO;

class detectDuplicates
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        foreach (var l in File.ReadAllLines("students.csv"))
        {
            if (l.StartsWith("ID"))
                continue;
            var id = l.Split(',')[0];
            if (!set.Add(id))
                Console.WriteLine("Duplicate ID: " + id);
        }
    }
}
