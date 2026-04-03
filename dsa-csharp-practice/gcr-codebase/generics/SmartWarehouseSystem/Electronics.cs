class Electronics : WarehouseItem
{
    public Electronics(int id, string name)
        : base(id, name) { }

    public override string GetItemType()
    {
        return "Electronics";
    }
}
