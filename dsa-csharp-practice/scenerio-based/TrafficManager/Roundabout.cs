using System;

class Roundabout
{
    private VehicleNode head = null;

    public void AddVehicle(string number)
    {
        VehicleNode newNode = new VehicleNode(number);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            return;
        }

        VehicleNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }

    public void RemoveVehicle(string number)
    {
        if (head == null)
        {
            Console.WriteLine("Roundabout empty.");
            return;
        }

        VehicleNode current = head;
        VehicleNode prev = null;

        do
        {
            if (current.VehicleNumber == number)
            {
                if (current == head)
                {
                    if (head.Next == head)
                    {
                        head = null;
                        return;
                    }

                    VehicleNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                else
                {
                    prev.Next = current.Next;
                }

                Console.WriteLine("Vehicle " + number + " exited roundabout.");
                return;
            }

            prev = current;
            current = current.Next;
        } while (current != head);

        Console.WriteLine("Vehicle not found.");
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        VehicleNode temp = head;
        Console.Write("Roundabout: ");
        do
        {
            Console.Write(temp.VehicleNumber + " -> ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("(back to start)");
    }
}
