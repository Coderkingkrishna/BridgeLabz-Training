using System;

public abstract class Service : IBookable, ICancellable, ITrackable
{
    private static int counter = 1;
    public static int TotalServices { get; private set; }

    public int ServiceId { get; private set; }
    public string ServiceName { get; protected set; }
    public double BaseCost { get; protected set; }

    protected bool isRegistered;
    protected string status;
    protected string lastRegisteredBy;

    public Service(string name, double cost)
    {
        ServiceId = counter++;
        TotalServices++;
        this.ServiceName = name;
        this.BaseCost = cost;
        isRegistered = false;
        status = "Not Registered";
        lastRegisteredBy = "N/A";
    }

    public virtual void Register(int citizenId)
    {
        isRegistered = true;
        status = "Registered";
        lastRegisteredBy = "Citizen ID: " + citizenId;
        Console.WriteLine(ServiceName + " registered for citizen ID " + citizenId + ".");
    }

    public virtual void Register(string citizenName)
    {
        isRegistered = true;
        status = "Registered";
        lastRegisteredBy = "Citizen Name: " + citizenName;
        Console.WriteLine(ServiceName + " registered for citizen " + citizenName + ".");
    }

    public virtual void Register(Citizen citizen)
    {
        if (citizen == null)
        {
            Console.WriteLine("Citizen not found.");
            return;
        }

        Register(citizen.CitizenId);
    }

    public virtual void Cancel()
    {
        if (!isRegistered)
        {
            Console.WriteLine(ServiceName + " is not registered yet.");
            return;
        }

        isRegistered = false;
        status = "Cancelled";
        Console.WriteLine(ServiceName + " registration cancelled.");
    }

    public virtual void CheckStatus()
    {
        Console.WriteLine("Status: " + status + " | " + lastRegisteredBy);
    }

    public abstract string GetServiceType();

    public virtual void Display()
    {
        Console.WriteLine("Service ID: " + ServiceId);
        Console.WriteLine("Service Name: " + ServiceName);
        Console.WriteLine("Base Cost: ₹" + BaseCost);
    }

    public override string ToString()
    {
        return ServiceName + " (#" + ServiceId + ")";
    }

    public override bool Equals(object obj)
    {
        if (obj is Service other)
            return ServiceId == other.ServiceId && ServiceName == other.ServiceName;

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ServiceId, ServiceName);
    }
}
