using System;

public class Service
{
    private static int counter = 1;

    public int ServiceId { get; private set; }
    public string ServiceName { get; protected set; }
    public double BaseCost { get; protected set; }

    public Service(string name, double cost)
    {
        ServiceId = counter++;
        ServiceName = name;
        BaseCost = cost;
    }

    public virtual void Display()
    {
        Console.WriteLine("Service ID: " + ServiceId);
        Console.WriteLine("Service Name: " + ServiceName);
        Console.WriteLine("Base Cost: ₹" + BaseCost);
    }
}
