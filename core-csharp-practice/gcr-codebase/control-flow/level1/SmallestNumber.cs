using System;
class SmallestNumber{
	static void Main(){
		int Number1 = int.Parse(Console.ReadLine());
		int Number2 = int.Parse(Console.ReadLine());
		int Number3 = int.Parse(Console.ReadLine());
		if(Number1 < Number2 && Number1 < Number3){
			Console.WriteLine("Is the first number the smallest? YES");
		}
		else{
			Console.WriteLine("Is the first number the smallest? NO");
		}		
	}
}