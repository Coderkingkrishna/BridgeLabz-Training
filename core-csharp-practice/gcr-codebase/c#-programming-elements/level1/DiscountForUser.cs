using System;
class DiscountForUser{
	static void Main(){
		int Fee = int.Parse(Console.ReadLine());
		int DiscountPer = int.Parse(Console.ReadLine());
		int DiscountAmt = Fee - (Fee*DiscountPer)/100;
		int DiscountPrice = Fee - DiscountAmt;
		Console.WriteLine("The discount amount is INR "+DiscountAmt+" and final discounted fee is INR "+DiscountPrice);
	}
}