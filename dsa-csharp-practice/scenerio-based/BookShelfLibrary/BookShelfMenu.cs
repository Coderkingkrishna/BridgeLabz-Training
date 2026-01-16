using System;

class BookShelfMenu
{
    IBookShelf shelf = new BookShelfUtility();

    public void Start()
    {
        int choice;
        do
        {
            Console.WriteLine("Book Shelf Menu");
            Console.WriteLine("1 Add Book");
            Console.WriteLine("2 Remove Book");
            Console.WriteLine("3 Display Catalog");
            Console.WriteLine("0 Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Genre: ");
                    string genre = Console.ReadLine();
                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine();
                    shelf.AddBook(new Book(title, author, genre, isbn));
                    break;

                case 2:
                    Console.Write("Genre: ");
                    string g = Console.ReadLine();
                    Console.Write("ISBN: ");
                    string i = Console.ReadLine();
                    shelf.RemoveBook(g, i);
                    break;

                case 3:
                    shelf.DisplayCatalog();
                    break;
            }
        } while (choice != 0);
    }
}
