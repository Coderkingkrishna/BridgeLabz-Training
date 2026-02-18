using System;

public static class InputUtility
{
    public static int GetInt(string message)
    {
        int value;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out value))
                return value;

            Console.WriteLine("Invalid number. Try again.");
        }
    }

    public static double GetDouble(string message)
    {
        double value;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out value))
                return value;

            Console.WriteLine("Invalid number. Try again.");
        }
    }

    public static string GetString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
}
