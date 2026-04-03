using System;
class Book{
    private string title;
    private string author;
    private double price;

    public Book(string title,string author,double price){
        this.title=title;
        this.author=author;
        this.price=price;
    }

    public void Display(){
        Console.WriteLine("Title: "+title);
        Console.WriteLine("Author: "+author);
        Console.WriteLine("Price: "+price);
    }
}

class User{
    static void Main(){
        string title=Console.ReadLine();
        string author=Console.ReadLine();
        double price=double.Parse(Console.ReadLine());

        Book b1=new Book(title,author,price);
        b1.Display();
    }
}
