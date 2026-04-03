using System;
class LeapYearCheck{
	static bool IsLeapYear(int Year){
		if(Year<1582){
			return false;
		}
		if((Year%4==0&&Year%100!=0)||Year%400==0){
			return true;
		}
		return false;
	}
	static void Main(){
		Console.WriteLine("Enter Year:");
		int Year=int.Parse(Console.ReadLine());
		bool Result=IsLeapYear(Year);
		if(Result){
			Console.WriteLine("Year is a Leap Year");
		}
		else{
			Console.WriteLine("Year is Not a Leap Year");
		}
	}
}
