using System;

class AddressBookMain
{
    static void Main(string[] args)
    {
        try
        {
            AddressBookMenu menu = new AddressBookMenu();
            menu.Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
