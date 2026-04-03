using System;
class NaturalNumberSum{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Total=0;
		int Result = (Number * (Number + 1))/2;
		while(Number != 0){
			Total  += Number;
			Number--;
		}
		Console.WriteLine("Sum through loop: "+Total);
		Console.WriteLine("Sum through formula: "+Total);
	}
}