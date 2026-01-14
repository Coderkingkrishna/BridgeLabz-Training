using System;

class AddressBookUtility : IAddressBook
{
    private ContactPerson[] contacts = new ContactPerson[100];
    private int count = 0;

    public void AddContact()
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter Address:");
        string address = Console.ReadLine();
        Console.WriteLine("Enter City:");
        string city = Console.ReadLine();
        Console.WriteLine("Enter State:");
        string state = Console.ReadLine();
        Console.WriteLine("Enter Zip:");
        string zip = Console.ReadLine();
        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine();
        contacts[count] = new ContactPerson(
            firstName,
            lastName,
            address,
            city,
            state,
            zip,
            phoneNumber,
            email
        );
        count++;
        Console.WriteLine("Contact added.");
    }

    public void EditContact()
    {
        Console.WriteLine("Enter First Name of the contact to edit:");
        string firstName = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                Console.WriteLine(
                    "what do you want to edit? (1. Address 2. City 3. State 4. Zip 5. Phone Number 6. Email 7. All details)"
                );
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new Address:");
                        contacts[i].address = Console.ReadLine();
                        Console.WriteLine("Address updated.");
                        break;
                    case 2:
                        Console.WriteLine("Enter new City:");
                        contacts[i].city = Console.ReadLine();
                        Console.WriteLine("City updated.");
                        break;
                    case 3:
                        Console.WriteLine("Enter new State:");
                        contacts[i].state = Console.ReadLine();
                        Console.WriteLine("State updated.");
                        break;
                    case 4:
                        Console.WriteLine("Enter new Zip:");
                        contacts[i].zip = Console.ReadLine();
                        Console.WriteLine("Zip updated.");
                        break;
                    case 5:
                        Console.WriteLine("Enter new Phone Number:");
                        contacts[i].phoneNumber = Console.ReadLine();
                        Console.WriteLine("Phone Number updated.");
                        break;
                    case 6:
                        Console.WriteLine("Enter new Email:");
                        contacts[i].email = Console.ReadLine();
                        Console.WriteLine("Email updated.");
                        break;
                    case 7:
                        Console.WriteLine("Enter new Address:");
                        contacts[i].address = Console.ReadLine();
                        Console.WriteLine("Enter new City:");
                        contacts[i].city = Console.ReadLine();
                        Console.WriteLine("Enter new State:");
                        contacts[i].state = Console.ReadLine();
                        Console.WriteLine("Enter new Zip:");
                        contacts[i].zip = Console.ReadLine();
                        Console.WriteLine("Enter new Phone Number:");
                        contacts[i].phoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter new Email:");
                        contacts[i].email = Console.ReadLine();
                        Console.WriteLine("All details updated.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
