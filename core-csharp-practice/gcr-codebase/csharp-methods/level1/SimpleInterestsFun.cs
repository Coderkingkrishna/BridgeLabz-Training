using System;
class SimpleInterestsFun{
	static void Simple(double principle, double rate, int time){
		double SimpleInterest = (principle * rate * time) / 100;
		Console.WriteLine("The Simple Interest is "+SimpleInterest+" for Principal "+principle+", Rate of Interest "+rate+" and Time "+time);
	}
	static void Main(){
		double principle = double.Parse(Console.ReadLine());
		double rate = double.Parse(Console.ReadLine());
		int time = int.Parse(Console.ReadLine());
		Simple(principle, rate, time);
	}
}