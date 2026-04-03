class Program
{
    static void Main()
    {
        TrafficManager manager = new TrafficManager(3);

        manager.VehicleArrives("KA01");
        manager.VehicleArrives("MH12");
        manager.VehicleArrives("DL09");
        manager.VehicleArrives("TN22");

        manager.AllowVehicleToEnter();
        manager.AllowVehicleToEnter();

        manager.ShowRoundabout();

        manager.VehicleExit("KA01");
        manager.ShowRoundabout();

        manager.AllowVehicleToEnter();
        manager.ShowRoundabout();
    }
}
