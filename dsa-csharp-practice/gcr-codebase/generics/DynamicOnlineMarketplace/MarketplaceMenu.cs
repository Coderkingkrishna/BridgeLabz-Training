
using System;

class MarketplaceMenu
{
    static Product<BookCategory> bookProduct;
    static Product<ClothingCategory> clothingProduct;

    public void Run()
    {
        int choice;

        do
        {
            Console.WriteLine("Dynamic Online Marketplace");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add Clothing");
            Console.WriteLine("3. Apply Discount");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    AddClothing();
                    break;
                case 3:
                    ApplyDiscountMenu();
                    break;
            }
        }
        while (choice != 4);
    }

    void AddBook()
    {
        Console.Write("Enter Book Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Book Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        bookProduct = new Product<BookCategory>(id, name, price);
        Console.WriteLine(bookProduct);
    }

    void AddClothing()
    {
        Console.Write("Enter Clothing Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Clothing Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        clothingProduct = new Product<ClothingCategory>(id, name, price);
        Console.WriteLine(clothingProduct);
    }

    void ApplyDiscountMenu()
    {
        Console.Write("Enter discount percentage: ");
        double percentage = Convert.ToDouble(Console.ReadLine());

        if (bookProduct != null)
        {
            DiscountUtility.ApplyDiscount(bookProduct, percentage);
            Console.WriteLine(bookProduct);
        }

        if (clothingProduct != null)
        {
            DiscountUtility.ApplyDiscount(clothingProduct, percentage);
            Console.WriteLine(clothingProduct);
        }
    }
}
