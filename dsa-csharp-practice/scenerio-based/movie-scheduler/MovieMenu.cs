using System;

class MovieMenu
{
    IMovie service;

    public void Run()
    {
        service = new MovieUtility();
        int choice;
        do
        {
            Console.WriteLine("\nMovie Scheduler");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. Display Movies");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddMovie();
                    break;

                case 2:
                    service.SearchMovie();
                    break;

                case 3:
                    service.DisplayMovie();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine(" Invalid Choice");
                    break;
            }
        } while (choice != 4);
    }
}
