using System;
class LibraryBook{
    string title,author;
    double price;
    bool available=true;
    public LibraryBook(string t,string a,double p){
        title=t;author=a;price=p;
    }
    public void BorrowBook(){
        if(available){available=false;Console.WriteLine("Book Borrowed");}
        else Console.WriteLine("Not Available");
    }
}
class Test{
    static void Main(){
        Console.Write("Title: "); // input title
        string t=Console.ReadLine();
        Console.Write("Author: "); // input author
        string a=Console.ReadLine();
        Console.Write("Price: "); // input price
        double p=double.Parse(Console.ReadLine());
        LibraryBook b=new LibraryBook(t,a,p);
        b.BorrowBook();
        b.BorrowBook();
    }
}
