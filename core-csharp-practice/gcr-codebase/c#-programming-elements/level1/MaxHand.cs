using System;
class MaxHand{
	static void Main(){
		int NoOfStudent = int.Parse(Console.ReadLine());
		int Max = (NoOfStudent * (NoOfStudent -1))/2;
		Console.WriteLine("The total number of the handshake possible is "+Max);
	}
}