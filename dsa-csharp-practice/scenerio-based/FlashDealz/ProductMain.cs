class ProductMain
{
    public static void Main(string[] args)
    {
        Product[] products = new Product[5];
        products[0] = new Product(101, "Laptop", 50000, 10);
        products[1] = new Product(102, "Smartphone", 20000, 15);
        products[2] = new Product(103, "Tablet", 15000, 5);
        products[3] = new Product(104, "Headphones", 3000, 20);
        products[4] = new Product(105, "Smartwatch", 8000, 12);

        IProduct productManager = new ProductUtility();
        productManager.DisplayProductWithSortDiscount(products);
    }
}
