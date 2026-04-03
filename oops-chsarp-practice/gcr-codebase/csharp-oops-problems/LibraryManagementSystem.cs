using System;

interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;
    private string borrowerPersonalData;
    protected bool isAvailable = true;

    public void SetItemId(int id)
    {
        itemId = id;
    }

    public void SetTitle(string itemTitle)
    {
        title = itemTitle;
    }

    public void SetAuthor(string itemAuthor)
    {
        author = itemAuthor;
    }

    protected void SetBorrowerPersonalData(string data)
    {
        borrowerPersonalData = data;
    }

    public int GetItemId()
    {
        return itemId;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine("Item ID   : " + itemId);
        Console.WriteLine("Title     : " + title);
        Console.WriteLine("Author    : " + author);
        Console.WriteLine("Available : " + isAvailable);
    }
}

class Book : LibraryItem, IReservable
{
    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            SetBorrowerPersonalData("Book Borrower");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

class Magazine : LibraryItem, IReservable
{
    public override int GetLoanDuration()
    {
        return 7;
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            SetBorrowerPersonalData("Magazine Borrower");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

class DVD : LibraryItem, IReservable
{
    public override int GetLoanDuration()
    {
        return 3;
    }

    public void ReserveItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            SetBorrowerPersonalData("DVD Borrower");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

class Program
{
    static void ProcessItems(LibraryItem[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            LibraryItem item = items[i];

            item.GetItemDetails();
            Console.WriteLine("Loan Duration : " + item.GetLoanDuration());

            if (item is IReservable)
            {
                IReservable r = (IReservable)item;
                Console.WriteLine("Available Before : " + r.CheckAvailability());
                r.ReserveItem();
                Console.WriteLine("Available After  : " + r.CheckAvailability());
            }

            Console.WriteLine("-----------------------------");
        }
    }

    static void Main()
    {
        LibraryItem[] items = new LibraryItem[3];

        LibraryItem book = new Book();
        book.SetItemId(1);
        book.SetTitle("C# Programming");
        book.SetAuthor("John Doe");

        LibraryItem magazine = new Magazine();
        magazine.SetItemId(2);
        magazine.SetTitle("Tech Monthly");
        magazine.SetAuthor("Tech Media");

        LibraryItem dvd = new DVD();
        dvd.SetItemId(3);
        dvd.SetTitle("AI Documentary");
        dvd.SetAuthor("Discovery");

        items[0] = book;
        items[1] = magazine;
        items[2] = dvd;

        ProcessItems(items);

        Console.ReadLine();
    }
}
