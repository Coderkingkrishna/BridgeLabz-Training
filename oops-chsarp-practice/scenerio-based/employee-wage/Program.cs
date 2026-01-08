using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Employee");
        Console.WriteLine("Wage Computation");

        EmployeeMenu menu = new EmployeeMenu();
        menu.ShowMenu();
    }
}
