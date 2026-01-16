class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string Genre { get; private set; }
    public string ISBN { get; private set; }

    public Book(string title, string author, string genre, string isbn)
    {
        Title = title;
        Author = author;
        Genre = genre;
        ISBN = isbn;
    }

    public override string ToString()
    {
        return "Title: " + Title + ", Author: " + Author + ", ISBN: " + ISBN;
    }
}
