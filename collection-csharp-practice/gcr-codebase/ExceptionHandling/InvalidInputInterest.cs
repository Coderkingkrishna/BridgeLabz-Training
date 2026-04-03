using System;

class InterestCalculation
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
            throw new ArgumentException();

        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            double amount = Convert.ToDouble(Console.ReadLine());
            double rate = Convert.ToDouble(Console.ReadLine());
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateInterest(amount, rate, years));
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid input: Amount and rate must be positive");
        }
    }
}
