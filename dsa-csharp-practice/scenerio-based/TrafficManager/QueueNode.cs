class QueueNode
{
    public string VehicleNumber;
    public QueueNode Next;

    public QueueNode(string number)
    {
        VehicleNumber = number;
        Next = null;
    }
}
