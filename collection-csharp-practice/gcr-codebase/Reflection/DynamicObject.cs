using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }
}

class DynamicObjectCreation
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Type t = typeof(Student);
        object obj = Activator.CreateInstance(t);
        PropertyInfo prop = t.GetProperty("Name");
        prop.SetValue(obj, name);

        Console.WriteLine("Student name: " + prop.GetValue(obj));
    }
}
