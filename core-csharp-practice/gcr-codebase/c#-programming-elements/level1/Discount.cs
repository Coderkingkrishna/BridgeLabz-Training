using System;
class Discount{
	static void Main(){
		int Fee = 125000;
		int DiscountPer = 10;
		int DiscountAmt = Fee - (Fee*DiscountPer)/100;
		int DiscountPrice = Fee - DiscountAmt;
		Console.WriteLine("The discount amount is INR "+DiscountAmt+" and final discounted fee is INR "+DiscountPrice);
	}
}