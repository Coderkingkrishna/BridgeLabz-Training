using System;
class TotalPrice{
	static void Main(){
		int Quantity = int.Parse(Console.ReadLine());
		int Price = int.Parse(Console.ReadLine());
		int Total = Quantity * Price;
		Console.WriteLine("The total purchase price is INR "+Total+" if the quantity "+Quantity+" and unit price is INR "+Price);
	}
}