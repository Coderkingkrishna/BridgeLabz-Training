using System;
class DivisibleByFive{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		String Result = "";
		if(Number %  5 == 0){
			Result = "Yes";
		}
		else{
			Result = "No";
		}
		Console.WriteLine("Is the number "+Number+" divisible by 5 ? "+Result);
	}
}