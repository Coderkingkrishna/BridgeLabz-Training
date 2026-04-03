using System;
class PenDistribution{
	static void Main(){
		int Pens = 14;
		int Student = 3;
		int PenPerStudent = Pens / Student;
		int NonDistributedPen = Pens % Student;
		Console.WriteLine("The Pen Per Student is "+PenPerStudent+" and the remaining pen not distributed is "+NonDistributedPen);
	}
}