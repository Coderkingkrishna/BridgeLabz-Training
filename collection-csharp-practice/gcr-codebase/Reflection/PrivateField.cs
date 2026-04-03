using System;
using System.Reflection;

class Person
{
    private int age;
}

class PrivateFieldAccess
{
    static void Main()
    {
        Person p = new Person();
        Console.Write("Enter age value to set: ");
        int value = Convert.ToInt32(Console.ReadLine());

        FieldInfo field = typeof(Person).GetField(
            "age",
            BindingFlags.NonPublic | BindingFlags.Instance
        );
        field.SetValue(p, value);

        Console.WriteLine("Retrieved age: " + field.GetValue(p));
    }
}
