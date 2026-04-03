using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name;

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

class Person
{
    [JsonField("user_name")]
    public string Name;
}

class JsonSerializationDemo
{
    static void Main()
    {
        Person p = new Person();
        Console.Write("Enter name: ");
        p.Name = Console.ReadLine();

        string json = "{";
        FieldInfo f = typeof(Person).GetField("Name");
        JsonFieldAttribute attr = (JsonFieldAttribute)
            Attribute.GetCustomAttribute(f, typeof(JsonFieldAttribute));
        json += "\"" + attr.Name + "\":\"" + f.GetValue(p) + "\"}";
        Console.WriteLine(json);
    }
}
