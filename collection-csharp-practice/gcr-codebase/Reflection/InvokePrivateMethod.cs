using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class InvokePrivateMethod
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Calculator calc = new Calculator();
        MethodInfo method = typeof(Calculator).GetMethod(
            "Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance
        );
        Console.WriteLine("Result: " + method.Invoke(calc, new object[] { a, b }));
    }
}
