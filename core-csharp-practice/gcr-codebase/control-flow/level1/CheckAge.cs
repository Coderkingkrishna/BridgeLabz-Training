using System;
class CheckAge{
	static void Main(){
		int Age = int.Parse(Console.ReadLine());
		if(Age >= 18){
			Console.WriteLine("The person's age is "+Age+" and can vote.");
		}
		else{
			Console.WriteLine("The person's age is "+Age+" and cannot vote.");
		}
	}
}