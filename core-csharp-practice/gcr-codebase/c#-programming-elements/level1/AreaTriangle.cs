using System;
class AreaTriangle{
	static void Main(){
		double Height = double.Parse(Console.ReadLine());
		double Base = double.Parse(Console.ReadLine());
		double AreaInCm = 0.5 * Height * Base;
		double AreaInInch = AreaInCm /2.54;
		Console.WriteLine("Area of triangle in cm is "+AreaInCm+" and in inch is "+AreaInInch);
	}
}