using System;
class Spring{
	static void Main(){
		int Day = int.Parse(Console.ReadLine());
		int Month = int.Parse(Console.ReadLine());
		if((Month == 3 && Day >= 20) || Month == 4 || Month == 5 || (Month == 6 && Day <= 20)){
			Console.WriteLine("Its a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}