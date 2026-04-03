using System;
class Prime{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int count = 0;
		bool isPrime = true;
		for(int i = 2;i<Number/2;i++){
			if(Number % i == 0){
				count ++;
			}
			if(count == 2){
				isPrime = false;
			}
		}
		Console.WriteLine((isPrime)?"Prime":"Not Prime");
	}
}