using System;

public class RoutineService : Service
{
    public RoutineService(string name, double cost)
        : base(name, cost) { }

    public override void Register(int citizenId)
    {
        base.Register(citizenId);
        Console.WriteLine("Standard processing started.");
    }

    public override void Register(string citizenName)
    {
        base.Register(citizenName);
        Console.WriteLine("Standard processing started.");
    }

    public override void Register(Citizen citizen)
    {
        base.Register(citizen);
        if (citizen != null)
            Console.WriteLine("Standard processing started.");
    }
}
