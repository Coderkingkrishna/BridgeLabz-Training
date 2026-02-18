using System;

public class Citizen
{
    private string _name;
    private int _age;
    private double _income;
    private int _residencyYears;

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative.");
            _age = value;
        }
    }

    public double Income
    {
        get { return _income; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Income cannot be negative.");
            _income = value;
        }
    }

    public int ResidencyYears
    {
        get { return _residencyYears; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Residency years cannot be negative.");
            _residencyYears = value;
        }
    }

    public Citizen(string name, int age, double income, int residencyYears)
    {
        Name = name;
        Age = age;
        Income = income;
        ResidencyYears = residencyYears;
    }

    public void Display()
    {
        Console.WriteLine("\n---- Citizen Details ----");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Income: ₹" + Income);
        Console.WriteLine("Residency Years: " + ResidencyYears);
    }
}
