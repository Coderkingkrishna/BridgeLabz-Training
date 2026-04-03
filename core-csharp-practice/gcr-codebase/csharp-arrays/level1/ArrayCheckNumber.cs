using System;
class ArrayCheckNumber{
	static void Main(){
		int[] Number = new int[5];
		for(int i =0;i<Number.Length;i++){
			Number[i] = int.Parse(Console.ReadLine());
			if(Number[i]<0){
				Console.WriteLine("Negative Number");
			}
			else if(Number[i]>0){
				if(Number[i]%2 ==0){
					Console.WriteLine("The Number "+Number[i]+" is positive and even");
				}
				else{
					Console.WriteLine("The Number "+Number[i]+" is positive and odd");
				}
			}
			else{
				Console.WriteLine("Zero");
			}
		}
		if(Number[0] == Number[Number.Length-1]){
			Console.WriteLine("Equal");
		}
		else if(Number[0] > Number[Number.Length-1]){
			Console.WriteLine("first is greater than last");
		}
		else{
			Console.WriteLine("Last is greater than first");
		}
		
	}
}