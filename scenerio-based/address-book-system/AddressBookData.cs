using System.Collections.Generic;

class AddressBookData
{
    public Dictionary<string, List<ContactPerson>> Books { get; set; } =
        new Dictionary<string, List<ContactPerson>>();
}
