using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class Calculator
{
    private static Dictionary<int, int> cache = new Dictionary<int, int>();

    [CacheResult]
    public int Square(int n)
    {
        if (cache.ContainsKey(n))
            return cache[n];

        int result = n * n;
        cache[n] = result;
        return result;
    }
}

class CacheDemo
{
    static void Main()
    {
        Calculator c = new Calculator();
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        MethodInfo m = typeof(Calculator).GetMethod("Square");
        Console.WriteLine("Result: " + m.Invoke(c, new object[] { n }));
        Console.WriteLine("Result from cache: " + m.Invoke(c, new object[] { n }));
    }
}
