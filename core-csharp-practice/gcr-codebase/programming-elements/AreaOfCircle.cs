using System;
class AreaOfCircle{
	public static void Main(){
		int radius = int.Parse(Console.ReadLine());
		double area = 3.14 * radius *radius;
		Console.WriteLine("area of circle with radius "+radius +" = "+ area);
	}
}