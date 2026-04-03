using System;
class IntOperation{
	static void Main(){
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int Opr1 = a + b*c;
		int Opr2 = a*b+c;
		int Opr3 = c + a/b;
		int Opr4 = a%b +c;
		Console.WriteLine("The results of INT Operations are "+Opr1+", "+Opr2+", "+Opr3+" and "+Opr4);
	}
}