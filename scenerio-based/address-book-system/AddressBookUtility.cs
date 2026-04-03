using System;
using System.Collections.Generic;
using System.IO;

class AddressBookUtility : IAddressBook
{
    private List<ContactPerson> contacts = new List<ContactPerson>();
    private string bookName;

    public AddressBookUtility(string name)
    {
        bookName = name;
    }

    public List<ContactPerson> GetContacts()
    {
        return contacts;
    }

    public void SetContacts(List<ContactPerson> list)
    {
        contacts = list ?? new List<ContactPerson>();
    }

    private string GetInput(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "";
    }

    public void AddContact()
    {
        try
        {
            string first = GetInput("First Name: ");

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.Equals(first, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact already exists.");
                    return;
                }
            }

            ContactPerson person = new ContactPerson();
            person.FirstName = first;
            person.LastName = GetInput("Last Name: ");
            person.Address = GetInput("Address: ");
            person.City = GetInput("City: ");
            person.State = GetInput("State: ");
            person.Zip = GetInput("Zip: ");
            person.PhoneNumber = GetInput("Phone: ");
            person.Email = GetInput("Email: ");

            contacts.Add(person);
            Console.WriteLine("Contact Added.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error adding contact: " + ex.Message);
        }
    }

    public void EditContact()
    {
        string name = GetInput("Enter First Name to Edit: ");

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                contacts[i].LastName = GetInput("New Last Name: ");
                contacts[i].Address = GetInput("New Address: ");
                contacts[i].City = GetInput("New City: ");
                contacts[i].State = GetInput("New State: ");
                contacts[i].Zip = GetInput("New Zip: ");
                contacts[i].PhoneNumber = GetInput("New Phone: ");
                contacts[i].Email = GetInput("New Email: ");
                Console.WriteLine("Contact Updated.");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void DeleteContact()
    {
        string name = GetInput("Enter First Name to Delete: ");

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                contacts.RemoveAt(i);
                Console.WriteLine("Contact Deleted.");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
            return;
        }

        for (int i = 0; i < contacts.Count; i++)
        {
            Console.WriteLine(contacts[i]);
        }
    }

    public void SearchByCity(string city)
    {
        bool found = false;

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].City.Equals(city, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(contacts[i]);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No contacts found in this city.");
    }

    public void SearchByState(string state)
    {
        bool found = false;

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].State.Equals(state, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(contacts[i]);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No contacts found in this state.");
    }

    public int CountByCity(string city)
    {
        int count = 0;

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].City.Equals(city, StringComparison.OrdinalIgnoreCase))
                count++;
        }

        return count;
    }

    public int CountByState(string state)
    {
        int count = 0;

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].State.Equals(state, StringComparison.OrdinalIgnoreCase))
                count++;
        }

        return count;
    }

    public void SortContactsByName()
    {
        for (int i = 0; i < contacts.Count - 1; i++)
        {
            for (int j = 0; j < contacts.Count - i - 1; j++)
            {
                if (string.Compare(contacts[j].FirstName, contacts[j + 1].FirstName, true) > 0)
                {
                    ContactPerson temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Contacts Sorted.");
    }

    public void ExportToCsv()
    {
        try
        {
            string fileName = bookName + ".csv";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("FirstName,LastName,Address,City,State,Zip,Phone,Email");

                for (int i = 0; i < contacts.Count; i++)
                {
                    ContactPerson c = contacts[i];

                    writer.WriteLine(
                        c.FirstName
                            + ","
                            + c.LastName
                            + ","
                            + c.Address
                            + ","
                            + c.City
                            + ","
                            + c.State
                            + ","
                            + c.Zip
                            + ","
                            + c.PhoneNumber
                            + ","
                            + c.Email
                    );
                }
            }

            Console.WriteLine("Exported to CSV successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("CSV Export Error: " + ex.Message);
        }
    }

    public void ImportFromCsv()
    {
        try
        {
            string fileName = GetInput("Enter CSV file name: ");

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(fileName);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                if (parts.Length == 8)
                {
                    ContactPerson person = new ContactPerson();
                    person.FirstName = parts[0];
                    person.LastName = parts[1];
                    person.Address = parts[2];
                    person.City = parts[3];
                    person.State = parts[4];
                    person.Zip = parts[5];
                    person.PhoneNumber = parts[6];
                    person.Email = parts[7];

                    contacts.Add(person);
                }
            }

            Console.WriteLine("CSV Imported Successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("CSV Import Error: " + ex.Message);
        }
    }
}
