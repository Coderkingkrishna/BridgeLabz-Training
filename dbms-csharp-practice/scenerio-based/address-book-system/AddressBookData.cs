using System.Collections.Generic;

public class AddressBookData
{
    public Dictionary<string, List<ContactPerson>> Books { get; set; } =
        new Dictionary<string, List<ContactPerson>>();
}
