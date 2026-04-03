using System;
class QuotientAndRemainder{
	static int[] FindQuotientAndRemainder(int Number1,int Number2){
		int Quotient=Number1/Number2;
		int Remainder=Number1%Number2;
		return new int[]{Quotient,Remainder};
	}

	static void Main(){
		Console.WriteLine("Enter 2 Numbers:");
		int Number1=int.Parse(Console.ReadLine());
		int Number2=int.Parse(Console.ReadLine());

		int[] Result=FindQuotientAndRemainder(Number1,Number2);
		Console.WriteLine("Quotient is:"+Result[0]);
		Console.WriteLine("Remainder is:"+Result[1]);
	}
}
