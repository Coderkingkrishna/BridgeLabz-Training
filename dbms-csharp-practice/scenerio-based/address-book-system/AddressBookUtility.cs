using System;
using System.Collections.Generic;

class AddressBookUtility : IAddressBook
{
    private List<ContactPerson> contacts = new List<ContactPerson>();
    private string bookName;

    public AddressBookUtility(string name)
    {
        bookName = name;
    }

    public List<ContactPerson> GetContacts() => contacts;

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
            ContactPerson person = new ContactPerson
            {
                FirstName = GetInput("First Name: "),
                LastName = GetInput("Last Name: "),
                Address = GetInput("Address: "),
                City = GetInput("City: "),
                State = GetInput("State: "),
                Zip = GetInput("Zip: "),
                PhoneNumber = GetInput("Phone: "),
                Email = GetInput("Email: "),
            };

            if (!ValidationHelper.Validate(person))
                return;

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

        var person = contacts.Find(x =>
            x.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase)
        );

        if (person == null)
        {
            Console.WriteLine("Contact not found.");
            return;
        }

        person.City = GetInput("New City: ");
        person.State = GetInput("New State: ");

        Console.WriteLine("Contact Updated.");
    }

    public void DeleteContact()
    {
        string name = GetInput("Enter First Name to Delete: ");

        contacts.RemoveAll(x => x.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Contact Deleted.");
    }

    public void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
            return;
        }

        foreach (var c in contacts)
            Console.WriteLine(c);
    }

    public void SearchByCity(string city)
    {
        foreach (var c in contacts)
            if (c.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(c);
    }

    public void SearchByState(string state)
    {
        foreach (var c in contacts)
            if (c.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(c);
    }

    public int CountByCity(string city)
    {
        return contacts.Count(x => x.City.Equals(city, StringComparison.OrdinalIgnoreCase));
    }

    public int CountByState(string state)
    {
        return contacts.Count(x => x.State.Equals(state, StringComparison.OrdinalIgnoreCase));
    }

    public void SortContactsByName()
    {
        contacts.Sort((a, b) => string.Compare(a.FirstName, b.FirstName, true));
        Console.WriteLine("Contacts Sorted.");
    }

    public void ExportToCsv()
    {
        try
        {
            using StreamWriter writer = new StreamWriter(bookName + ".csv");

            writer.WriteLine("FirstName,LastName,City,State,Phone,Email");

            foreach (var c in contacts)
                writer.WriteLine(
                    $"{c.FirstName},{c.LastName},{c.City},{c.State},{c.PhoneNumber},{c.Email}"
                );

            Console.WriteLine("Exported successfully.");
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

            if (!System.IO.File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            var lines = System.IO.File.ReadAllLines(fileName);

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');

                if (parts.Length >= 6)
                {
                    contacts.Add(
                        new ContactPerson
                        {
                            FirstName = parts[0],
                            LastName = parts[1],
                            City = parts[2],
                            State = parts[3],
                            PhoneNumber = parts[4],
                            Email = parts[5],
                        }
                    );
                }
            }

            Console.WriteLine("Imported Successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("CSV Import Error: " + ex.Message);
        }
    }
}
