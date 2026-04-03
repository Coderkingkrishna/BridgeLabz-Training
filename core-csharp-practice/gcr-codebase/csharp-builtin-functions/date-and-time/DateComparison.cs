using System;
class DateComparison{
	static void CompareDates(DateTime d1,DateTime d2){
		int result=DateTime.Compare(d1,d2);
		if(result<0){
			Console.WriteLine("First date is before second date");
		}
		else if(result>0){
			Console.WriteLine("First date is after second date");
		}
		else{
			Console.WriteLine("Both dates are same");
		}
	}
	static void Main(){
		Console.WriteLine("Enter date in format yyyy-MM-dd");
		DateTime d1=DateTime.Parse(Console.ReadLine());
		Console.WriteLine("Enter second date in format yyyy-MM-dd");
		DateTime d2=DateTime.Parse(Console.ReadLine());
		CompareDates(d1,d2);
	}
}
