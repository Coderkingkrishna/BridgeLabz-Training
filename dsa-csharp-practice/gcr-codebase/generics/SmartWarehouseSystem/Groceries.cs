class Groceries : WarehouseItem
{
    public Groceries(int id, string name)
        : base(id, name) { }

    public override string GetItemType()
    {
        return "Groceries";
    }
}
