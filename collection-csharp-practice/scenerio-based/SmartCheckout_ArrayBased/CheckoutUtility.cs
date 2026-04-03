using System;

class CheckoutUtility : ICheckout
{
    private CustomerQueue queue;
    private ItemHashMap itemMap;
    private int customerCounter = 1;

    public CheckoutUtility()
    {
        queue = new CustomerQueue(10);
        itemMap = new ItemHashMap(10);

        itemMap.Put(new Item("Milk", 50, 20));
        itemMap.Put(new Item("Bread", 30, 15));
        itemMap.Put(new Item("Rice", 60, 10));
    }

    public void AddCustomer()
    {
        Console.Write("Enter Item Name: ");
        string item = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        queue.Enqueue(new Customer(customerCounter++, item, qty));
        Console.WriteLine("Customer added to queue");
    }

    public void ProcessBilling()
    {
        Customer customer = queue.Dequeue();

        if (customer == null)
        {
            Console.WriteLine("No customers in queue");
            return;
        }

        Item item = itemMap.Get(customer.ItemName);

        if (item == null)
        {
            Console.WriteLine("Item not found");
            return;
        }

        if (item.Stock < customer.Quantity)
        {
            Console.WriteLine("Insufficient stock");
            return;
        }

        int total = item.Price * customer.Quantity;
        item.Stock -= customer.Quantity;

        Console.WriteLine(customer.ToString());
        Console.WriteLine("Total Bill: " + total);
        Console.WriteLine("Remaining Stock: " + item.Stock);
    }
}
