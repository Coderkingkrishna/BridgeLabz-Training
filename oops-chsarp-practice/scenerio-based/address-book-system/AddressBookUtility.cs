using System;

class AddressBookUtility : IAddressBook
{
    private ContactPerson[] contacts = new ContactPerson[100];
    private int count = 0;
    private string bookName;

    public AddressBookUtility(string name)
    {
        bookName = name;
    }

    public void AddContact()
    {
        if (count >= contacts.Length)
        {
            Console.WriteLine("Address Book is full.");
            return;
        }

        Console.WriteLine("\nAdding contact to [" + bookName + "]:");

        string firstName = GetNonEmpty("First Name");
        string lastName = GetNonEmpty("Last Name");

        if (IsDuplicate(firstName, lastName))
        {
            Console.WriteLine("Duplicate contact found. Cannot add.");
            return;
        }

        string address = GetNonEmpty("Address");
        string city = GetNonEmpty("City");
        string state = GetNonEmpty("State");
        string zip = GetValidZip();
        string phone = GetValidPhone();
        string email = GetValidEmail();

        contacts[count++] = new ContactPerson(
            firstName,
            lastName,
            address,
            city,
            state,
            zip,
            phone,
            email
        );

        Console.WriteLine("Contact added successfully.");
    }

    public void EditContact()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (
                contacts[i].firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)
                && contacts[i].lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)
            )
            {
                Console.WriteLine("1.Address 2.City 3.State 4.Zip 5.Phone 6.Email 7.All");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        contacts[i].address = GetNonEmpty("Address");
                        break;
                    case 2:
                        contacts[i].city = GetNonEmpty("City");
                        break;
                    case 3:
                        contacts[i].state = GetNonEmpty("State");
                        break;
                    case 4:
                        contacts[i].zip = GetValidZip();
                        break;
                    case 5:
                        contacts[i].phoneNumber = GetValidPhone();
                        break;
                    case 6:
                        contacts[i].email = GetValidEmail();
                        break;
                    case 7:
                        contacts[i].address = GetNonEmpty("Address");
                        contacts[i].city = GetNonEmpty("City");
                        contacts[i].state = GetNonEmpty("State");
                        contacts[i].zip = GetValidZip();
                        contacts[i].phoneNumber = GetValidPhone();
                        contacts[i].email = GetValidEmail();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                Console.WriteLine("Contact updated successfully.");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void DeleteContact()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (
                contacts[i].firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)
                && contacts[i].lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)
            )
            {
                Console.Write("Are you sure? (Y/N): ");
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    Console.WriteLine("Delete cancelled.");
                    return;
                }

                for (int j = i; j < count - 1; j++)
                    contacts[j] = contacts[j + 1];

                contacts[--count] = null;
                Console.WriteLine("Contact deleted.");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void DisplayContacts()
    {
        Console.WriteLine("\nContacts in [" + bookName + "]:");

        if (count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        for (int i = 0; i < count; i++)
            Console.WriteLine(contacts[i]);
    }

    private bool IsDuplicate(string f, string l)
    {
        for (int i = 0; i < count; i++)
        {
            if (
                contacts[i].firstName.Equals(f, StringComparison.OrdinalIgnoreCase)
                && contacts[i].lastName.Equals(l, StringComparison.OrdinalIgnoreCase)
            )
                return true;
        }
        return false;
    }

    private string GetNonEmpty(string field)
    {
        string input;
        do
        {
            Console.Write("Enter " + field + ": ");
            input = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(input));

        return input;
    }

    private string GetValidPhone()
    {
        string phone;
        long temp;

        do
        {
            Console.Write("Enter 10-digit Phone Number: ");
            phone = Console.ReadLine();
        } while (phone.Length != 10 || !long.TryParse(phone, out temp));

        return phone;
    }

    private string GetValidEmail()
    {
        string email;
        do
        {
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
        } while (!email.Contains("@") || !email.Contains(".") || email.Contains(" "));

        return email;
    }

    private string GetValidZip()
    {
        string zip;
        int temp;

        do
        {
            Console.Write("Enter Zip: ");
            zip = Console.ReadLine();
        } while (!int.TryParse(zip, out temp));

        return zip;
    }

    // ================= UC-8 =================
    public void SearchByCity(string city)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].city.Equals(city, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(contacts[i]);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No contacts found in city: " + city);
    }

    public void SearchByState(string state)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].state.Equals(state, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(contacts[i]);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No contacts found in state: " + state);
    }

    public int CountByCity(string city)
    {
        int countCity = 0;

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].city.Equals(city, StringComparison.OrdinalIgnoreCase))
            {
                countCity++;
            }
        }
        return countCity;
    }

    public int CountByState(string state)
    {
        int countState = 0;

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].state.Equals(state, StringComparison.OrdinalIgnoreCase))
            {
                countState++;
            }
        }
        return countState;
    }

    public void SortContactsByName()
    {
        if (count < 2)
        {
            Console.WriteLine("Not enough contacts to sort.");
            return;
        }

        // Bubble Sort by First Name (UC-10)
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (
                    string.Compare(
                        contacts[j].firstName,
                        contacts[j + 1].firstName,
                        StringComparison.OrdinalIgnoreCase
                    ) > 0
                )
                {
                    ContactPerson temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Contacts in [" + bookName + "] sorted by name.");
        DisplayContacts();
    }
}
