using System;
class UnitConvertor{
	static double ConvertKmToMiles(double Km){
		return Km*0.621371;
	}

	static double ConvertMilesToKm(double Miles){
		return Miles*1.60934;
	}

	static double ConvertMetersToFeet(double Meters){
		return Meters*3.28084;
	}

	static double ConvertFeetToMeters(double Feet){
		return Feet*0.3048;
	}

	static void Main(){
		Console.WriteLine("Enter Kilometers:");
		double Km=double.Parse(Console.ReadLine());
		Console.WriteLine("Km to Miles:"+ConvertKmToMiles(Km));

		Console.WriteLine("Enter Miles:");
		double Miles=double.Parse(Console.ReadLine());
		Console.WriteLine("Miles to Km:"+ConvertMilesToKm(Miles));

		Console.WriteLine("Enter Meters:");
		double Meters=double.Parse(Console.ReadLine());
		Console.WriteLine("Meters to Feet:"+ConvertMetersToFeet(Meters));

		Console.WriteLine("Enter Feet:");
		double Feet=double.Parse(Console.ReadLine());
		Console.WriteLine("Feet to Meters:"+ConvertFeetToMeters(Feet));
	}
}
