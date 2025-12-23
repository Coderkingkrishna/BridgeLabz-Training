using System;
class HarshadNumber{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Result =0;
		int Dup = Number;
		while(Number != 0){
			Result += (Number %10);
			Number /= 10;
		}
		if(Dup % Result == 0) {
			Console.WriteLine("Harshad Number");
		}
		else{
			Console.WriteLine("Not a Harshad Number");
		}
	}
}