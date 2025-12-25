using System;
class WindChill{
	static double CalculateWind(double Temperature,double WindSpeed){
		double WindChill=35.74+0.6215*Temperature+(0.4275*Temperature-35.75)*Math.Pow(WindSpeed,0.16);
		return WindChill;
	}

	static void Main(){
		Console.WriteLine("Enter Temperature:");
		double Temperature=double.Parse(Console.ReadLine());

		Console.WriteLine("Enter Wind Speed:");
		double WindSpeed=double.Parse(Console.ReadLine());

		double Result=CalculateWind(Temperature,WindSpeed);
		Console.WriteLine("Wind Chill Temperature is:"+Result);
	}
}
