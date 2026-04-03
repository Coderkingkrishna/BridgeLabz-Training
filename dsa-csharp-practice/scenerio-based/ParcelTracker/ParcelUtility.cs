using System;

class ParcelUtility : IParcelTracker
{
    private ParcelNode head;

    public ParcelUtility()
    {
        head = null;
    }

    // Add stage at end
    public void AddStage(string stageName)
    {
        ParcelNode newNode = new ParcelNode(stageName);

        if (head == null)
        {
            head = newNode;
            return;
        }

        ParcelNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Add custom checkpoint after a given stage
    public void AddAfter(string existingStage, string newStage)
    {
        ParcelNode temp = head;

        while (temp != null)
        {
            if (temp.StageName.Equals(existingStage))
            {
                ParcelNode newNode = new ParcelNode(newStage);
                newNode.Next = temp.Next;
                temp.Next = newNode;
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Stage not found. Parcel might be lost.");
    }

    // Forward tracking
    public void DisplayTracking()
    {
        if (head == null)
        {
            Console.WriteLine("No parcel tracking data available.");
            return;
        }

        ParcelNode temp = head;
        Console.WriteLine("Parcel Tracking Status:");

        while (temp != null)
        {
            Console.WriteLine(temp);
            temp = temp.Next;
        }
    }
}
