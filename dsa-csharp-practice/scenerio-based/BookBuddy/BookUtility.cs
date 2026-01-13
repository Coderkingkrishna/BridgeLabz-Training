using System;

class BookUtility : IBookService
{
    private string[] books = new string[100];
    private int count = 0;

    public void AddBook(string title, string author)
    {
        if (count >= books.Length)
        {
            Console.WriteLine(" Bookshelf is full");
            return;
        }

        Book book = new Book(title, author);
        books[count] = book.ToString(); // Title-Author
        count++;

        Console.WriteLine(" Book Added");
    }

    public void SortBooksAlphabetically()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                string title1 = books[i].Split('-')[0];
                string title2 = books[j].Split('-')[0];

                if (string.Compare(title1, title2, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    string temp = books[i];
                    books[i] = books[j];
                    books[j] = temp;
                }
            }
        }

        Console.WriteLine(" Books sorted by TITLE only");
    }

    public void SearchByAuthor(string author)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            string[] parts = books[i].Split('-');

            if (parts.Length == 2 && parts[1].Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(books[i]);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine(" No books found");
    }

    public void DisplayBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("📭 No books to display");
            return;
        }

        Console.WriteLine("\nTITLE\t\tAUTHOR");
        Console.WriteLine("--------------");

        for (int i = 0; i < count; i++)
        {
            string[] parts = books[i].Split('-');
            Console.WriteLine(parts[0] + "\t\t" + parts[1]);
        }
    }
}
