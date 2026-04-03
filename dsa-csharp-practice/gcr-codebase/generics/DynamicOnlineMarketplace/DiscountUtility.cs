
// Utility class containing generic method
class DiscountUtility
{
    // Generic method with constraint
    public static void ApplyDiscount<TCategory>(
        Product<TCategory> product,
        double percentage)
        where TCategory : ICategory, new()
    {
        double discountAmount = product.Price * percentage / 100;
        product.Price = product.Price - discountAmount;
    }
}
