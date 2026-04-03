using System;

public static class InputUtility
{
    public static int GetInt(string message)
    {
        while (true)
        {
            try
            {
                Console.Write(message);
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format. Please enter digits only.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number too large. Try again.");
            }
        }
    }

    public static double GetDouble(string message)
    {
        while (true)
        {
            try
            {
                Console.Write(message);
                return double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid decimal value. Try again.");
            }
        }
    }

    public static string GetString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
}
