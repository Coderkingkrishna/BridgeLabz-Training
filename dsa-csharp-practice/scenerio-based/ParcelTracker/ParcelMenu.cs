using System;

class ParcelMenu
{
    private IParcelTracker tracker;

    public ParcelMenu()
    {
        tracker = new ParcelUtility();
    }

    public void Run()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Parcel Tracker Menu ---");
            Console.WriteLine("1. Add Delivery Stage");
            Console.WriteLine("2. Add Intermediate Checkpoint");
            Console.WriteLine("3. Display Parcel Tracking");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter stage name: ");
                    tracker.AddStage(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Enter existing stage: ");
                    string existing = Console.ReadLine();
                    Console.Write("Enter new stage: ");
                    string newStage = Console.ReadLine();
                    tracker.AddAfter(existing, newStage);
                    break;

                case 3:
                    tracker.DisplayTracking();
                    break;

                case 4:
                    Console.WriteLine("Exiting Parcel Tracker.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 4);
    }
}
