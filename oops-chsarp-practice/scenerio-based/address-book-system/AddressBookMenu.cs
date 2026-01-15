using System;

class AddressBookMenu
{
    AddressBookMultiple system = new AddressBookMultiple();

    public void Run()
    {
        int choice;
        do
        {
            Console.WriteLine("\n===== ADDRESS BOOK SYSTEM =====");
            Console.WriteLine("1. Add Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    system.AddAddressBook();
                    break;

                case 2:
                    IAddressBook book = system.SelectAddressBook();
                    if (book != null)
                        AddressBookOperations(book);
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 0);
    }

    private void AddressBookOperations(IAddressBook service)
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Address Book Menu ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display Contacts");
            Console.WriteLine("0. Back");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddContact();
                    break;
                case 2:
                    service.EditContact();
                    break;
                case 3:
                    service.DeleteContact();
                    break;
                case 4:
                    service.DisplayContacts();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 0);
    }
}
