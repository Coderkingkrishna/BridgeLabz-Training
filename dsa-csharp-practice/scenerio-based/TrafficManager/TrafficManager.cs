using System;

class TrafficManager
{
    private Roundabout roundabout;
    private VehicleQueue queue;

    public TrafficManager(int queueCapacity)
    {
        roundabout = new Roundabout();
        queue = new VehicleQueue(queueCapacity);
    }

    public void VehicleArrives(string number)
    {
        queue.Enqueue(number);
    }

    public void AllowVehicleToEnter()
    {
        if (!queue.IsEmpty())
        {
            string vehicle = queue.Dequeue();
            roundabout.AddVehicle(vehicle);
            Console.WriteLine("Vehicle " + vehicle + "entered roundabout.");
        }
    }

    public void VehicleExit(string number)
    {
        roundabout.RemoveVehicle(number);
    }

    public void ShowRoundabout()
    {
        roundabout.Display();
    }
}
