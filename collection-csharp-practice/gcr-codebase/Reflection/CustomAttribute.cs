using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name;

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("Default Author")]
class SampleClass { }

class AttributeReader
{
    static void Main()
    {
        Type t = typeof(SampleClass);
        AuthorAttribute attr = (AuthorAttribute)
            Attribute.GetCustomAttribute(t, typeof(AuthorAttribute));
        Console.WriteLine("Author name: " + attr.Name);
    }
}
