using System;
using System.IO;
using System.Text.Json;

public class JsonStorageProvider : IStorageProvider
{
    private const string filePath = "addressbook.json";

    public void Save(AddressBookData data)
    {
        try
        {
            string json = JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(filePath, json);
            Console.WriteLine("data added in json");
        }
        catch (Exception ex)
        {
            Console.WriteLine("JSON Save Error: " + ex.Message);
        }
    }

    public AddressBookData Load()
    {
        try
        {
            if (!File.Exists(filePath))
                return new AddressBookData();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<AddressBookData>(json) ?? new AddressBookData();
        }
        catch (Exception ex)
        {
            Console.WriteLine("JSON Load Error: " + ex.Message);
            return new AddressBookData();
        }
    }
}
