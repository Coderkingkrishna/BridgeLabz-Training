using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class ObjectMapperDemo
{
    static void Main()
    {
        Dictionary<string, object> map = new Dictionary<string, object>();

        Console.Write("Enter name: ");
        map["Name"] = Console.ReadLine();

        Console.Write("Enter age: ");
        map["Age"] = Convert.ToInt32(Console.ReadLine());

        User u = (User)Activator.CreateInstance(typeof(User));

        foreach (var item in map)
        {
            FieldInfo field = typeof(User).GetField(item.Key);
            field.SetValue(u, item.Value);
        }

        Console.WriteLine("Mapped Object: " + u.Name + " " + u.Age);
    }
}
