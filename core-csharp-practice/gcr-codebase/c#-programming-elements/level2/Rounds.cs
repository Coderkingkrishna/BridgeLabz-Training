using System;
class Rounds{
	static void Main(){
		int Side1 = int.Parse(Console.ReadLine());
		int Side2 = int.Parse(Console.ReadLine());
		int Side3 = int.Parse(Console.ReadLine());
		int total = Side1+ Side2 + Side3;
		double round = total*5 /1000;
		Console.WriteLine("The total number of rounds the athlete will run is "+round+" to complete 5 km");
	}
}