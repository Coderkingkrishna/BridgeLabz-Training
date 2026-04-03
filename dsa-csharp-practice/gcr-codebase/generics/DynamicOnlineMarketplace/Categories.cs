
// Marker interface for categories
interface ICategory
{
    string GetCategoryName();
}

// Book category
class BookCategory : ICategory
{
    public string GetCategoryName()
    {
        return "Book";
    }
}

// Clothing category
class ClothingCategory : ICategory
{
    public string GetCategoryName()
    {
        return "Clothing";
    }
}
