class Customer
{
    private int customerId;
    private string itemName;
    private int quantity;

    public Customer(int customerId, string itemName, int quantity)
    {
        this.customerId = customerId;
        this.itemName = itemName;
        this.quantity = quantity;
    }

    public int CustomerId
    {
        get { return customerId; }
    }
    public string ItemName
    {
        get { return itemName; }
    }
    public int Quantity
    {
        get { return quantity; }
    }

    public override string ToString()
    {
        return "Customer ID: " + customerId + ", Item: " + itemName + ", Quantity: " + quantity;
    }
}
