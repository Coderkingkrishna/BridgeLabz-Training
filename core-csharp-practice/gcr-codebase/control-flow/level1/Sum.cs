using System;
class Sum{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		if(Number < 0){
			Console.WriteLine("The number "+Number+" is not a natural number");
			return;
		}
		int Result = (Number * (Number + 1))/2;
		Console.WriteLine("The Sum of "+Number+" natural numbers is "+Result);
	}
}