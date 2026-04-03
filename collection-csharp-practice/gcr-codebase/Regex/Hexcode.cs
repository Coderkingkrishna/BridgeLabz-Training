using System;
using System.Text.RegularExpressions;

class Hexcode
{
    static void Main()
    {
        Console.Write("Enter Hexcode : ");
        string name = Console.ReadLine();
        String pattern = @"^[#][a-fA-F0-9]{6}$";
        if (Regex.IsMatch(name, pattern))
        {
            Console.WriteLine("Valid Hexcode");
        }
        else
        {
            Console.WriteLine("Invalid Hexcode");
        }
    }
}
