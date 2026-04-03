using System;
class UnitConvert{
	static double ConvertYardsToFeet(double Yards){
		return Yards*3;
	}

	static double ConvertFeetToYards(double Feet){
		return Feet*0.333333;
	}

	static double ConvertMetersToInches(double Meters){
		return Meters*39.3701;
	}

	static double ConvertInchesToMeters(double Inches){
		return Inches*0.0254;
	}

	static double ConvertInchesToCentimeters(double Inches){
		return Inches*2.54;
	}

	static void Main(){
		Console.WriteLine("Enter Yards:");
		double Yards=double.Parse(Console.ReadLine());
		Console.WriteLine("Yards to Feet:"+ConvertYardsToFeet(Yards));

		Console.WriteLine("Enter Feet:");
		double Feet=double.Parse(Console.ReadLine());
		Console.WriteLine("Feet to Yards:"+ConvertFeetToYards(Feet));

		Console.WriteLine("Enter Meters:");
		double Meters=double.Parse(Console.ReadLine());
		Console.WriteLine("Meters to Inches:"+ConvertMetersToInches(Meters));

		Console.WriteLine("Enter Inches:");
		double Inches=double.Parse(Console.ReadLine());
		Console.WriteLine("Inches to Meters:"+ConvertInchesToMeters(Inches));
		Console.WriteLine("Inches to Centimeters:"+ConvertInchesToCentimeters(Inches));
	}
}
