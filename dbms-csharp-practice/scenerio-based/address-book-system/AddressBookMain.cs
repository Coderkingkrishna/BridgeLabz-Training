class AddressBookMain
{
    static void Main(string[] args)
    {
        try
        {
            // IStorageProvider provider = new JsonStorageProvider();
            IStorageProvider provider = new SqlStorageProvider();

            AddressBookMenu menu = new AddressBookMenu(provider);
            menu.Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
