using System;
class PersonsBmi{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		double[] Weight = new double[Number];
		double[] Height = new double[Number];
		String[] Bmi = new String[Number];
		for(int i =0;i<Number;i++){
			Weight[i] = double.Parse(Console.ReadLine());
		}
		for(int i =0;i<Number;i++){
			Height[i] = double.Parse(Console.ReadLine()) / 100;
		}
		for(int i =0;i<Number;i++){
			double Bmiv = Weight[i] / (Height[i] * Height[i]);
			if(Bmiv >= 40.0){
				Bmi[i] = "Obese";
			}
			else if(Bmiv >= 25.0 && Bmiv <40.0){
				Bmi[i] = "Overweight";
			}
			else if(Bmiv >= 18.5 && Bmiv <25.0){
				Bmi[i] = "Normal";
			}
			else{
				Bmi[i] = "Underweight";
			}
		}
		for(int i =0;i<Number;i++){
			Console.WriteLine("Person with height"+Height[i]+" and Weight "+Weight[i]+" have BMI status "+Bmi[i]);
		}
	}
}