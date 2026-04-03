using System;

class VehicleQueue
{
    private QueueNode front,
        rear;
    private int size,
        capacity;

    public VehicleQueue(int capacity)
    {
        this.capacity = capacity;
        size = 0;
        front = rear = null;
    }

    public void Enqueue(string number)
    {
        if (size == capacity)
        {
            Console.WriteLine("Queue Overflow! Vehicle cannot enter.");
            return;
        }

        QueueNode newNode = new QueueNode(number);

        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }

        size++;
        Console.WriteLine("Vehicle " + number + " added to waiting queue.");
    }

    public string Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue Underflow! No vehicles waiting.");
            return null;
        }

        string number = front.VehicleNumber;
        front = front.Next;

        if (front == null)
            rear = null;

        size--;
        return number;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }
}
