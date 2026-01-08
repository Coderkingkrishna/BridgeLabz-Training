using System;

class ItemNode
{
    public int ItemId;
    public string ItemName;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(int id, string name, int qty, double price)
    {
        ItemId = id;
        ItemName = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}

class InventoryLinkedList
{
    private ItemNode head;

    public void AddItemAtEnd(int id, string name, int qty, double price)
    {
        ItemNode newNode = new ItemNode(id, name, qty, price);

        if (head == null)
        {
            head = newNode;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }

    public void RemoveItem(int id)
    {
        if (head == null)
            return;

        if (head.ItemId == id)
        {
            head = head.Next;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null)
        {
            if (temp.Next.ItemId == id)
            {
                temp.Next = temp.Next.Next;
                return;
            }
            temp = temp.Next;
        }
    }

    public void UpdateQuantity(int id, int qty)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                temp.Quantity = qty;
                return;
            }
            temp = temp.Next;
        }
    }

    public void SearchById(int id)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
                PrintItem(temp);
            temp = temp.Next;
        }
    }

    public void SearchByName(string name)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemName == name)
                PrintItem(temp);
            temp = temp.Next;
        }
    }

    public void DisplayAll()
    {
        ItemNode temp = head;
        while (temp != null)
        {
            PrintItem(temp);
            temp = temp.Next;
        }
    }

    public void CalculateTotalValue()
    {
        double total = 0;
        ItemNode temp = head;
        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value: " + total);
    }

    private void PrintItem(ItemNode item)
    {
        Console.WriteLine("Item ID   : " + item.ItemId);
        Console.WriteLine("Name      : " + item.ItemName);
        Console.WriteLine("Quantity  : " + item.Quantity);
        Console.WriteLine("Price     : " + item.Price);
        Console.WriteLine("-------------------------");
    }
}

class Program
{
    static void Main()
    {
        InventoryLinkedList inventory = new InventoryLinkedList();

        inventory.AddItemAtEnd(101, "Laptop", 5, 50000);
        inventory.AddItemAtEnd(102, "Mouse", 20, 500);
        inventory.AddItemAtEnd(103, "Keyboard", 10, 1500);

        inventory.DisplayAll();

        inventory.UpdateQuantity(102, 25);

        inventory.SearchById(102);

        inventory.RemoveItem(101);

        inventory.DisplayAll();

        inventory.CalculateTotalValue();

        Console.ReadLine();
    }
}
