using System;
class BmiCalculator{
	static void CalculateBmi(double[,] Data){
		for(int i=0;i<10;i++){
			double Weight=Data[i,0];
			double HeightInMeters=Data[i,1]/100;
			double Bmi=Weight/(HeightInMeters*HeightInMeters);
			Data[i,2]=Bmi;
		}
	}

	static string[] GetBmiStatus(double[,] Data){
		string[] Status=new string[10];
		for(int i=0;i<10;i++){
			double Bmi=Data[i,2];
			if(Bmi<18.5){
				Status[i]="Underweight";
			}else if(Bmi<25){
				Status[i]="Normal";
			}else if(Bmi<30){
				Status[i]="Overweight";
			}else{
				Status[i]="Obese";
			}
		}
		return Status;
	}

	static void Main(){
		double[,] Data=new double[10,3];

		for(int i=0;i<10;i++){
			Console.WriteLine("Enter Weight (kg) of Person "+(i+1)+":");
			Data[i,0]=double.Parse(Console.ReadLine());

			Console.WriteLine("Enter Height (cm) of Person "+(i+1)+":");
			Data[i,1]=double.Parse(Console.ReadLine());
		}

		CalculateBmi(Data);
		string[] Status=GetBmiStatus(Data);

		for(int i=0;i<10;i++){
			Console.WriteLine("Person "+(i+1));
			Console.WriteLine("Weight:"+Data[i,0]);
			Console.WriteLine("Height:"+Data[i,1]);
			Console.WriteLine("BMI:"+Data[i,2]);
			Console.WriteLine("Status:"+Status[i]);
		}
	}
}
