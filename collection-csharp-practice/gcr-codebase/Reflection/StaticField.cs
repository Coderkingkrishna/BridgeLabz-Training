using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class StaticFieldAccess
{
    static void Main()
    {
        Console.Write("Enter new API key: ");
        string key = Console.ReadLine();

        FieldInfo field = typeof(Configuration).GetField(
            "API_KEY",
            BindingFlags.NonPublic | BindingFlags.Static
        );
        field.SetValue(null, key);

        Console.WriteLine("Updated API key: " + field.GetValue(null));
    }
}
