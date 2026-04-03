
using System;

class MapNode
{
    public string Genre;
    public CustomLinkedList Books;
    public MapNode Next;

    public MapNode(string genre)
    {
        Genre = genre;
        Books = new CustomLinkedList();
    }
}

class CustomHashMap
{
    private MapNode[] table = new MapNode[20];

    private int Hash(string key)
    {
        return Math.Abs(key.GetHashCode()) % table.Length;
    }

    public CustomLinkedList GetOrCreate(string genre)
    {
        int index = Hash(genre);
        MapNode temp = table[index];

        while (temp != null)
        {
            if (temp.Genre == genre)
                return temp.Books;
            temp = temp.Next;
        }

        MapNode node = new MapNode(genre);
        node.Next = table[index];
        table[index] = node;
        return node.Books;
    }

    public void DisplayAll()
    {
        foreach (MapNode bucket in table)
        {
            MapNode temp = bucket;
            while (temp != null)
            {
                Console.WriteLine("Genre: " + temp.Genre);
                temp.Books.Display();
                temp = temp.Next;
            }
        }
    }
}
