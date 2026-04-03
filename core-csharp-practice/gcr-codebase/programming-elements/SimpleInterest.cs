using System;
class SimpleInterest{
	public static void Main(){
		int principle = 1000;
		int rate = 2;
		int time = 3;
		double amount = (principle * rate * time)/100;
		Console.WriteLine(amount);
	}
}