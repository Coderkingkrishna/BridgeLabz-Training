using System;
class NumberOfHandshake{
	static int CalculateHand(int Number){
		int Possible = (Number * (Number-1) )/2;
		return Possible;
	}
	static void Main(){
		Console.WriteLine("Enter Number : ");
		int Number = int.Parse(Console.ReadLine());
		int Total = CalculateHand(Number);
		Console.WriteLine("Possible handShake : "+Total);
	}
}