using System;
class LeapYear{
	static void Main(){
		int Year = int.Parse(Console.ReadLine());
		if(Year < 1582){
			Console.WriteLine("Not Leap Year");
		}
		else if(Year%4 == 0 && (Year %100 != 0 || Year % 400 == 0)){
			Console.WriteLine("Leap Year");
		}
		else{
			Console.WriteLine("Not Leap Year");
		}
	}
}