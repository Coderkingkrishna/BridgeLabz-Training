using System;
class SumUntilZero{
	static void Main(){
		double Number = double.Parse(Console.ReadLine());
		double Total = double.Parse(Console.ReadLine());
		while(Number != 0){
			Total  += Number;
			Number = double.Parse(Console.ReadLine());
		}
		Console.WriteLine(Total);
	}
}