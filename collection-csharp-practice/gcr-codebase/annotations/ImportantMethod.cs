using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level;

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class Service
{
    [ImportantMethod]
    public void Critical() { }

    [ImportantMethod("LOW")]
    public void Minor() { }
}

class ImportantMethodDemo
{
    static void Main()
    {
        foreach (var m in typeof(Service).GetMethods())
        {
            var attr = (ImportantMethodAttribute)
                Attribute.GetCustomAttribute(m, typeof(ImportantMethodAttribute));
            if (attr != null)
                Console.WriteLine(m.Name + " Level: " + attr.Level);
        }
    }
}
