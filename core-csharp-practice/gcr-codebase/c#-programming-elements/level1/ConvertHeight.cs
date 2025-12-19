using System;
class ConvertHeight{
	static void Main(){
		double height = double.Parse(Console.ReadLine());
		double inch = height / 2.54;
		double foot = inch / 12;
		Console.WriteLine("Your Height in cm is "+height+" while in feet is "+foot+" and inches is "+inch);
	}
}