using System;
class Book{
    protected string Title;
    protected int PublicationYear;
    public Book(string t,int y){
        Title=t;PublicationYear=y;
    }
}
class Author:Book{
    string Name,Bio;
    public Author(string t,int y,string n,string b):base(t,y){
        Name=n;Bio=b;
    }
    public void DisplayInfo(){
        Console.WriteLine(Title+" "+PublicationYear+" "+Name+" "+Bio);
    }
}
class Test{
    static void Main(){
        Console.Write("Title: "); // input title
        string t=Console.ReadLine();
        Console.Write("Year: "); // input year
        int y=int.Parse(Console.ReadLine());
        Console.Write("Author Name: "); // input author name
        string n=Console.ReadLine();
        Console.Write("Bio: "); // input bio
        string b=Console.ReadLine();
        Author a=new Author(t,y,n,b);
        a.DisplayInfo();
    }
}
