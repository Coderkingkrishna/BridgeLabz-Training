using System;

public class Service
{
    private static int counter = 1;
    public static int TotalServices { get; private set; }

    public int ServiceId { get; private set; }
    public string ServiceName { get; protected set; }
    public double BaseCost { get; protected set; }

    public Service(string name, double cost)
    {
        ServiceId = counter++;
        TotalServices++;
        this.ServiceName = name;
        this.BaseCost = cost;
    }

    public virtual void Display()
    {
        Console.WriteLine("Service ID: " + ServiceId);
        Console.WriteLine("Service Name: " + ServiceName);
        Console.WriteLine("Base Cost: ₹" + BaseCost);
    }
}
