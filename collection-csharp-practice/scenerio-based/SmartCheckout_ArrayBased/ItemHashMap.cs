
class ItemHashMap
{
    private Item[] table;
    private int size;

    public ItemHashMap(int size)
    {
        this.size = size;
        table = new Item[size];
    }

    private int Hash(string key)
    {
        return key.Length % size;
    }

    public void Put(Item item)
    {
        int index = Hash(item.ItemName);

        while (table[index] != null && table[index].ItemName != item.ItemName)
        {
            index = (index + 1) % size;
        }

        table[index] = item;
    }

    public Item Get(string itemName)
    {
        int index = Hash(itemName);
        int start = index;

        while (table[index] != null)
        {
            if (table[index].ItemName == itemName)
                return table[index];

            index = (index + 1) % size;
            if (index == start)
                break;
        }
        return null;
    }
}
