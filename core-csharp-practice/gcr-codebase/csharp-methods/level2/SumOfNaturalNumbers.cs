using System;
class SumOfNaturalNumbers{
	static int FindSumUsingRecursion(int Number){
		if(Number==0){
			return 0;
		}
		return Number+FindSumUsingRecursion(Number-1);
	}
	static int FindSumUsingFormula(int Number){
		int Sum=Number*(Number+1)/2;
		return Sum;
	}
	static void Main(){
		Console.WriteLine("Enter a Natural Number:");
		int Number=int.Parse(Console.ReadLine());
		if(Number<=0){
			Console.WriteLine("Not a Natural Number");
			return;
		}
		int RecursiveSum=FindSumUsingRecursion(Number);
		int FormulaSum=FindSumUsingFormula(Number);
		Console.WriteLine("Sum Using Recursion:"+RecursiveSum);
		Console.WriteLine("Sum Using Formula:"+FormulaSum);
		if(RecursiveSum==FormulaSum){
			Console.WriteLine("Both Results are Correct");
		}
		else{
			Console.WriteLine("Results are Not Matching");
		}
	}
}
