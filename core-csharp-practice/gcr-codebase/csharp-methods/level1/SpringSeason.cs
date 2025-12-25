using System;
class SpringSeason{
	static bool IsSpring(int Day, int Month){
		if((Month == 3 && Day >= 20) || Month == 4 || Month == 5 || (Month == 6 && Day <= 20)){
			return true;
		}
		return false;
	}
	static void Main(){
		int Day = int.Parse(Console.ReadLine());
		int Month = int.Parse(Console.ReadLine());
		bool Check = IsSpring(Day, Month);
		if(Check){
			Console.WriteLine("Its a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}