using System;
class Athlete{
	static int PerimeterOfTriangle(int Side1, int Side2, int Side3){
		int Total =  5000/(Side1+Side2+Side3);
		return Total;
	}
	static void Main(){
		Console.WriteLine("Enter three sides of triangle : ");
		int Side1 = int.Parse(Console.ReadLine());
		int Side2 = int.Parse(Console.ReadLine());
		int Side3 = int.Parse(Console.ReadLine());
		int Round = PerimeterOfTriangle(Side1, Side2, Side3);
		Console.WriteLine("total Round : "+Round);
	}
}