using System;
class FizzBuzz{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		if(Number <0){
			return;
		}
		for(int i = 0;i<= Number;i++){
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
		}
	}
}