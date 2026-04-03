using System;
using System.Text.RegularExpressions;

class ValidateUsername
{
    static void Main()
    {
        Console.Write("Enter name : ");
        string name = Console.ReadLine();
        String pattern = @"^[A-Za-z][a-zA-Z0-9_]{4,14}$";
        if (Regex.IsMatch(name, pattern))
        {
            Console.WriteLine("Valid username");
        }
        else
        {
            Console.WriteLine("Invalid username");
        }
    }
}
