using System;
using System.Collections.Generic;

public class CitizenService : ICitizenService
{
    private List<Citizen> citizens = new List<Citizen>();

    public void AddCitizen(Citizen citizen)
    {
        citizens.Add(citizen);
        Console.WriteLine("Citizen Registered Successfully!");
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
            double score = CalculateEligibility(citizen);
            Console.WriteLine("Eligibility Score: " + score);
        }
    }

    public double CalculateEligibility(Citizen citizen)
    {
        double score = 0;

        if (citizen.Age >= 60)
            score += 30;
        else if (citizen.Age >= 18)
            score += 20;

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
}
