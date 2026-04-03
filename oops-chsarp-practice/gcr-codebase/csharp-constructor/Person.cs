using System;
class Person{
    string name;
    int age;
    public Person(string name,int age){
        this.name=name;this.age=age;
    }
    public Person(Person p){
        name=p.name;age=p.age;
    }
    public void Display(){
        Console.WriteLine(name+" "+age);
    }
}
class Test{
    static void Main(){
        Console.Write("Name: "); // input name
        string n=Console.ReadLine();
        Console.Write("Age: "); // input age
        int a=int.Parse(Console.ReadLine());
        Person p1=new Person(n,a);
        Person p2=new Person(p1);
        p2.Display();
    }
}
