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
}
