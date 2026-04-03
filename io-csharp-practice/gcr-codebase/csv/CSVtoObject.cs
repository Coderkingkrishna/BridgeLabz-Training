using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string Id;
    public string Name;
    public string Age;
    public string Marks;
}

class CSVtoObject
{
    static void Main()
    {
        List<Student> list = new List<Student>();
        foreach (var line in File.ReadAllLines("students.csv"))
        {
            if (line.StartsWith("ID"))
                continue;
            var d = line.Split(',');
            list.Add(
                new Student
                {
                    Id = d[0],
                    Name = d[1],
                    Age = d[2],
                    Marks = d[3],
                }
            );
        }

        foreach (var s in list)
            Console.WriteLine(s.Name + " " + s.Marks);
    }
}
