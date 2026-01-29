using System;
using System.IO;
using System.Linq;

class sortBySalary
{
    static void Main()
    {
        var data = File.ReadAllLines("employees.csv")
            .Skip(1)
            .OrderByDescending(x => double.Parse(x.Split(',')[3]))
            .Take(5);
        foreach (var r in data)
            Console.WriteLine(r);
    }
}
