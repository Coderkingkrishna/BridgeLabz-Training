using System;
using System.IO;

class WriteCSV
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter("new_employees.csv");
        sw.WriteLine("ID,Name,Department,Salary");
        for (int i = 1; i <= 5; i++)
            sw.WriteLine(i + ",Emp" + i + ",IT," + (40000 + i * 1000));
        Console.WriteLine("CSV written");
    }
}
