using System;
using System.Collections.Generic;

class CustomHashMap
{
    // Node for Linked List
    class Node
    {
        public int Key;
        public int Value;
        public Node Next;

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private int SIZE = 10;
    private Node[] table;

    public CustomHashMap()
    {
        table = new Node[SIZE];
    }

    // Hash Function
    private int Hash(int key)
    {
        return key % SIZE;
    }

    // Insert or Update
    public void Put(int key, int value)
    {
        int index = Hash(key);
        Node head = table[index];

        while (head != null)
        {
            if (head.Key == key)
            {
                head.Value = value; // update
                return;
            }
            head = head.Next;
        }

        Node newNode = new Node(key, value);
        newNode.Next = table[index];
        table[index] = newNode;
    }

    // Get Value
    public int Get(int key)
    {
        int index = Hash(key);
        Node head = table[index];

        while (head != null)
        {
            if (head.Key == key)
                return head.Value;
            head = head.Next;
        }

        return -1; // not found
    }

    // Remove Key
    public void Remove(int key)
    {
        int index = Hash(key);
        Node head = table[index];
        Node prev = null;

        while (head != null)
        {
            if (head.Key == key)
            {
                if (prev == null)
                    table[index] = head.Next;
                else
                    prev.Next = head.Next;
                return;
            }
            prev = head;
            head = head.Next;
        }
    }

    // Display Hash Map
    public void Display()
    {
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write(i + ": ");
            Node head = table[i];
            while (head != null)
            {
                Console.Write("[" + head.Key + "," + head.Value + "] -> ");
                head = head.Next;
            }
            Console.WriteLine("null");
        }
    }

    // Main Method
    static void Main()
    {
        CustomHashMap map = new CustomHashMap();

        map.Put(1, 100);
        map.Put(2, 200);
        map.Put(12, 300); // collision (12 % 10 = 2)

        Console.WriteLine("Value for key 2: " + map.Get(2));

        map.Remove(2);

        Console.WriteLine("After deletion:");
        map.Display();
    }
}
