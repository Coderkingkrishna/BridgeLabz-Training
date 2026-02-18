public interface ICitizenService
{
    void AddCitizen(Citizen citizen);
    void ViewCitizens();
    double CalculateEligibility(Citizen citizen);
}
