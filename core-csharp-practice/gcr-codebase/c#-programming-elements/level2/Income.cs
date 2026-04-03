using System;
class Income{
	static void Main(){
		int Salary = int.Parse(Console.ReadLine());
		int Bonus = int.Parse(Console.ReadLine());
		int Total = Salary + Bonus;
		Console.WriteLine("The salary is INR "+Salary+"and bonus is INR "+Bonus+" . Hence Total Income is INR "+Total);
	}
}