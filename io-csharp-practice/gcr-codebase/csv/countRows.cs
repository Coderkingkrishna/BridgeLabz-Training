using System;
using System.IO;

class CountRows
{
    static void Main()
    {
        int count = File.ReadAllLines("students.csv").Length - 1;
        Console.WriteLine("Total records: " + count);
    }
}
