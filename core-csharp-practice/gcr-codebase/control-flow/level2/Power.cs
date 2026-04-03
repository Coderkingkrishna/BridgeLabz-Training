using System;
class Power{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Power = int.Parse(Console.ReadLine());
		int Result = 1;
		for(int i = Power;i>0;i--){
			Result *= Number;
		}
		Console.WriteLine("Power of "+Number+" is "+Result);
	}
}