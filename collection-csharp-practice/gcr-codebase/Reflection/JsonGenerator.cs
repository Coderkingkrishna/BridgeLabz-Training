using System;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class JsonGenerator
{
    static void Main()
    {
        User u = new User();

        Console.Write("Enter name: ");
        u.Name = Console.ReadLine();

        Console.Write("Enter age: ");
        u.Age = Convert.ToInt32(Console.ReadLine());

        Type t = u.GetType();
        FieldInfo[] fields = t.GetFields();

        string json = "{";
        for (int i = 0; i < fields.Length; i++)
        {
            json += "\"" + fields[i].Name + "\"" + ":" + "\"" + fields[i].GetValue(u) + "\"";
            if (i < fields.Length - 1)
                json += ",";
        }
        json += "}";

        Console.WriteLine("Generated JSON: " + json);
    }
}
