using System;
class MultiPersonsBmi{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		double[,] Person = new double[Number,3];
		String[] Bmi = new String[Number];
		for(int i =0;i<Number;i++){
			Console.WriteLine("Enter person"+(i+1)+"Weight and Height");
			for(int j=0;j<2;j++){
				Person[i, j] = double.Parse(Console.ReadLine());
			}
			Person[i, 2] = Person[i,0] / ((Person[i, 1]/100) * (Person[i, 1]/100));
		}
		for(int i =0;i<Number;i++){
			double Bmiv = Person[i, 2];
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
			Console.WriteLine("Person with height"+Person[i,0]+" and Weight "+Person[i, 1]+"have BMI "+Person[i,2]+" have BMI status "+Bmi[i]);
		}
	}
}