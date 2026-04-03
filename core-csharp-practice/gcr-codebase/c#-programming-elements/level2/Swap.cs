using System;
class Swap{
	static void Main(){
		int Num1 = int.Parse(Console.ReadLine());
		int Num2 = int.Parse(Console.ReadLine());
		int Temp = Num1;
		Num1 = Num2;
		Num2 = Temp;
		Console.WriteLine("The swapped numbers are "+Num1+" and "+Num2);
	}
}