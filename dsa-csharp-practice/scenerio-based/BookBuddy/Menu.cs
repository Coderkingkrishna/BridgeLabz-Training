using System;

class Menu
{
    public static void Run()
    {
        IBookService service = new BookUtility();
        int choice;

        do
        {
            Console.WriteLine("\nBookBuddy – Digital Bookshelf");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Sort Books");
            Console.WriteLine("3. Search by Author");
            Console.WriteLine("4. Display Books");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();

                    service.AddBook(title, author);
                    break;

                case 2:
                    service.SortBooksAlphabetically();
                    break;

                case 3:
                    Console.Write("Enter Author: ");
                    service.SearchByAuthor(Console.ReadLine());
                    break;

                case 4:
                    service.DisplayBooks();
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine(" Invalid Choice");
                    break;
            }
        } while (choice != 5);
    }
}
