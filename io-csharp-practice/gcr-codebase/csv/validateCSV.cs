using System;
using System.IO;
using System.Text.RegularExpressions;

class validateCSV
{
    static void Main()
    {
        Regex email = new Regex(@"^[^@]+@[^@]+\.[^@]+$");
        Regex phone = new Regex(@"^\d{10}$");

        foreach (var line in File.ReadAllLines("users.csv"))
        {
            if (line.StartsWith("ID"))
                continue;
            var d = line.Split(',');
            if (!email.IsMatch(d[2]) || !phone.IsMatch(d[3]))
                Console.WriteLine("Invalid: " + line);
        }
    }
}
