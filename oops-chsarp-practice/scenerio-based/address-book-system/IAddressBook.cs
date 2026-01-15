interface IAddressBook
{
    void AddContact();
    void EditContact();
    void DeleteContact();
    void DisplayContacts();
    void SearchByCity(string city);
    void SearchByState(string state);
    int CountByCity(string city);
    int CountByState(string state);
}
