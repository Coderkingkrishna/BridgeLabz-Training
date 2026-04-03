
abstract class WarehouseItem
{
    public int ItemId { get; set; }
    public string Name { get; set; }

    protected WarehouseItem(int itemId, string name)
    {
        ItemId = itemId;
        Name = name;
    }

    public abstract string GetItemType();

    public override string ToString()
    {
        return "ID: " + ItemId + ", Name: " + Name + ", Type: " + GetItemType();
    }
}
