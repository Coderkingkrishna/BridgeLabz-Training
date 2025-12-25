using System;
class CombOfHandshake{
	static int CalculateHand(int Number){
		int Combination = (Number * (Number-1) )/2;
		return Combination;
	}
	static void Main(){
		Console.WriteLine("Enter Number : ");
		int NumberOfStudent = int.Parse(Console.ReadLine());
		int Total = CalculateHand(NumberOfStudent);
		Console.WriteLine("Possible handShake : "+Total);
	}
}