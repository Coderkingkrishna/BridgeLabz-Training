using System;
class Count{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Result =0;
		while(Number != 0){
			Result++;
			Number /= 10;
		}
		Console.WriteLine(Result);
	}
}