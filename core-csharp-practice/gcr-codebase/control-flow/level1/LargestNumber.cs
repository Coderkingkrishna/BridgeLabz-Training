using System;
class LargestNumber{
	static void Main(){
		int Number1 = int.Parse(Console.ReadLine());
		int Number2 = int.Parse(Console.ReadLine());
		int Number3 = int.Parse(Console.ReadLine());
		if(Number1 > Number2 && Number1 > Number3){
			Console.WriteLine("first number the largest");
		}
		else if(Number2 > Number1 && Number2 > Number3){
			Console.WriteLine("Second number the largest");
		}
		else{
			Console.WriteLine("Third number the largest");
		}
	}
}