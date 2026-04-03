using System;
class ForCountDown{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		for(int i = Number;i>0;i--){
			Console.WriteLine(i);
		}
	}
}