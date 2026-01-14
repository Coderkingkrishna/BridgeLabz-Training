class AddressBookMultiple
{
    private Dictionary<string, AddressBookUtility> addressBooks =
        new Dictionary<string, AddressBookUtility>();

    public void AddAddressBook(string name)
    {
        if (!addressBooks.ContainsKey(name))
            addressBooks[name] = new AddressBookUtility();
        Console.WriteLine("Address book " + name + " added.");
    }

    public AddressBookUtility GetAddressBook(string name)
    {
        if (addressBooks.ContainsKey(name))
            return addressBooks[name];
        else
            return null;
    }
}
