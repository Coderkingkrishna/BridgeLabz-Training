using System;
using System.Collections.Generic;

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public void SetProductId(int id)
    {
        productId = id;
    }

    public void SetName(string productName)
    {
        name = productName;
    }

    public void SetPrice(double productPrice)
    {
        if (productPrice > 0)
        {
            price = productPrice;
        }
    }

    public int GetProductId()
    {
        return productId;
    }

    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }

    public abstract double CalculateDiscount();

    public virtual double GetFinalPrice()
    {
        return price - CalculateDiscount();
    }
}

class Electronics : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return GetPrice() * 0.10;
    }

    public double CalculateTax()
    {
        return GetPrice() * 0.18;
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax: 18%";
    }

    public override double GetFinalPrice()
    {
        return GetPrice() + CalculateTax() - CalculateDiscount();
    }
}

class Clothing : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return GetPrice() * 0.20;
    }

    public double CalculateTax()
    {
        return GetPrice() * 0.12;
    }

    public string GetTaxDetails()
    {
        return "Clothing Tax: 12%";
    }

    public override double GetFinalPrice()
    {
        return GetPrice() + CalculateTax() - CalculateDiscount();
    }
}

class Groceries : Product
{
    public override double CalculateDiscount()
    {
        return GetPrice() * 0.05;
    }
}

class Program
{
    static void PrintFinalPrices(List<Product> products)
    {
        for (int i = 0; i < products.Count; i++)
        {
            Product p = products[i];

            Console.WriteLine("Product ID   : " + p.GetProductId());
            Console.WriteLine("Name         : " + p.GetName());
            Console.WriteLine("Base Price   : " + p.GetPrice());

            if (p is ITaxable)
            {
                ITaxable t = (ITaxable)p;
                Console.WriteLine(t.GetTaxDetails());
                Console.WriteLine("Tax Amount   : " + t.CalculateTax());
            }
            else
            {
                Console.WriteLine("Tax          : Not Applicable");
            }

            Console.WriteLine("Discount     : " + p.CalculateDiscount());
            Console.WriteLine("Final Price  : " + p.GetFinalPrice());
            Console.WriteLine("-----------------");
        }
    }

    static void Main()
    {
        List<Product> products = new List<Product>();

        Product p1 = new Electronics();
        p1.SetProductId(101);
        p1.SetName("Laptop");
        p1.SetPrice(60000);

        Product p2 = new Clothing();
        p2.SetProductId(102);
        p2.SetName("Jacket");
        p2.SetPrice(3000);

        products.Add(p1);
        products.Add(p2);

        PrintFinalPrices(products);

        Console.ReadLine();
    }
}
