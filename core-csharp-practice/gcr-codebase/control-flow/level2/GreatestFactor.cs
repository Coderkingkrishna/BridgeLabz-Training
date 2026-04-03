using System;
class GreatestFactor{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Result = 0;
		for(int i = Number-1;i>0;i--){
			if(Number % i == 0){
				Result = i;
				break;
			}
		}
		Console.WriteLine("Greatest Factor of "+Number+" is "+Result);
	}
}