interface IBookShelf
{
    void AddBook(Book book);
    void RemoveBook(string genre, string isbn);
    void DisplayCatalog();
}
