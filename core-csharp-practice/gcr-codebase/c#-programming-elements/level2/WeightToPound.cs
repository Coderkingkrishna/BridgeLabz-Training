using System;
class WeightToPound{
	static void Main(){
		double Weight = double.Parse(Console.ReadLine());
		double Pound = Weight / 2.2;
		Console.WriteLine("The weight of the person in pounds is "+Pound+" and in kg is "+Weight);
	}
}