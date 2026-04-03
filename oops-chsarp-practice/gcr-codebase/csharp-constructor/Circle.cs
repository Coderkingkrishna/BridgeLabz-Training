using System;
class Circle{
    double radius;
    public Circle():this(1){}
    public Circle(double radius){
        this.radius=radius;
    }
    public void Display(){
        Console.WriteLine("Radius:"+radius);
    }
}
class Test{
    static void Main(){
        Console.Write("Radius: "); // input radius
        double r=double.Parse(Console.ReadLine());
        Circle c=new Circle(r);
        c.Display();
    }
}
