using System;

public static class DeviceUtility
{
    public static IControllable GetDeviceFromUser()
    {
        Console.WriteLine("Select a Device:");
        Console.WriteLine("1. Light");
        Console.WriteLine("2. Fan");
        Console.WriteLine("3. AC");
        Console.Write("Enter choice: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                return new Light();
            case 2:
                return new Fan();
            case 3:
                return new AC();
            default:
                Console.WriteLine("Invalid device selection!");
                return null;
        }
    }

    public static void PerformAction(IControllable device)
    {
        Console.WriteLine("\nSelect Action:");
        Console.WriteLine("1. Turn ON");
        Console.WriteLine("2. Turn OFF");
        Console.Write("Enter choice: ");

        int action = int.Parse(Console.ReadLine());

        if (action == 1)
            device.TurnOn();
        else if (action == 2)
            device.TurnOff();
        else
            Console.WriteLine("Invalid action!");
    }
}
