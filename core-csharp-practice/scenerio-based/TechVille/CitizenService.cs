using System;
using System.Collections.Generic;

public class CitizenService : ICitizenService
{
    private List<Citizen> citizens = new List<Citizen>();

    public void RegisterFamily(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("\nRegistering Member " + i);

            string name = InputUtility.GetString("Enter Name: ");

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid name. Skipping...");
                continue; // continue demonstration
            }

            int age = InputUtility.GetInt("Enter Age: ");

            if (age < 0)
            {
                Console.WriteLine("Negative age entered. Stopping registration.");
                break; // break demonstration
            }

            double income = InputUtility.GetDouble("Enter Income: ");
            int residency = InputUtility.GetInt("Enter Residency Years: ");

            Citizen citizen = new Citizen(name, age, income, residency);
            citizens.Add(citizen);

            double score = CalculateEligibility(citizen);
            string package = DeterminePackage(score);

            string status = age >= 18 ? "Adult" : "Minor"; // ternary

            Console.WriteLine("Status: " + status);
            Console.WriteLine("Eligibility Score: " + score);
            Console.WriteLine("Service Package: " + package);
        }
    }

    public void ViewCitizens()
    {
        if (citizens.Count == 0)
        {
            Console.WriteLine("No citizens registered.");
            return;
        }

        foreach (var citizen in citizens)
        {
            citizen.Display();
        }
    }

    private double CalculateEligibility(Citizen citizen)
    {
        double score = 0;

        // Nested if-else
        if (citizen.Age >= 18)
        {
            if (citizen.Age >= 60)
                score += 30;
            else
                score += 20;
        }

        if (citizen.Income < 300000)
            score += 30;
        else if (citizen.Income < 800000)
            score += 20;
        else
            score += 10;

        if (citizen.ResidencyYears >= 10)
            score += 40;
        else if (citizen.ResidencyYears >= 5)
            score += 25;
        else
            score += 10;

        return score;
    }

    private string DeterminePackage(double score)
    {
        switch (score)
        {
            case double s when (s < 40):
                return "Basic";
            case double s when (s < 60):
                return "Silver";
            case double s when (s < 80):
                return "Gold";
            default:
                return "Platinum";
        }
    }
}
