using System;
class Factorial{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Total=1;
		while(Number != 0){
			Total  *= Number;
			Number--;
		}
		Console.WriteLine("factorial: "+Total);
	}
}