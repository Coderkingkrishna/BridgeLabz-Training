using System;
using System.Collections.Generic;

public class CitizenService : ICitizenService
{
    private List<Citizen> citizens = new List<Citizen>();

    private int[] citizenIds = new int[1000];
    private int idIndex = 0;

    private int[,] zoneSectorCounts = new int[5, 10];

    public void RegisterFamily(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            try
            {
                Console.WriteLine("\nRegistering Member " + i);

                string name = InputUtility.GetString("Enter Name: ");
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Invalid name. Skipping...");
                    continue;
                }

                int age = InputUtility.GetInt("Enter Age: ");
                if (age < 0)
                {
                    Console.WriteLine("Negative age entered. Stopping registration.");
                    break;
                }

                double income = InputUtility.GetDouble("Enter Income: ");
                int residency = InputUtility.GetInt("Enter Residency Years: ");
                int zone = InputUtility.GetInt("Enter Zone (1-5): ");
                int sector = InputUtility.GetInt("Enter Sector (1-10): ");

                Citizen citizen = new Citizen(name, age, income, residency, zone, sector);
                citizens.Add(citizen);

                citizenIds[idIndex++] = citizen.CitizenId;
                zoneSectorCounts[zone - 1, sector - 1]++;

                double score = CalculateEligibility(citizen);
                string package = DeterminePackage(score);

                string status = age >= 18 ? "Adult" : "Minor";

                Console.WriteLine("Status: " + status);
                Console.WriteLine("Eligibility Score: " + score);
                Console.WriteLine("Service Package: " + package);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
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
        if (score < 40)
            return "Basic";
        else if (score < 60)
            return "Silver";
        else if (score < 80)
            return "Gold";
        else
            return "Platinum";
    }

    public void SortCitizenIds()
    {
        Array.Sort(citizenIds, 0, idIndex);
        Console.WriteLine("Citizen IDs Sorted Successfully.");
    }

    public void SearchCitizenById(int id)
    {
        int index = Array.IndexOf(citizenIds, id, 0, idIndex);

        if (index >= 0)
            Console.WriteLine("Citizen ID Found.");
        else
            Console.WriteLine("Citizen ID Not Found.");
    }
}
