using System;
class Book{
    public string ISBN;
    protected string title;
    private string author;
    public void SetAuthor(string a){author=a;}
    public string GetAuthor(){return author;}
}
class EBook:Book{
    public void SetDetails(string i,string t){
        ISBN=i;title=t;
    }
    public void Display(){
        Console.WriteLine(ISBN+" "+title);
    }
}
class Test{
    static void Main(){
        EBook e=new EBook();
        Console.Write("ISBN: "); // input isbn
        string i=Console.ReadLine();
        Console.Write("Title: "); // input title
        string t=Console.ReadLine();
        Console.Write("Author: "); // input author
        string a=Console.ReadLine();
        e.SetDetails(i,t);
        e.SetAuthor(a);
        e.Display();
        Console.WriteLine("Author:"+e.GetAuthor());
    }
}
