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
        int choice;

        do
        {
            Console.WriteLine("\n===== TechVille Service System =====");
            Console.WriteLine("1. Register Family Members");
            Console.WriteLine("2. View All Citizens");
            Console.WriteLine("3. Exit");

            choice = InputUtility.GetInt("Enter choice: ");

            switch (choice)
            {
                case 1:
                    int count = InputUtility.GetInt("How many members? ");
                    service.RegisterFamily(count);
                    break;

                case 2:
                    service.ViewCitizens();
                    break;

                case 3:
                    Console.WriteLine("Exiting system...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 3);
    }
}
