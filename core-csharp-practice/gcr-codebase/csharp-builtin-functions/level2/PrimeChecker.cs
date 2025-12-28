using System;
class PrimeChecker{
	static bool IsPrime(int num){
		if(num<=1){
			return false;
		}
		for(int i=2;i<=num/2;i++){
			if(num%i==0){
				return false;
			}
		}
		return true;
	}
	static void Main(){
		Console.WriteLine("Enter a number:");
		int num=int.Parse(Console.ReadLine());
		bool result=IsPrime(num);
		if(result){
			Console.WriteLine("Number is Prime");
		}
		else{
			Console.WriteLine("Number is Not Prime");
		}
	}
}
