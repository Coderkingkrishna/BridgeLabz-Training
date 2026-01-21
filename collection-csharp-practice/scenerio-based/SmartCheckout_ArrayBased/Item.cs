
class Item
{
    private string itemName;
    private int price;
    private int stock;

    public Item(string itemName, int price, int stock)
    {
        this.itemName = itemName;
        this.price = price;
        this.stock = stock;
    }

    public string ItemName { get { return itemName; } }
    public int Price { get { return price; } }
    public int Stock { get { return stock; } set { stock = value; } }

    public override string ToString()
    {
        return itemName + " Price: " + price + " Stock: " + stock;
    }
}
