using System;
class EmployeeBonus{
	static double[,] GenerateEmployeeData(){
		double[,] Data=new double[10,2];
		Random Random=new Random();
		for(int i=0;i<10;i++){
			Data[i,0]=Random.Next(10000,100000);
			Data[i,1]=Random.Next(1,11);
		}
		return Data;
	}

	static double[,] CalculateBonusAndNewSalary(double[,] Data){
		double[,] Result=new double[10,3];
		for(int i=0;i<10;i++){
			double OldSalary=Data[i,0];
			double Years=Data[i,1];
			double Bonus;
			if(Years>5){
				Bonus=OldSalary*0.05;
			}else{
				Bonus=OldSalary*0.02;
			}
			double NewSalary=OldSalary+Bonus;
			Result[i,0]=OldSalary;
			Result[i,1]=NewSalary;
			Result[i,2]=Bonus;
		}
		return Result;
	}

	static void CalculateAndDisplayTotals(double[,] Result){
		double OldSalarySum=0;
		double NewSalarySum=0;
		double BonusSum=0;

		Console.WriteLine("OldSalary   NewSalary   Bonus");
		for(int i=0;i<10;i++){
			Console.WriteLine(Result[i,0]+"   "+Result[i,1]+"   "+Result[i,2]);
			OldSalarySum+=Result[i,0];
			NewSalarySum+=Result[i,1];
			BonusSum+=Result[i,2];
		}
		Console.WriteLine("Total Old Salary: "+OldSalarySum);
		Console.WriteLine("Total New Salary: "+NewSalarySum);
		Console.WriteLine("Total Bonus: "+BonusSum);
	}

	static void Main(){
		double[,] Data=GenerateEmployeeData();
		double[,] Result=CalculateBonusAndNewSalary(Data);
		CalculateAndDisplayTotals(Result);
	}
}
