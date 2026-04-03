using System;

class PropagationDemo
{
    static void Method1()
    {
        int a = 10;
        int b = 0;
        int x = a / b; // runtime exception
    }

    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            Method2();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
