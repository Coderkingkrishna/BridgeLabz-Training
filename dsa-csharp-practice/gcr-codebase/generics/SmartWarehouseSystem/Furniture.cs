class Furniture : WarehouseItem
{
    public Furniture(int id, string name)
        : base(id, name) { }

    public override string GetItemType()
    {
        return "Furniture";
    }
}
