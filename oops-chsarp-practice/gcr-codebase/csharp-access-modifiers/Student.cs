using System;
class Student{
    public int rollNumber;
    protected string name;
    private double cgpa;
    public void SetCGPA(double c){cgpa=c;}
    public double GetCGPA(){return cgpa;}
}
class PostgraduateStudent:Student{
    public void SetName(string n){name=n;}
    public void Display(){
        Console.WriteLine(rollNumber+" "+name);
    }
}
class Test{
    static void Main(){
        PostgraduateStudent p=new PostgraduateStudent();
        Console.Write("Roll: "); // input roll
        p.rollNumber=int.Parse(Console.ReadLine());
        Console.Write("Name: "); // input name
        p.SetName(Console.ReadLine());
        Console.Write("CGPA: "); // input cgpa
        p.SetCGPA(double.Parse(Console.ReadLine()));
        p.Display();
        Console.WriteLine("CGPA:"+p.GetCGPA());
    }
}
