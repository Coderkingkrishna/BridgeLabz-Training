using System;
using System.IO;

class UpdateSalary
{
    static void Main()
    {
        if (!File.Exists("employees.csv"))
        {
            Console.WriteLine("Source file not found");
            return;
        }

        string[] lines = File.ReadAllLines("employees.csv");

        if (lines.Length == 0)
        {
            Console.WriteLine("CSV file is empty");
            return;
        }

        using (StreamWriter sw = new StreamWriter("employees_updated.csv"))
        {
            foreach (var line in lines)
            {
                if (line.StartsWith("ID"))
                {
                    sw.WriteLine(line);
                    continue;
                }

                var d = line.Split(',');

                if (d.Length >= 4 && d[2] == "IT")
                    d[3] = (double.Parse(d[3]) * 1.1).ToString();

                sw.WriteLine(string.Join(",", d));
            }
        }

        Console.WriteLine("Updated CSV created");
    }
}
