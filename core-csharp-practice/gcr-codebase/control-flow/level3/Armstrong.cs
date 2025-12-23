using System;
class Armstrong{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Result =0;
		int Dup = Number;
		while(Number != 0){
			int Rem = Number %10;
			Result += (int) Math.Pow(Rem, 3);
			Number /= 10;
		}
		if(Result == Dup) {
			Console.WriteLine("Armstrong Number");
		}
		else{
			Console.WriteLine("Not a Armstrong Number");
		}
	}
}