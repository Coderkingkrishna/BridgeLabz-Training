using System;

class BookNode
{
    public int BookId;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;
    public BookNode Next;
    public BookNode Prev;

    public BookNode(int id, string title, string author, string genre, bool available)
    {
        BookId = id;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = available;
        Next = null;
        Prev = null;
    }
}

class LibraryDoublyLinkedList
{
    private BookNode head;
    private BookNode tail;

    public void AddBookAtEnd(int id, string title, string author, string genre, bool available)
    {
        BookNode newNode = new BookNode(id, title, author, genre, available);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }

    public void RemoveBook(int id)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == id)
            {
                if (temp.Prev != null)
                    temp.Prev.Next = temp.Next;
                else
                    head = temp.Next;

                if (temp.Next != null)
                    temp.Next.Prev = temp.Prev;
                else
                    tail = temp.Prev;

                return;
            }
            temp = temp.Next;
        }
    }

    public void SearchByTitle(string title)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
                PrintBook(temp);
            temp = temp.Next;
        }
    }

    public void SearchByAuthor(string author)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Author == author)
                PrintBook(temp);
            temp = temp.Next;
        }
    }

    public void UpdateAvailability(int id, bool status)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.BookId == id)
            {
                temp.IsAvailable = status;
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayForward()
    {
        BookNode temp = head;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        BookNode temp = tail;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Prev;
        }
    }

    public int CountBooks()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }

    private void PrintBook(BookNode book)
    {
        Console.WriteLine("Book ID     : " + book.BookId);
        Console.WriteLine("Title       : " + book.Title);
        Console.WriteLine("Author      : " + book.Author);
        Console.WriteLine("Genre       : " + book.Genre);
        Console.WriteLine("Available   : " + book.IsAvailable);
        Console.WriteLine("-----------------------------");
    }
}

class Program
{
    static void Main()
    {
        LibraryDoublyLinkedList library = new LibraryDoublyLinkedList();

        library.AddBookAtEnd(1, "AI Basics", "John", "Technology", true);
        library.AddBookAtEnd(2, "Data Science", "Smith", "Education", true);
        library.AddBookAtEnd(3, "ML Guide", "John", "Technology", false);

        library.DisplayForward();

        library.SearchByAuthor("John");

        library.UpdateAvailability(3, true);

        library.RemoveBook(2);

        library.DisplayReverse();
    }
}
