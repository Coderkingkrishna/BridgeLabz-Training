using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class DynamicMethodCall
{
    static void Main()
    {
        MathOperations m = new MathOperations();

        Console.Write("Enter method name (Add, Subtract, Multiply): ");
        string name = Console.ReadLine();

        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        MethodInfo method = typeof(MathOperations).GetMethod(name);
        Console.WriteLine("Result: " + method.Invoke(m, new object[] { a, b }));
    }
}
