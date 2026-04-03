using System;
using System.Text.RegularExpressions;

class ValidateSSN
{
    static void Main()
    {
        Console.Write("Enter the ssn: ");
        string ssn = Console.ReadLine();
        string pattern = @"\b\d{3}-\d{2}-\d{4}\b";

        Match match = Regex.Match(ssn, pattern);

        if (match.Success)
            Console.WriteLine(match.Value + " is valid");
        else
            Console.WriteLine("Invalid SSN");
    }
}
