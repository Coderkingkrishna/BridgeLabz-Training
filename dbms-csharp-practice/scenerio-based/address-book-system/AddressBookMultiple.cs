using System;
using System.Collections.Generic;

class AddressBookMultiple
{
    private Dictionary<string, AddressBookUtility> books = new Dictionary<
        string,
        AddressBookUtility
    >(StringComparer.OrdinalIgnoreCase);

    private IStorageProvider storage;

    public AddressBookMultiple(IStorageProvider provider)
    {
        storage = provider;
        LoadFromStorage();
    }

    private void LoadFromStorage()
    {
        AddressBookData data = storage.Load();

        foreach (var entry in data.Books)
        {
            AddressBookUtility book = new AddressBookUtility(entry.Key);
            book.SetContacts(entry.Value);
            books[entry.Key] = book;
        }
    }

    public void SaveToStorage()
    {
        AddressBookData data = new AddressBookData();

        foreach (var entry in books)
            data.Books[entry.Key] = entry.Value.GetContacts();

        storage.Save(data);
    }

    public void SaveChanges()
    {
        SaveToStorage();
    }

    public void AddAddressBook()
    {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine() ?? "";

        if (!books.ContainsKey(name))
        {
            books[name] = new AddressBookUtility(name);
            SaveToStorage();
            Console.WriteLine("Address Book Added.");
        }
    }

    public IAddressBook SelectAddressBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No Address Books available.");
            return null;
        }

        int i = 1;
        foreach (var key in books.Keys)
            Console.WriteLine($"{i++}. {key}");

        Console.Write("Select number: ");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= books.Count)
        {
            return new List<AddressBookUtility>(books.Values)[choice - 1];
        }

        Console.WriteLine("Invalid choice.");
        return null;
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
            total += entry.Value.CountByCity(city);

        Console.WriteLine($"Total persons in city {city} = {total}");
    }

    public void ViewPersonCountByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine() ?? "";

        int total = 0;
        foreach (var entry in books)
            total += entry.Value.CountByState(state);

        Console.WriteLine($"Total persons in state {state} = {total}");
    }
}
