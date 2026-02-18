using System;

public class Menu
{
    private ICitizenService service;

    public Menu()
    {
        service = new CitizenService();
    }

    public void Start()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n===== TechVille Smart City Portal =====");
            Console.WriteLine("1. Register Citizen");
            Console.WriteLine("2. View All Citizens");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterCitizen();
                    break;

                case "2":
                    service.ViewCitizens();
                    break;

                case "3":
                    exit = true;
                    Console.WriteLine("Exiting System...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private void RegisterCitizen()
    {
        try
        {
            string name = InputUtility.GetString("Enter Name: ");
            int age = InputUtility.GetInt("Enter Age: ");
            double income = InputUtility.GetDouble("Enter Income: ");
            int residency = InputUtility.GetInt("Enter Residency Years: ");

            Citizen citizen = new Citizen(name, age, income, residency);
            service.AddCitizen(citizen);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
