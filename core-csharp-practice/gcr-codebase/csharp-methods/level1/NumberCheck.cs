using System;
class NumberCheck{
	static void CheckNumber(int Number){
		if(Number > 0){
			Console.WriteLine("The Number is Positive");
		}
		else if(Number < 0){
			Console.WriteLine("The Number is Negative");
		}
		else{
			Console.WriteLine("The Number is Zero");
		}
	}
	static void Main(){
		Console.WriteLine("Enter Number : ");
		int Number = int.Parse(Console.ReadLine());
		CheckNumber(Number);
	}
}