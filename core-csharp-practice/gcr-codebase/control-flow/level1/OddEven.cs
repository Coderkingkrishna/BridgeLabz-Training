using System;
class OddEven{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		for(int i = 1;i <=Number;i++){
			if(i % 2 == 0) {
				Console.WriteLine(i +" is even");
			}
			else{
				Console.WriteLine(i +" is odd");
			}
		}
	}
}