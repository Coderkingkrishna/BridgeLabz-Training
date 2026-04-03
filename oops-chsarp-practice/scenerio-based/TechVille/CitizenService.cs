using System;
using System.Collections.Generic;

public class CitizenService : ICitizenService
{
    private List<Citizen> citizens = new List<Citizen>();
    private readonly List<Service> services = new List<Service>();
    private int[] citizenIds = new int[1000];
    private int idIndex = 0;
    private int[,] zoneSectorCounts = new int[5, 10];

    public CitizenService()
    {
        services.Add(ServiceFactory.CreateStandard(ServiceKind.Healthcare));
        services.Add(ServiceFactory.CreateStandard(ServiceKind.Education));
        services.Add(ServiceFactory.CreateStandard(ServiceKind.Transportation));
        services.Add(ServiceFactory.CreateStandard(ServiceKind.Utility));
        services.Add(ServiceFactory.CreateStandard(ServiceKind.Emergency));

        services.Add(ServiceFactory.CreatePremium(ServiceKind.Healthcare));
        services.Add(ServiceFactory.CreatePremium(ServiceKind.Education));
        services.Add(ServiceFactory.CreatePremium(ServiceKind.Transportation));
        services.Add(ServiceFactory.CreatePremium(ServiceKind.Utility));
        services.Add(ServiceFactory.CreatePremium(ServiceKind.Emergency));

        RegisterExternalProviders();
        foreach (var externalService in ProviderRegistry.LoadServices())
            services.Add(externalService);
    }

    private void RegisterExternalProviders()
    {
        ProviderRegistry.Register(new PrivateClinicProvider());
    }

    public void RegisterFamily(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            try
            {
                Console.WriteLine("\n===== Registering Citizen " + i + " =====");

                string name = InputUtility.GetString("Enter Name: ");

                if (IsDuplicate(name))
                    throw new DuplicateCitizenException("Citizen already exists with same name.");

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

                Console.WriteLine("Citizen Registered Successfully!");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Age Error: " + ex.Message);
                Logger.Log(ex.Message);
            }
            catch (DuplicateCitizenException ex)
            {
                Console.WriteLine("Duplicate Error: " + ex.Message);
                Logger.Log(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Validation Error: " + ex.Message);
                Logger.Log(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error Occurred.");
                Logger.Log(ex.Message);
            }
            finally
            {
                Console.WriteLine("Registration process completed.\n");
            }
        }
    }

    private bool IsDuplicate(string name)
    {
        foreach (var c in citizens)
        {
            if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
    }

    public void ViewCitizens()
    {
        if (citizens.Count == 0)
        {
            Console.WriteLine("No citizens registered yet.");
            return;
        }

        Console.WriteLine("\n===== Registered Citizens =====");
        foreach (var c in citizens)
            c.Display();
    }

    public void SortCitizenIds()
    {
        Array.Sort(citizenIds, 0, idIndex);
        Console.WriteLine("Citizen IDs sorted successfully.");
    }

    public void SearchCitizenById(int id)
    {
        int index = Array.IndexOf(citizenIds, id, 0, idIndex);
        Console.WriteLine(index >= 0 ? "Citizen Found." : "Citizen Not Found.");
    }

    public void SearchByName(string name)
    {
        bool found = false;

        foreach (var c in citizens)
        {
            if (c.Name.ToLower().Contains(name.ToLower()))
            {
                c.Display();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No citizen found with that name.");
    }

    public void UpdateIncomeByValue(int id, double newIncome)
    {
        foreach (var c in citizens)
        {
            if (c.CitizenId == id)
            {
                double temp = newIncome;
                c.Income = temp;
                Console.WriteLine("Income updated successfully.");
                return;
            }
        }

        Console.WriteLine("Citizen not found.");
    }

    public void UpdateAddressByReference(int id, ref string newAddress)
    {
        foreach (var c in citizens)
        {
            if (c.CitizenId == id)
            {
                c.Address = newAddress;
                Console.WriteLine("Address updated successfully.");
                return;
            }
        }

        Console.WriteLine("Citizen not found.");
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
        string address = name + "Central City, TechVille";

        Citizen citizen = new Citizen(name, age, income, residency, zone, sector, email, address);

        citizens.Add(citizen);
        citizenIds[idIndex++] = citizen.CitizenId;
        zoneSectorCounts[zone - 1, sector - 1]++;

        return citizen;
    }

    public void ViewAvailableServices()
    {
        foreach (var s in services)
        {
            s.Display();
            Console.WriteLine("------------------");
        }

        Console.WriteLine("Total services across city: " + Service.TotalServices);
    }

    public void SubscribeToService()
    {
        int cid = InputUtility.GetInt("Enter Citizen ID: ");
        int sid = InputUtility.GetInt("Enter Service ID: ");

        Citizen citizen = citizens.Find(c => c.CitizenId == cid);
        Service service = services.Find(s => s.ServiceId == sid);

        if (citizen == null || service == null)
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        citizen.Subscribe(service);
        ProcessServiceBooking(service, citizen);
    }

    private void ProcessServiceBooking(IBookable bookable, Citizen citizen)
    {
        bookable.Register(citizen);

        ITrackable trackable = bookable as ITrackable;
        if (trackable != null)
            trackable.CheckStatus();
    }

    public void ViewCitizenServices()
    {
        int cid = InputUtility.GetInt("Enter Citizen ID: ");

        Citizen citizen = citizens.Find(c => c.CitizenId == cid);

        if (citizen == null)
        {
            Console.WriteLine("Citizen not found.");
            return;
        }

        citizen.ViewServices();
    }

    public void UpgradeServiceForCitizen()
    {
        int cid = InputUtility.GetInt("Enter Citizen ID: ");
        int sid = InputUtility.GetInt("Enter Premium Service ID: ");

        Citizen citizen = citizens.Find(c => c.CitizenId == cid);
        Service service = services.Find(s => s.ServiceId == sid);

        if (citizen == null)
        {
            Console.WriteLine("Citizen not found.");
            return;
        }

        if (service == null)
        {
            Console.WriteLine("Service not found.");
            return;
        }

        if (!(service is PremiumService))
        {
            Console.WriteLine("Selected service is not a premium service.");
            return;
        }

        citizen.UpgradeToPremium(service);
    }
}
