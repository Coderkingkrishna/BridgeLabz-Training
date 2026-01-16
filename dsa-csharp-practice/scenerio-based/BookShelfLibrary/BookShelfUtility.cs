
using System;

class BookShelfUtility : IBookShelf
{
    private CustomHashMap genreMap = new CustomHashMap();
    private CustomHashSet isbnSet = new CustomHashSet();

    public void AddBook(Book book)
    {
        if (!isbnSet.Add(book.ISBN))
        {
            Console.WriteLine("Duplicate ISBN not allowed");
            return;
        }

        CustomLinkedList list = genreMap.GetOrCreate(book.Genre);
        list.Add(book);
        Console.WriteLine("Book added successfully");
    }

    public void RemoveBook(string genre, string isbn)
    {
        CustomLinkedList list = genreMap.GetOrCreate(genre);
        if (list.Remove(isbn))
        {
            isbnSet.Remove(isbn);
            Console.WriteLine("Book removed");
        }
        else
        {
            Console.WriteLine("Book not found");
        }
    }

    public void DisplayCatalog()
    {
        genreMap.DisplayAll();
    }
}
