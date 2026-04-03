using System;
class Book{
    public static string LibraryName="CentralLibrary";
    public string Title,Author;
    public readonly string ISBN;

    public Book(string Title,string Author,string ISBN){
        this.Title=Title;
        this.Author=Author;
        this.ISBN=ISBN;
    }

    public static void DisplayLibraryName(){
        Console.WriteLine(LibraryName);
    }

    public void Display(object obj){
        if(obj is Book)
            Console.WriteLine(Title+" "+Author+" "+ISBN);
    }

    static void Main(){
        Console.Write("Enter Title: "); // input title
        string t=Console.ReadLine();
        Console.Write("Enter Author: "); // input author
        string a=Console.ReadLine();
        Console.Write("Enter ISBN: "); // input isbn
        string i=Console.ReadLine();
        Book b=new Book(t,a,i);
        DisplayLibraryName();
        b.Display(b);
    }
}
