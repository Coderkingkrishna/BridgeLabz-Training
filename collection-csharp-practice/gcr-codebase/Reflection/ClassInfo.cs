using System;
using System.Reflection;

class ClassInfo
{
    static void Main()
    {
        Console.Write("Enter full class name (Example: System.String): ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine("Class not found");
            return;
        }

        Console.WriteLine("Methods:");
        foreach (var m in type.GetMethods())
            Console.WriteLine(m.Name);

        Console.WriteLine("Fields:");
        foreach (
            var f in type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
            )
        )
            Console.WriteLine(f.Name);

        Console.WriteLine("Constructors:");
        foreach (var c in type.GetConstructors())
            Console.WriteLine(c.ToString());
    }
}
