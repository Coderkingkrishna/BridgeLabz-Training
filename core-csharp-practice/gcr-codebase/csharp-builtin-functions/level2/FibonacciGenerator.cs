using System;
class FibonacciGenerator{
	static void PrintFibonacci(int n){
		int a=0,b=1,c;
		for(int i=1;i<=n;i++){
			Console.Write(a+" ");
			c=a+b;
			a=b;
			b=c;
		}
	}
	static void Main(){
		Console.WriteLine("Enter number of terms:");
		int n=int.Parse(Console.ReadLine());
		PrintFibonacci(n);
	}
}
