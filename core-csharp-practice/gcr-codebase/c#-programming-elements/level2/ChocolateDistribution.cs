using System;
class ChocolateDistribution{
	static void Main(){
		int Chocolate = int.Parse(Console.ReadLine());
		int Children = int.Parse(Console.ReadLine());
		int ChocalatePerStudent = Chocolate / Children;
		int NonDistributedChocolate = Chocolate % Children;
		Console.WriteLine("The number of chocolates each child gets is "+ChocalatePerStudent+" and the number of remaining chocolate is "+NonDistributedChocolate);
	}
}