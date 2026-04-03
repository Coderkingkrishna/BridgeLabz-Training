using System;
class CheckNumber{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		if(Number > 0){
			Console.WriteLine("The Number is Positive");
		}
		else if(Number < 0){
			Console.WriteLine("The Number is Negative");
		}
		else{
			Console.WriteLine("The Number is Zero");
		}
	}
}