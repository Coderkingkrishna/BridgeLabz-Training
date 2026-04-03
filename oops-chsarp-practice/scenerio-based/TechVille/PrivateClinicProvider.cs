using System.Collections.Generic;

public class PrivateClinicProvider : IExternalServiceProvider
{
    public string ProviderName => "WellCare Clinics";

    public IEnumerable<Service> GetServices()
    {
        return new List<Service>
        {
            new RoutineService("WellCare Clinic Visit", 650),
            new PremiumService("WellCare Clinic Visit", 650, 180, "Priority consultation")
        };
    }
}
