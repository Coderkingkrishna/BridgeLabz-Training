using System;
class CelciusToFehrenheit{
	static void Main(){
		double Celcius = double.Parse(Console.ReadLine());
		double fehrenheit = (Celcius * 9/5) + 32;
		Console.WriteLine("The "+Celcius+" is "+fehrenheit+" Fehrenheit");
	}
}