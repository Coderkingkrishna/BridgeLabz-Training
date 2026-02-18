public interface ICitizenService
{
    void RegisterFamily(int count);
    void ViewCitizens();
    void SortCitizenIds();
    void SearchCitizenById(int id);
    void SearchByName(string name);
    void UpdateIncomeByValue(int id, double newIncome);
    void UpdateAddressByReference(int id, ref string newAddress);
    void ViewAvailableServices();
    void SubscribeToService();
    void ViewCitizenServices();
    Citizen GenerateProfile();
}
