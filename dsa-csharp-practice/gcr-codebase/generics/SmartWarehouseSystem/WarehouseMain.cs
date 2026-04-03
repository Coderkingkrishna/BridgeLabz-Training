using System;
using System.Collections.Generic;

class WarehouseMain
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics(1, "Laptop"));
        electronicsStorage.AddItem(new Electronics(2, "Smart TV"));

        Storage<Groceries> groceryStorage = new Storage<Groceries>();
        groceryStorage.AddItem(new Groceries(3, "Rice Bag"));
        groceryStorage.AddItem(new Groceries(4, "Milk Packet"));

        IReadOnlyStorage<WarehouseItem> readOnlyWarehouse = electronicsStorage;

        Console.WriteLine("Electronics Section:");
        DisplayItems(electronicsStorage.GetAllItems());

        Console.WriteLine("Groceries Section:");
        DisplayItems(groceryStorage.GetAllItems());

        Console.WriteLine("Read Only Warehouse View:");
        DisplayItems(readOnlyWarehouse.GetAllItems());
    }

    static void DisplayItems(IReadOnlyList<WarehouseItem> items)
    {
        foreach (WarehouseItem item in items)
        {
            Console.WriteLine(item);
        }
    }
}
