using System;
class AvgMarks{
	static void Main(){
		int Physics = int.Parse(Console.ReadLine());
		int Chem = int.Parse(Console.ReadLine());
		int Maths = int.Parse(Console.ReadLine());
		double Percentage = (Physics + Chem + Maths)/3;
		if(Percentage >= 80){
			Console.WriteLine("Avg Marks : "+ Percentage +" Remarks is A and above agency Normalized standards");
		}
		else if(Percentage >= 70 && Percentage<80){
			Console.WriteLine("Avg Marks : "+ Percentage +" Remarks is B and at agency Normalized standards");
		}
		else if(Percentage >= 60 && Percentage<70){
			Console.WriteLine("Avg Marks : "+ Percentage +" Remarks is C and below but approching agency Normalized standards");
		}
		else if(Percentage >= 50 && Percentage<60){
			Console.WriteLine("Avg Marks : "+ Percentage +" Remarks is D and well below agency Normalized standards");
		}
		else if(Percentage >= 40 && Percentage<50){
			Console.WriteLine("Avg Marks : "+ Percentage +" Remarks is E and too below agency Normalized standards");
		}
		else{
			Console.WriteLine("Avg Marks : "+ Percentage +" Remarks is R and Remedial standards");
		}
	}
}