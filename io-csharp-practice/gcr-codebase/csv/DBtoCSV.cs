using System;
using System.IO;

class DBtoCSV
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter("db_export.csv");
        sw.WriteLine("EmployeeID,Name,Department,Salary");
        sw.WriteLine("1,Alice,IT,50000");
        sw.WriteLine("2,Bob,HR,40000");
        Console.WriteLine("CSV generated from DB simulation");
    }
}
