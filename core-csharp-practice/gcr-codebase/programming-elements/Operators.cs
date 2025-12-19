using System;

class Operators{
	static void Main(){
		//arithemetic Operator
		Console.WriteLine("Arithmetic Operators"); 
		int Num1 = 1;
		int Num2 = 2;
		Console.WriteLine(Num1+Num2); //addition
		Console.WriteLine(Num1-Num2); //subtraction
		Console.WriteLine(Num1*Num2); //multiplication
		Console.WriteLine(Num1/Num2); //division
		Console.WriteLine(Num1%Num2); //modulus
		
		//Relational Opertors
		Console.WriteLine("Relational Operators"); 
		int Num3 = 3;
		int Num4 = 4;
		Console.WriteLine("Num3 == Num4 "+(Num3 == Num4)); //Equal To
		Console.WriteLine("Num3 != Num4 "+(Num3 != Num4)); //Not Equal To
		Console.WriteLine("Num3 > Num4 "+(Num3 > Num4)); //Greater than
		Console.WriteLine("Num3 < Num4 "+(Num3 < Num4)); //Less than
		Console.WriteLine("Num3 >= Num4 "+(Num3 >= Num4)); //Greater than or Equal To
		Console.WriteLine("Num3 <= Num4 "+(Num3 <= Num4)); //Less than or Equal To
		
		//Logical Operators
		Console.WriteLine("Logical Operators"); 
		bool Opr1 = true;
		bool Opr2 = true;
		Console.WriteLine("Opr1 && Opr2 "+(Opr1 && Opr2)); //Logical AND
		Console.WriteLine("Opr1 || Opr2 "+(Opr1 || Opr2)); //Logical OR
		Console.WriteLine("Opr1 && Opr2 "+(! Opr1)); //Logical NOT
		
		//Assignment Operators1
		Console.WriteLine("Assignment Operators"); 
		int Num5 = 1; //assignment
		int Num6 = 2;
		Console.WriteLine("Num5 = "+Num5);
		Console.WriteLine("Num6 = "+Num6);
		Num5 += 1; //Addition Assignment
		Console.WriteLine("Num5+=1 = "+Num5);
		Num5 -= 1; //Subtraction Assignment
		Console.WriteLine("Num5-=1 = "+Num5);
		Num5 *= 1; //Multiplaction Assignment
		Console.WriteLine("Num5*=1 = "+Num5);
		Num5 /= 1; //Division Assignment
		Console.WriteLine("Num5/=1 = "+Num5);
		Num5 %= 1; //Modulus Assignment
		Console.WriteLine("Num5%=1 = "+Num5);
		
		//Unary Operators
		Console.WriteLine("Unary Operators");
		int Num7 = 1;
		Console.WriteLine("+Num7 = "+Num7); //Unary Plus
		Console.WriteLine("Num7++ = "+ Num7++); //Increment
		Console.WriteLine("Num7-- "+ --Num7); //Decrement
		
		//Ternary Operators
		Console.WriteLine("Ternary Operators");
		int Num8 = 10;
		int Num9 = 11;
		int Max = (Num8 > Num9)? Num8 : Num9; //Ternary Operator
		Console.WriteLine("Max = "+Max); 
		
		//Is Operators
		Console.WriteLine("Is Operator");
		int Ais = 10;
		Console.WriteLine(Ais is int);
		
	}
}