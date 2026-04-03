using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Smart Home Automation System ===\n");

        IControllable device = DeviceUtility.GetDeviceFromUser();

        if (device != null)
        {
            DeviceUtility.PerformAction(device);
        }
    }
}
