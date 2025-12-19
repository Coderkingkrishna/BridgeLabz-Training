using System;
class SimpleInterests{
	static void Main(){
		int Principle = int.Parse(Console.ReadLine());
		int Rate = int.Parse(Console.ReadLine());
		int Time = int.Parse(Console.ReadLine());
		int SimpleInterest = (Principle * Rate * Time) / 100;
		Console.WriteLine("The Simple Interest is "+SimpleInterest+" for Principal "+Principle+", Rate of Interest "+Rate+" and Time "+Time);
	}
}