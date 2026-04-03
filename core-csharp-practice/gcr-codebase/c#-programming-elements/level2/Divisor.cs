using System;
class Divisor{
	static void Main(){
		double Opr1 = double.Parse(Console.ReadLine());
		double Opr2 = double.Parse(Console.ReadLine());
		double Div = Opr1 / Opr2;
		double Rem = Opr1 % Opr2;
		Console.WriteLine("The Quotient is "+Div+" and Remainder is "+ Rem+" of two numbers "+Opr1+" and "+Opr2);
	}
}