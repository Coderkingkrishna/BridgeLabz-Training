using System;

class MovieNode
{
    public int MovieId;
    public string MovieName;
    public string Genre;
    public int Duration; // in minutes

    public MovieNode Prev;
    public MovieNode Next;

    public MovieNode(int id, string name, string genre, int duration)
    {
        MovieId = id;
        MovieName = name;
        Genre = genre;
        Duration = duration;
        Prev = null;
        Next = null;
    }
}

class MovieDoublyLinkedList
{
    private MovieNode head;
    private MovieNode tail;

    public void AddMovie(int id, string name, string genre, int duration)
    {
        MovieNode newNode = new MovieNode(id, name, genre, duration);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }

    public void DeleteMovie(int id)
    {
        MovieNode temp = head;

        while (temp != null && temp.MovieId != id)
        {
            temp = temp.Next;
        }

        if (temp == null)
            return;

        if (temp == head)
            head = temp.Next;

        if (temp == tail)
            tail = temp.Prev;

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;

        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
    }

    public MovieNode SearchMovie(int id)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.MovieId == id)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void DisplayForward()
    {
        MovieNode temp = head;
        Console.WriteLine("Movies (Forward):");
        while (temp != null)
        {
            PrintMovie(temp);
            temp = temp.Next;
        }
    }

    public void DisplayBackward()
    {
        MovieNode temp = tail;
        Console.WriteLine("Movies (Backward):");
        while (temp != null)
        {
            PrintMovie(temp);
            temp = temp.Prev;
        }
    }

    private void PrintMovie(MovieNode movie)
    {
        Console.WriteLine("ID       : " + movie.MovieId);
        Console.WriteLine("Name     : " + movie.MovieName);
        Console.WriteLine("Genre    : " + movie.Genre);
        Console.WriteLine("Duration : " + movie.Duration + " mins");
        Console.WriteLine("---------------------------");
    }
}

class Program
{
    static void Main()
    {
        MovieDoublyLinkedList movies = new MovieDoublyLinkedList();

        movies.AddMovie(101, "Inception", "Sci-Fi", 148);
        movies.AddMovie(102, "Interstellar", "Sci-Fi", 169);
        movies.AddMovie(103, "Joker", "Drama", 122);

        movies.DisplayForward();
        movies.DisplayBackward();

        movies.DeleteMovie(102);

        Console.WriteLine("After Deletion:");
        movies.DisplayForward();

        Console.ReadLine();
    }
}
