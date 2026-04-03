using System;
using System.Text.RegularExpressions;

class ValidIp
{
    static void Main()
    {
        Console.Write("Enter Ip : ");
        string name = Console.ReadLine();
        String pattern =
            @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        if (Regex.IsMatch(name, pattern))
        {
            Console.WriteLine("Valid Ip");
        }
        else
        {
            Console.WriteLine("Invalid Ip");
        }
    }
}
