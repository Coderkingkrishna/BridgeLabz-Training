using System;
class NaturalNumberSumFor{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Total=0;
		int Result = (Number * (Number + 1))/2;
		for(int i = Number;i > 0;i--){
			Total += i;
		}
		Console.WriteLine("Sum through loop: "+Total);
		Console.WriteLine("Sum through formula: "+Total);
	}
}