using System;
class SumUntilZeroBreak{
	static void Main(){
		double Number = double.Parse(Console.ReadLine());
		double Total = double.Parse(Console.ReadLine());
		while(true){
			if(Number != 0){
				Total  += Number;
				Number = double.Parse(Console.ReadLine());
			}
			else{
				break;
			}
		}
		Console.WriteLine(Total);
	}
}