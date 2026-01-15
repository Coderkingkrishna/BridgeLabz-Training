using System;

class AddressBookMultiple
{
    private string[] names = new string[10];
    private AddressBookUtility[] books = new AddressBookUtility[10];
    private int count = 0;

    public void AddAddressBook()
    {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (names[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Address Book already exists.");
                return;
            }
        }

        names[count] = name;
        books[count] = new AddressBookUtility(name);
        count++;

        Console.WriteLine("Address Book added successfully.");
    }

    public IAddressBook SelectAddressBook()
    {
        if (count == 0)
        {
            Console.WriteLine("No Address Books available.");
            return null;
        }

        Console.WriteLine("\nAvailable Address Books:");
        for (int i = 0; i < count; i++)
            Console.WriteLine((i + 1) + ". " + names[i]);

        Console.Write("Select number: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > count)
        {
            Console.WriteLine("Invalid selection.");
            return null;
        }

        return books[choice - 1]; // RETURNING INTERFACE
    }

    // ================= UC-8 =================
    public void SearchPersonByCity()
    {
        if (count == 0)
        {
            Console.WriteLine("No Address Books available.");
            return;
        }

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nAddress Book: " + names[i]);
            books[i].SearchByCity(city);
        }
    }

    public void SearchPersonByState()
    {
        if (count == 0)
        {
            Console.WriteLine("No Address Books available.");
            return;
        }

        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nAddress Book: " + names[i]);
            books[i].SearchByState(state);
        }
    }

    public void ViewPersonCountByCity()
    {
        if (count == 0)
        {
            Console.WriteLine("No Address Books available.");
            return;
        }

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        int totalCount = 0;

        for (int i = 0; i < count; i++)
        {
            int result = books[i].CountByCity(city);
            totalCount += result;
        }

        Console.WriteLine("Total persons in city " + city + " = " + totalCount);
    }

    public void ViewPersonCountByState()
    {
        if (count == 0)
        {
            Console.WriteLine("No Address Books available.");
            return;
        }

        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        int totalCount = 0;

        for (int i = 0; i < count; i++)
        {
            int result = books[i].CountByState(state);
            totalCount += result;
        }

        Console.WriteLine("Total persons in state " + state + " = " + totalCount);
    }
}
