using System;
class NumberAnalysis{
	static bool IsPositive(int Number){
		if(Number  >=0){
			return true;
		}
		return false;
	}

	static bool IsEven(int Number){
		if(Number%2 ==0){
			return true;
		}
		return false;
	}

	static int Compare(int Number1,int Number2){
		if(Number1> Number2){
			return 1;
		}
		if(Number1== Number2){
			return 0;
		}
		return -1;
	}

	static void Main(){
		int[] Numbers= new int[5];

		for(int i=0;i<Numbers.Length;i++){
			Console.WriteLine("Enter Number "+(i+1)+":");
			Numbers[i]=int.Parse(Console.ReadLine());

			if(IsPositive(Numbers[i])){
				if(IsEven(Numbers[i])){
					Console.WriteLine("Positive Even Number");
				}
				else{
					Console.WriteLine("Positive Odd Number");
				}
			}
			else{
				Console.WriteLine("Negative Number");
			}
		}

		int Result=Compare(Numbers[0],Numbers[Numbers.Length-1]);

		if(Result==  1){
			Console.WriteLine("First Element is Greater than Last Element");
		}
		else if(Result == 0){
			Console.WriteLine("First Element is Equal to Last Element");
		}
		else{
			Console.WriteLine("First Element is Less than Last Element");
		}
	}
}
