using System;
class Circle{
	private double Radius;
	public Circle(double Radius){
		this.Radius = Radius;
	}
	public double AreaOfCircle(){
		return Math.PI * Radius * Radius;
	}
	public void Display(){
		Console.WriteLine("Area of the circle is :- "+ AreaOfCircle());
	}
	
}

class User{
	static void Main(){
		Console.Write("Enter Radius :- ");
		double Radius = double.Parse(Console.ReadLine());
		Circle C1 = new Circle(Radius);
		C1.AreaOfCircle();
		C1.Display();
	}
}