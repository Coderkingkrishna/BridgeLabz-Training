using System;
class KmToMilesUserKmToMilesUser{
	public static void Main(){
		double kilo = int.Parse(Console.ReadLine());
		double miles = kilo * 1.6;
		Console.WriteLine("The distance "+ kilo+" km in miles is "+ miles);
	}
}