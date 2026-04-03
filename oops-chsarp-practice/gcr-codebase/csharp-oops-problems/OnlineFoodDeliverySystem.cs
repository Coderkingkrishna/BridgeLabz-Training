using System;

interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public void SetItemName(string name)
    {
        itemName = name;
    }

    public void SetPrice(double itemPrice)
    {
        if (itemPrice > 0)
        {
            price = itemPrice;
        }
    }

    public void SetQuantity(int qty)
    {
        if (qty > 0)
        {
            quantity = qty;
        }
    }

    public string GetItemName()
    {
        return itemName;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine("Item Name : " + itemName);
        Console.WriteLine("Price     : " + price);
        Console.WriteLine("Quantity  : " + quantity);
    }
}

class VegItem : FoodItem, IDiscountable
{
    public override double CalculateTotalPrice()
    {
        return GetPrice() * GetQuantity();
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.10;
    }

    public string GetDiscountDetails()
    {
        return "Veg Item Discount: 10%";
    }
}

class NonVegItem : FoodItem, IDiscountable
{
    public override double CalculateTotalPrice()
    {
        return (GetPrice() * GetQuantity()) + 50;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05;
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg Item Discount: 5%";
    }
}

class Program
{
    static void ProcessFoodItems(FoodItem[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            FoodItem item = items[i];

            item.GetItemDetails();
            Console.WriteLine("Total Price : " + item.CalculateTotalPrice());

            if (item is IDiscountable)
            {
                IDiscountable d = (IDiscountable)item;
                Console.WriteLine(d.GetDiscountDetails());
                Console.WriteLine("Discount    : " + d.ApplyDiscount());
                Console.WriteLine("Final Price : " + (item.CalculateTotalPrice() - d.ApplyDiscount()));
            }

            Console.WriteLine("-------------------------------");
        }
    }

    static void Main()
    {
        FoodItem[] items = new FoodItem[2];

        FoodItem veg = new VegItem();
        veg.SetItemName("Paneer Butter Masala");
        veg.SetPrice(250);
        veg.SetQuantity(2);

        FoodItem nonVeg = new NonVegItem();
        nonVeg.SetItemName("Chicken Biryani");
        nonVeg.SetPrice(300);
        nonVeg.SetQuantity(1);

        items[0] = veg;
        items[1] = nonVeg;

        ProcessFoodItems(items);

        Console.ReadLine();
    }
}
