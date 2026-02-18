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
                int age = InputUtility.GetInt("Enter Age: ");
                double income = InputUtility.GetDouble("Enter Income: ");
                int residency = InputUtility.GetInt("Enter Residency Years: ");
                int zone = InputUtility.GetInt("Enter Zone (1-5): ");
                int sector = InputUtility.GetInt("Enter Sector (1-10): ");
                string email = InputUtility.GetString("Enter Email: ");
                string address = InputUtility.GetString("Enter Address: ");

                Citizen citizen = new Citizen(
                    name,
                    age,
                    income,
                    residency,
                    zone,
                    sector,
                    email,
                    address
                );

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
        foreach (var citizen in citizens)
            citizen.Display();
    }

    private double CalculateEligibility(Citizen citizen)
    {
        double score = 0;

        if (citizen.Age >= 18)
            score += (citizen.Age >= 60) ? 30 : 20;

        score +=
            (citizen.Income < 300000) ? 30
            : (citizen.Income < 800000) ? 20
            : 10;

        score +=
            (citizen.ResidencyYears >= 10) ? 40
            : (citizen.ResidencyYears >= 5) ? 25
            : 10;

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
        Console.WriteLine("Citizen IDs Sorted.");
    }

    public void SearchCitizenById(int id)
    {
        int index = Array.IndexOf(citizenIds, id, 0, idIndex);
        Console.WriteLine(index >= 0 ? "Citizen Found." : "Citizen Not Found.");
    }

    public void SearchByName(string name)
    {
        foreach (var citizen in citizens)
        {
            if (citizen.Name.ToLower().Contains(name.ToLower()))
                citizen.Display();
        }
    }

    public void UpdateIncomeByValue(int id, double newIncome)
    {
        foreach (var citizen in citizens)
        {
            if (citizen.CitizenId == id)
            {
                double temp = newIncome; // pass by value
                citizen.Income = temp;
                Console.WriteLine("Income Updated.");
                return;
            }
        }
    }

    public void UpdateAddressByReference(int id, ref string newAddress)
    {
        foreach (var citizen in citizens)
        {
            if (citizen.CitizenId == id)
            {
                citizen.Address = newAddress;
                Console.WriteLine("Address Updated.");
                return;
            }
        }
    }

    public Citizen GenerateProfile()
    {
        Random rand = new Random();

        string name = "Citizen" + rand.Next(100, 999);
        int age = rand.Next(18, 70);
        double income = rand.Next(200000, 1000000);
        int residency = rand.Next(1, 20);
        int zone = rand.Next(1, 6);
        int sector = rand.Next(1, 11);

        string email = ProfileUtility.GenerateEmail(name);
        string address = "CityCenter, TechVille";

        return new Citizen(name, age, income, residency, zone, sector, email, address);
    }
}
