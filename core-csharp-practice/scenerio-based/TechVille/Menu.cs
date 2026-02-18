using System;

public class Menu
{
    private ICitizenService service = new CitizenService();

    public void Start()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== TechVille Service System =====");
            Console.WriteLine("1. Register Family");
            Console.WriteLine("2. View Citizens");
            Console.WriteLine("3. Sort Citizen IDs");
            Console.WriteLine("4. Search by ID");
            Console.WriteLine("5. Search by Name");
            Console.WriteLine("6. Update Income");
            Console.WriteLine("7. Update Address");
            Console.WriteLine("8. Generate Profile");
            Console.WriteLine("9. Exit");

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
                    service.SortCitizenIds();
                    break;

                case 4:
                    int id = InputUtility.GetInt("Enter ID: ");
                    service.SearchCitizenById(id);
                    break;

                case 5:
                    string name = InputUtility.GetString("Enter name: ");
                    service.SearchByName(name);
                    break;

                case 6:
                    int id1 = InputUtility.GetInt("Enter ID: ");
                    double income = InputUtility.GetDouble("Enter new income: ");
                    service.UpdateIncomeByValue(id1, income);
                    break;

                case 7:
                    int id2 = InputUtility.GetInt("Enter ID: ");
                    string address = InputUtility.GetString("Enter new address: ");
                    service.UpdateAddressByReference(id2, ref address);
                    break;

                case 8:
                    Citizen c = service.GenerateProfile();
                    c.Display();
                    break;

                case 9:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 9);
    }
}
