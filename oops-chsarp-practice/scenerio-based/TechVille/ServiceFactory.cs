public static class ServiceFactory
{
    public static Service CreateStandard(ServiceKind kind)
    {
        switch (kind)
        {
            case ServiceKind.Healthcare:
                return new HealthcareService(500);
            case ServiceKind.Education:
                return new EducationService(400);
            case ServiceKind.Transportation:
                return new TransportationService(300);
            case ServiceKind.Utility:
                return new UtilityService(250);
            case ServiceKind.Emergency:
                return new EmergencyService("Emergency Response Service", 800);
            default:
                return new RoutineService("General Service", 200);
        }
    }

    public static Service CreatePremium(ServiceKind kind)
    {
        switch (kind)
        {
            case ServiceKind.Healthcare:
                return new PremiumService("Healthcare Service", 500, 200, "Priority appointments, home visits");
            case ServiceKind.Education:
                return new PremiumService("Education Service", 400, 150, "Scholarship access, mentor support");
            case ServiceKind.Transportation:
                return new PremiumService("Transportation Service", 300, 120, "Express routes, priority seats");
            case ServiceKind.Utility:
                return new PremiumService("Utility Service", 250, 100, "24x7 support, outage alerts");
            case ServiceKind.Emergency:
                return new PremiumService("Emergency Response Service", 800, 300, "Fast dispatch, critical support");
            default:
                return new PremiumService("General Service", 200, 80, "Extended support");
        }
    }
}

public enum ServiceKind
{
    Healthcare,
    Education,
    Transportation,
    Utility,
    Emergency
}
