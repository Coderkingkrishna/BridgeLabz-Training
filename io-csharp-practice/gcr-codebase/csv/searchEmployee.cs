using System;
using System.IO;

class SearchEmployee
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        foreach (var line in File.ReadAllLines("employees.csv"))
        {
            if (line.StartsWith("ID"))
                continue;
            var d = line.Split(',');
            if (d[1].Equals(name, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Dept: " + d[2] + " Salary: " + d[3]);
        }
    }
}
