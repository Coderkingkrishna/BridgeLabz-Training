using System;
class Bmi{
	static void Main(){
		double Weight = double.Parse(Console.ReadLine());
		double Height = double.Parse(Console.ReadLine()) / 100;
		double Bmiv = Weight / (Height * Height);
		if(Bmiv >= 40.0){
			Console.WriteLine("Obese");
		}
		else if(Bmiv >= 25.0 && Bmiv <40.0){
			Console.WriteLine("Overweight");
		}
		else if(Bmiv >= 18.5 && Bmiv <25.0){
			Console.WriteLine("Normal");
		}
		else{
			Console.WriteLine("Underweight");
		}
	}
}