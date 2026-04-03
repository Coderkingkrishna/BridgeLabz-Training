using System;
class DateArithmetic{
	static DateTime CalculateDate(DateTime date){
		date=date.AddDays(7);
		date=date.AddMonths(1);
		date=date.AddYears(2);
		date=date.AddDays(-21);
		return date;
	}
	static void Main(){
		DateTime date=DateTime.Parse(Console.ReadLine());
		DateTime result=CalculateDate(date);
		Console.WriteLine(result);
	}
}
