using System;

public class Menu
{
    private ICitizenService service = new CitizenService();

    public void Start()
    {
        int choice;

        do
        {
            Console.WriteLine("\n========= TechVille Registration System =========");
            Console.WriteLine("1. Register Citizens");
            Console.WriteLine("2. View Citizens");
            Console.WriteLine("3. Sort Citizen IDs");
            Console.WriteLine("4. Search by ID");
            Console.WriteLine("5. Search by Name");
            Console.WriteLine("6. Update Income");
            Console.WriteLine("7. Update Address");
            Console.WriteLine("8. Generate Random Profile");
            Console.WriteLine("9. View Services");
            Console.WriteLine("10. Subscribe to Service");
            Console.WriteLine("11. View Citizen Services");
            Console.WriteLine("12. Exit");
            Console.WriteLine("=================================================");

            choice = InputUtility.GetInt("Enter your choice: ");

            switch (choice)
            {
                case 1:
                    int count = InputUtility.GetInt("How many citizens to register? ");
                    service.RegisterFamily(count);
                    break;

                case 2:
                    service.ViewCitizens();
                    break;

                case 3:
                    service.SortCitizenIds();
                    break;

                case 4:
                    int id = InputUtility.GetInt("Enter Citizen ID: ");
                    service.SearchCitizenById(id);
                    break;

                case 5:
                    string name = InputUtility.GetString("Enter name to search: ");
                    service.SearchByName(name);
                    break;

                case 6:
                    int id1 = InputUtility.GetInt("Enter Citizen ID: ");
                    double income = InputUtility.GetDouble("Enter new income: ");
                    service.UpdateIncomeByValue(id1, income);
                    break;

                case 7:
                    int id2 = InputUtility.GetInt("Enter Citizen ID: ");
                    string address = InputUtility.GetString("Enter new address: ");
                    service.UpdateAddressByReference(id2, ref address);
                    break;

                case 8:
                    Citizen generated = service.GenerateProfile();
                    Console.WriteLine("Generated Profile:");
                    generated.Display();
                    break;
                case 9:
                    service.ViewAvailableServices();
                    break;
                case 10:
                    service.SubscribeToService();
                    break;
                case 11:
                    service.ViewCitizenServices();
                    break;
                case 12:
                    Console.WriteLine("Thank you for using TechVille System.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 12);
    }
}
