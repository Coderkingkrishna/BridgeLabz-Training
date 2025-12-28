using System;
class FactorialRecursion{
	static int GetInput(){
		return int.Parse(Console.ReadLine());
	}
	static int Factorial(int n){
		if(n==0||n  ==1){
			return 1;
		}
		return n *Factorial(n-1);
	}
	static void ShowResult(int result){
		Console.WriteLine("Factorial is "+result);
	}
	static void Main(){
		Console.WriteLine("Enter a number:");
		int n=GetInput();
		int result=Factorial(n);
		ShowResult(result);
	}
}
