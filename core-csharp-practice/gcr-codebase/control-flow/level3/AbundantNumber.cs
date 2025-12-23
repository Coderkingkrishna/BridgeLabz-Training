using System;
class AbundantNumber{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int FactorSum = 0;
		for(int i = 1;i<Number;i++){
			if(Number % i == 0){
				FactorSum += i;
			}
		}
		if(FactorSum > Number){
			Console.WriteLine("Abundant Number");
		}
		else{
			Console.WriteLine("Not a Abundant Number");
		}
	}
}