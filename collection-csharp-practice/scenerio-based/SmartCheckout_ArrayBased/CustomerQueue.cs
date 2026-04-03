class CustomerQueue
{
    private Customer[] queue;
    private int front,
        rear,
        size;

    public CustomerQueue(int capacity)
    {
        queue = new Customer[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public bool IsFull()
    {
        return size == queue.Length;
    }

    public void Enqueue(Customer customer)
    {
        if (IsFull())
        {
            System.Console.WriteLine("Queue is full");
            return;
        }

        rear = (rear + 1) % queue.Length;
        queue[rear] = customer;
        size++;
    }

    public Customer Dequeue()
    {
        if (IsEmpty())
        {
            return null;
        }

        Customer customer = queue[front];
        front = (front + 1) % queue.Length;
        size--;
        return customer;
    }
}
