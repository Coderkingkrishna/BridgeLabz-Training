using System;

class AddressBookMenu
{
    IAddressBook service;

    public void Run()
    {
        service = new AddressBookUtility();
        int choice;
        do
        {
            Console.WriteLine("Welcome to Address Book System");
            Console.WriteLine("1. Adding a new contact"); // can save multiple contacts
            Console.WriteLine("2. Editing an existing contact");
            Console.WriteLine("3. Deleting a contact");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
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
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        } while (choice != 0);
    }
}
