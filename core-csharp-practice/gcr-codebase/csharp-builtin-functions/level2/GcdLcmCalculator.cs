using System;
class GcdLcmCalculator{
	static int GetInput(){
		return int.Parse(Console.ReadLine());
	}
	static int FindGcd(int a,int b){
		while(b!=0){
			int temp=b;
			b=a%b;
			a=temp;
		}
		return a;
	}
	static int FindLcm(int a,int b){
		return (a*b)/FindGcd(a,b);
	}
	static void Main(){
		Console.WriteLine("Enter first number:");
		int a=GetInput();
		Console.WriteLine("Enter second number:");
		int b=GetInput();
		int gcd=FindGcd(a,b);
		int lcm=FindLcm(a,b);
		Console.WriteLine("GCD is "+gcd);
		Console.WriteLine("LCM is "+lcm);
	}
}
