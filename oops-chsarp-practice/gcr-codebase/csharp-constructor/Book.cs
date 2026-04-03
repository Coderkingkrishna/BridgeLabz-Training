using System;
class Book{
    string title,author;
    double price;
    public Book(){
        title="NA";author="NA";price=0;
    }
    public Book(string title,string author,double price){
        this.title=title;this.author=author;this.price=price;
    }
    public void Display(){
        Console.WriteLine(title+" "+author+" "+price);
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
        Book b=new Book(t,a,p);
        b.Display();
    }
}
