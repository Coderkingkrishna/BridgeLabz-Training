using System;
class SumOfLoop{
	static int Sum(int Number){
		int Total =0;
		for(int i =1;i<=Number;i++){
			Total += i;
		}
		return Total;
	}
	static void Main(){
		Console.WriteLine("Enter Number : ");
		int Number = int.Parse(Console.ReadLine());
		int Result = Sum(Number);
		Console.WriteLine("The Sum of Number from 1 to n is : "+Result);
	}
}