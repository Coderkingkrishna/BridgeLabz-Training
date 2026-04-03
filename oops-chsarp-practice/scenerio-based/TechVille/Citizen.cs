using System;
using System.Collections.Generic;

public class Citizen
{
    private static int _idCounter = 1000;
    public int CitizenId { get; private set; }

    private readonly List<Service> subscribedServices = new List<Service>();

    private string _name;
    private int _age;
    private double _income;
    private int _residencyYears;
    private int _zone;
    private int _sector;
    private string _email;
    private string _address;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = ProfileUtility.FormatName(value);
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 120)
                throw new InvalidAgeException("Age must be between 0 and 120.");
            _age = value;
        }
    }

    public double Income
    {
        get => _income;
        set
        {
            if (value < 0)
                throw new ArgumentException("Income cannot be negative.");
            _income = value;
        }
    }

    public int ResidencyYears
    {
        get => _residencyYears;
        set
        {
            if (value < 0)
                throw new ArgumentException("Residency years cannot be negative.");
            _residencyYears = value;
        }
    }

    public int Zone
    {
        get => _zone;
        set
        {
            if (value < 1 || value > 5)
                throw new ArgumentException("Zone must be between 1 and 5.");
            _zone = value;
        }
    }

    public int Sector
    {
        get => _sector;
        set
        {
            if (value < 1 || value > 10)
                throw new ArgumentException("Sector must be between 1 and 10.");
            _sector = value;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (!ProfileUtility.IsValidEmail(value))
                throw new ArgumentException("Invalid email format.");
            _email = value;
        }
    }

    public string Address
    {
        get => _address;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Address cannot be empty.");
            _address = value;
        }
    }

    public Citizen(
        string name,
        int age,
        double income,
        int residencyYears,
        int zone,
        int sector,
        string email,
        string address
    )
    {
        CitizenId = ++_idCounter;
        Name = name;
        Age = age;
        Income = income;
        ResidencyYears = residencyYears;
        Zone = zone;
        Sector = sector;
        Email = email;
        Address = address;
    }

    public void Subscribe(Service service)
    {
        subscribedServices.Add(service);
        Console.WriteLine(Name + " subscribed to " + service.ServiceName);

        if (service is PremiumService premiumService)
        {
            Console.WriteLine("Premium features activated: " + premiumService.Features);
        }
    }

    public void UpgradeToPremium(Service premiumService)
    {
        if (!(premiumService is PremiumService))
        {
            Console.WriteLine("Upgrade failed: selected service is not premium.");
            return;
        }

        Service existing = subscribedServices.Find(s =>
            s.ServiceName.Equals(premiumService.ServiceName, StringComparison.OrdinalIgnoreCase)
        );

        if (existing == null)
        {
            Console.WriteLine(
                "No existing subscription found for " + premiumService.ServiceName + "."
            );
            return;
        }

        if (existing is PremiumService)
        {
            Console.WriteLine("Already subscribed to premium " + premiumService.ServiceName + ".");
            return;
        }

        subscribedServices.Remove(existing);
        subscribedServices.Add(premiumService);
        Console.WriteLine("Upgraded to premium " + premiumService.ServiceName + ".");
    }

    public void ViewServices()
    {
        if (subscribedServices.Count == 0)
        {
            Console.WriteLine("No services subscribed.");
            return;
        }

        foreach (var s in subscribedServices)
        {
            if (s is PremiumService premiumService)
                Console.WriteLine(
                    "- " + s.ServiceName + " Premium (₹" + premiumService.GetTotalCost() + ")"
                );
            else
                Console.WriteLine("- " + s.ServiceName + " (₹" + s.BaseCost + ")");
        }
    }

    public void Display()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("Citizen ID: " + CitizenId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Income: ₹" + Income);
        Console.WriteLine("Residency Years: " + ResidencyYears);
        Console.WriteLine("Zone: " + Zone + " | Sector: " + Sector);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("---------------------------------");
    }
}
