using System;

class BookNode
{
    public Book Data;
    public BookNode Next;

    public BookNode(Book book)
    {
        Data = book;
        Next = null;
    }
}

class CustomLinkedList
{
    private BookNode head;

    public void Add(Book book)
    {
        BookNode node = new BookNode(book);
        if (head == null)
        {
            head = node;
            return;
        }

        BookNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = node;
    }

    public bool Remove(string isbn)
    {
        if (head == null)
            return false;

        if (head.Data.ISBN == isbn)
        {
            head = head.Next;
            return true;
        }

        BookNode curr = head;
        while (curr.Next != null)
        {
            if (curr.Next.Data.ISBN == isbn)
            {
                curr.Next = curr.Next.Next;
                return true;
            }
            curr = curr.Next;
        }
        return false;
    }

    public void Display()
    {
        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        }
    }
}
