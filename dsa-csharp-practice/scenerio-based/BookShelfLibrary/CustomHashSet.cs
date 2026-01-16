
class HashSetNode
{
    public string Key;
    public HashSetNode Next;

    public HashSetNode(string key)
    {
        Key = key;
    }
}

class CustomHashSet
{
    private HashSetNode[] table = new HashSetNode[50];

    private int Hash(string key)
    {
        return System.Math.Abs(key.GetHashCode()) % table.Length;
    }

    public bool Add(string key)
    {
        int index = Hash(key);
        HashSetNode temp = table[index];

        while (temp != null)
        {
            if (temp.Key == key) return false;
            temp = temp.Next;
        }

        HashSetNode node = new HashSetNode(key);
        node.Next = table[index];
        table[index] = node;
        return true;
    }

    public void Remove(string key)
    {
        int index = Hash(key);
        HashSetNode curr = table[index];
        HashSetNode prev = null;

        while (curr != null)
        {
            if (curr.Key == key)
            {
                if (prev == null) table[index] = curr.Next;
                else prev.Next = curr.Next;
                return;
            }
            prev = curr;
            curr = curr.Next;
        }
    }
}
