using System;
class SquareOfPerimeter{
	static void Main(){
		double Length = double.Parse(Console.ReadLine());
		double Perimeter = Length * 4;
		Console.WriteLine("The length of the side is "+Length+" whose perimeter is "+Perimeter);
	}
}