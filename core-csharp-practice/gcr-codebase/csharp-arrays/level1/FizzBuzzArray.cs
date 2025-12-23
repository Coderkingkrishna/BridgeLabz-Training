using System;
class FizzBuzzArray{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		String[] Fizz = new String[Number+1];
		if(Number <0){
			return;
		}
		for(int i = 0;i< Number;i++){
			if(i%3 == 0 && i%5 == 0){
				Fizz[i] = i + " Position is "+ "FizzBuzz";
			}
			else if(i%3 == 0){
				Fizz[i] = i + " Position is "+ "Fizz";
			}
			else if(i%5 == 0){
				Fizz[i] = i + " Position is "+ "Buzz";
			}
			else{
				Fizz[i] = ""+i;
			}
		}
		for(int i =0;i<Number;i++){
			Console.WriteLine(Fizz[i]);
		}
	}
}