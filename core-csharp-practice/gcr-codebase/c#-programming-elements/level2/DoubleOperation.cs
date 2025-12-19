using System;
class DoubleOperation{
	static void Main(){
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		double c = double.Parse(Console.ReadLine());
		double Opr1 = a + b*c;
		double Opr2 = a*b+c;
		double Opr3 = c + a/b;
		double Opr4 = a%b +c;
		Console.WriteLine("The results of Double Operations are "+Opr1+", "+Opr2+", "+Opr3+" and "+Opr4);
	}
}