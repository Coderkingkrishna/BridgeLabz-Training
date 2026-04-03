using System.Collections.Generic;

public interface IStorageProvider
{
    void Save(AddressBookData data);
    AddressBookData Load();
}
