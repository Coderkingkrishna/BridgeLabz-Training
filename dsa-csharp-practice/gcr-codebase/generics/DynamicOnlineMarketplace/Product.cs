
// Generic Product class with category constraint
class Product<TCategory> where TCategory : ICategory, new()
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    private TCategory category;

    public Product(int id, string name, double price)
    {
        ProductId = id;
        Name = name;
        Price = price;
        category = new TCategory();
    }

    public string GetCategory()
    {
        return category.GetCategoryName();
    }

    public override string ToString()
    {
        return "Id: " + ProductId +
               ", Name: " + Name +
               ", Price: " + Price +
               ", Category: " + GetCategory();
    }
}
