using System;
class CountDown{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		while(Number > 0){
			Console.WriteLine(Number);
			Number--;
		}
	}
}