public class HealthcareService : Service
{
    public HealthcareService(double cost)
        : base("Healthcare Service", cost) { }
}
