using System;
class NumberDivideI{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		for(int i = 100;i>0;i--){
			if(i % Number == 0){
				Console.WriteLine(i);
			}
		}
	}
}