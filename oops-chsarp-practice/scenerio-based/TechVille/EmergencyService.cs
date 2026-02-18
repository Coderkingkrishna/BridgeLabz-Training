using System;

public class EmergencyService : Service
{
    public EmergencyService(string name, double cost)
        : base(name, cost) { }

    public override void Register(int citizenId)
    {
        base.Register(citizenId);
        status = "Emergency Active";
        Console.WriteLine("Emergency priority activated.");
    }

    public override void Register(string citizenName)
    {
        base.Register(citizenName);
        status = "Emergency Active";
        Console.WriteLine("Emergency priority activated.");
    }

    public override void Register(Citizen citizen)
    {
        base.Register(citizen);
        if (citizen != null)
        {
            status = "Emergency Active";
            Console.WriteLine("Emergency priority activated.");
        }
    }

    public override void Cancel()
    {
        base.Cancel();
        if (!isRegistered)
            status = "Emergency Cancelled";
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Type: Emergency Service");
    }
}
