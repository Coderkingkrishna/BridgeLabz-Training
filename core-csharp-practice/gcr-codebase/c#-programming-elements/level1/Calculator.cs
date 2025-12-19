using System;
class Calculator{
	static void Main(){
		double Opr1 = double.Parse(Console.ReadLine());
		double Opr2 = double.Parse(Console.ReadLine());
		double Add = Opr1 + Opr2;
		double Sub = Opr1 - Opr2;
		double Mul = Opr1 * Opr2;
		double Div = Opr1 / Opr2;
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+Opr1+" and "+Opr2+" is ,"+Add+","+Sub+","+Mul+" and "+Div);
	}
}