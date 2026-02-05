using System;
using System.Text.RegularExpressions;

class ValidPlateNumber
{
    static void Main()
    {
        Console.Write("Enter Plate Number : ");
        string plateNumber = Console.ReadLine();
        string pattern = @"^[A-Z]{2}[0-9]{4}$";
        if (Regex.IsMatch(plateNumber, pattern))
        {
            Console.WriteLine("Valid Plate Number");
        }
        else
        {
            Console.WriteLine("Invalid Plate Number");
        }
    }
}
