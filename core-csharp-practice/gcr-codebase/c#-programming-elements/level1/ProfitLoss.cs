using System;
class ProfitLoss{
	static void Main(){
		int CostPrice = 129;
		int SellPrice = 191;
		int Profit = SellPrice - CostPrice;
		double ProfitPercentage = (Profit*100)/SellPrice;
		Console.WriteLine("The Cost Price is INR " + CostPrice+" and Selling Price is INR "+SellPrice);
		Console.WriteLine("The Profit is INR"+Profit+" and the Profit Percentage is"+ProfitPercentage);
	}
}