using System;
class Bonus{
	static void Main(){
		int Salary = int.Parse(Console.ReadLine());
		int Year = int.Parse(Console.ReadLine());
		double Bonus = 0;
		if(Year > 5) {
			Bonus = Salary * 0.05;
		}
		Console.WriteLine(Bonus);
	}
}