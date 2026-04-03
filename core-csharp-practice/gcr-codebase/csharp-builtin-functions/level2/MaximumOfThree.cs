using System;
class MaximumOfThree{
	static int GetInput(){
		return int.Parse(Console.ReadLine());
	}
	static int FindMax(int a,int b,int c){
		int max=a;
		if(b>max){
			max=b;
		}
		if(c>max){
			max=c;
		}
		return max;
	}
	static void Main(){
		Console.WriteLine("Enter first number:");
		int a=GetInput();
		Console.WriteLine("Enter second number:");
		int b=GetInput();
		Console.WriteLine("Enter third number:");
		int c=GetInput();
		int result=FindMax(a,b,c);
		Console.WriteLine("Maximum number is "+result);
	}
}
