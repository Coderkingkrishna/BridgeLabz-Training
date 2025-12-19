using System;
class FehrenheitToCelcius{
	static void Main(){
		double Fehrenheit = double.Parse(Console.ReadLine());
		double Celcius = (Fehrenheit - 32) * 5/9;
		Console.WriteLine("The "+Fehrenheit+" fehrenheit is "+Celcius+" Celcius");
	}
}