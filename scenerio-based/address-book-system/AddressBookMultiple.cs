using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class AddressBookMultiple
{
    private Dictionary<string, AddressBookUtility> books = new Dictionary<
        string,
        AddressBookUtility
    >(StringComparer.OrdinalIgnoreCase);

    private const string filePath = "addressbook.json";

    public AddressBookMultiple()
    {
        LoadFromFile();
    }

    public void AddAddressBook()
    {
        string name = Console.ReadLine() ?? "";

        if (books.ContainsKey(name))
        {
            Console.WriteLine("Address Book already exists.");
            return;
        }

        books[name] = new AddressBookUtility(name);
        SaveToFile();
        Console.WriteLine("Address Book Added.");
    }

    public IAddressBook SelectAddressBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No Address Books available.");
            return null;
        }

        List<string> keys = new List<string>(books.Keys);

        for (int i = 0; i < keys.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + keys[i]);
        }

        Console.Write("Select number: ");
        int choice;
        int.TryParse(Console.ReadLine(), out choice);

        if (choice < 1 || choice > keys.Count)
        {
            Console.WriteLine("Invalid choice.");
            return null;
        }

        return books[keys[choice - 1]];
    }

    public void SearchPersonByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine() ?? "";

        foreach (var entry in books)
        {
            Console.WriteLine("\nAddress Book: " + entry.Key);
            entry.Value.SearchByCity(city);
        }
    }

    public void SearchPersonByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine() ?? "";

        foreach (var entry in books)
        {
            Console.WriteLine("\nAddress Book: " + entry.Key);
            entry.Value.SearchByState(state);
        }
    }

    public void ViewPersonCountByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine() ?? "";

        int total = 0;

        foreach (var entry in books)
        {
            total += entry.Value.CountByCity(city);
        }

        Console.WriteLine("Total persons in city " + city + " = " + total);
    }

    public void ViewPersonCountByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine() ?? "";

        int total = 0;

        foreach (var entry in books)
        {
            total += entry.Value.CountByState(state);
        }

        Console.WriteLine("Total persons in state " + state + " = " + total);
    }

    public void SaveToFile()
    {
        try
        {
            AddressBookData data = new AddressBookData();

            foreach (var entry in books)
            {
                data.Books[entry.Key] = entry.Value.GetContacts();
            }

            string json = JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving file: " + ex.Message);
        }
    }

    private void LoadFromFile()
    {
        try
        {
            if (!File.Exists(filePath))
                return;

            string json = File.ReadAllText(filePath);

            AddressBookData data = JsonSerializer.Deserialize<AddressBookData>(json);

            if (data == null)
                return;

            foreach (var entry in data.Books)
            {
                AddressBookUtility book = new AddressBookUtility(entry.Key);

                book.SetContacts(entry.Value);
                books[entry.Key] = book;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading file: " + ex.Message);
        }
    }
}
