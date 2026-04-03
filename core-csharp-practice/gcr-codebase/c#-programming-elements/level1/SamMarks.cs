using System;
class SamMarks{
	static void Main(){
		int SamMAth = 94;
		int SamPhy = 95;
		int SamChem = 96;
		int Percentage = ((SamChem + SamMAth + SamPhy) * 100) /300;
		Console.WriteLine("Sam’s average mark in PCM is "+Percentage);
	}
}