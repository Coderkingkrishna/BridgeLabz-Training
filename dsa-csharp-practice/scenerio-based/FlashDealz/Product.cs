class Product
{
    private int ProductID;
    private string ProductName;
    private double Price;
    private int Discount;

    public Product(int productID, string productName, double price, int discount)
    {
        ProductID = productID;
        ProductName = productName;
        Price = price;
        Discount = discount;
    }

    public int DiscountProperty
    {
        get { return Discount; }
    }

    public override string ToString()
    {
        return (
            "Product ID: "
            + ProductID
            + ", Product Name: "
            + ProductName
            + ", Price: "
            + Price
            + ", Discount: "
            + Discount
        );
    }
}
