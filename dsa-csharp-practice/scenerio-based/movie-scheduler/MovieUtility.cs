using System;

class MovieUtility : IMovie
{
    private string[] movies = new string[100];
    private int count = 0;

    public void AddMovie()
    {
        Console.Write("Enter Movie Name: ");
        string movieName = Console.ReadLine();
        Console.Write("Enter Movie Time(HH:MM format) : ");
        string movieTime = Console.ReadLine();
        if (count >= movies.Length)
        {
            Console.WriteLine(" Movie Scheduler is full");
            return;
        }
        Movie movie = new Movie(movieName, movieTime);
        movies[count++] = movie.ToString();
        Console.WriteLine(" Movie Added");
    }

    public void SearchMovie()
    {
        Console.Write("Enter Movie Name : ");
        string movieName = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            string movieNameFromArray = movies[i].Split('\t')[0];
            if (movieNameFromArray.Equals(movieName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(movies[i]);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine(" Movie not found");
        }
    }

    public void DisplayMovie()
    {
        if (count == 0)
        {
            Console.WriteLine(" No movies scheduled");
            return;
        }
        Console.WriteLine(" Scheduled Movies:");
        Console.WriteLine("Movie Name\tMovie Time");
        Console.WriteLine("-------------------------");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(movies[i]);
        }
    }
}
