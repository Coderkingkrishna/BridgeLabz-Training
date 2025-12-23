using System;
class FactorOfNumber{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		for(int i = 1;i<Number;i++){
			if(Number % i == 0){
				Console.WriteLine("factor of "+Number+" is "+i);
			}
		}
	}
}