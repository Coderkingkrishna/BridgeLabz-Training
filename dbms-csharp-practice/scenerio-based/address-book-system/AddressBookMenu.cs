using System;

class AddressBookMenu
{
    AddressBookMultiple system;

    public AddressBookMenu(IStorageProvider provider)
    {
        system = new AddressBookMultiple(provider);
    }

    public void Run()
    {
        int choice;
        do
        {
            Console.WriteLine("\n===== ADDRESS BOOK SYSTEM =====");
            Console.WriteLine("1. Add Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("3. Search Person by City");
            Console.WriteLine("4. Search Person by State");
            Console.WriteLine("5. View Person Count by City");
            Console.WriteLine("6. View Person Count by State");
            Console.WriteLine("0. Exit");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    system.AddAddressBook();
                    break;
                case 2:
                    var book = system.SelectAddressBook();
                    if (book != null)
                        AddressBookOperations(book);
                    break;
                case 3:
                    system.SearchPersonByCity();
                    break;
                case 4:
                    system.SearchPersonByState();
                    break;
                case 5:
                    system.ViewPersonCountByCity();
                    break;
                case 6:
                    system.ViewPersonCountByState();
                    break;
            }
        } while (choice != 0);
    }

    public void AddressBookOperations(IAddressBook service)
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Address Book Menu ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display Contacts");
            Console.WriteLine("5. Sort Contacts By Name");
            Console.WriteLine("6. Export To CSV");
            Console.WriteLine("7. Import From CSV");
            Console.WriteLine("0. Back");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    service.AddContact();
                    system.SaveChanges();
                    break;
                case 2:
                    service.EditContact();
                    system.SaveChanges();
                    break;
                case 3:
                    service.DeleteContact();
                    system.SaveChanges();
                    break;
                case 4:
                    service.DisplayContacts();
                    break;
                case 5:
                    service.SortContactsByName();
                    break;
                case 6:
                    service.ExportToCsv();
                    break;
                case 7:
                    service.ImportFromCsv();
                    break;
            }
        } while (choice != 0);
    }
}
