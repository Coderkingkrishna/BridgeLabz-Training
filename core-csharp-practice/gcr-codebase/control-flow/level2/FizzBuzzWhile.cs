using System;
class FizzBuzzWhile{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		if(Number <0){
			return;
		}
		int i = 0;
		while(i<=Number){
			if(i%3 == 0 && i%5 == 0){
				Console.WriteLine("FizzBuzz");
			}
			else if(i%3 == 0){
				Console.WriteLine("Fizz");
			}
			else if(i%5 == 0){
				Console.WriteLine("Buzz");
			}
			else{
				Console.WriteLine(i);
			}
			i++;
		}
	}
}