using System;

class Menu
{
    IBookService service;

    public static void Run()
    {
        service = new BookUtility();
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

                    service.AddBook();
                    break;

                case 2:
                    service.SortBooksAlphabetically();
                    break;

                case 3:

                    service.SearchByAuthor();
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
