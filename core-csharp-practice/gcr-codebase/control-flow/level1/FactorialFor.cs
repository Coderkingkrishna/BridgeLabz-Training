using System;
class FactorialFor{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Total=1;
		for(int i = Number;i > 0;i--){
			Total *= i;
		}
		Console.WriteLine("factorial: "+Total);
	}
}