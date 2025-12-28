using System;
class BasicCalculator{
	static int Add(int a,int b){
		return a+b;
	}
	static int Sub(int a,int b){
		return a-b;
	}
	static int Mul(int a,int b){
		return a*b;
	}
	static int Div(int a,int b){
		return a/b;
	}
	static void Main(){
		Console.WriteLine("Enter first number:");
		int a=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter second number:");
		int b=int.Parse(Console.ReadLine());
		Console.WriteLine("Choose operation + - * /");
		string op=Console.ReadLine();
		if(op=="+"){
			Console.WriteLine(Add(a,b));
		}
		else if(op=="-"){
			Console.WriteLine(Sub(a,b));
		}
		else if(op=="*"){
			Console.WriteLine(Mul(a,b));
		}
		else if(op=="/"){
			Console.WriteLine(Div(a,b));
		}
	}
}
