using System;
class NumberChecker2{
	static int CountDigits(int Number){
		int Count=0;
		int Temp=Number;
		while(Temp!=0){
			Count++;
			Temp/=10;
		}
		return Count;
	}

	static int[] StoreDigits(int Number){
		int Count=CountDigits(Number);
		int[] Digits=new int[Count];
		int Index=Count-1;
		int Temp=Number;

		while(Temp!=0){
			Digits[Index]=Temp%10;
			Temp/=10;
			Index--;
		}
		return Digits;
	}

	static int FindSumOfDigits(int[] Digits){
		int Sum=0;
		for(int i=0;i<Digits.Length;i++){
			Sum+=Digits[i];
		}
		return Sum;
	}

	static double FindSumOfSquares(int[] Digits){
		double Sum=0;
		for(int i=0;i<Digits.Length;i++){
			Sum+=Math.Pow(Digits[i], 2);
		}
		return Sum;
	}

	static bool IsHarshadNumber(int Number,int[] Digits){
		int Sum=FindSumOfDigits(Digits);
		if(Sum==0){
			return false;
		}
		if(Number%Sum==0){
			return true;
		}
		return false;
	}

	static int[,] FindDigitFrequency(int[] Digits){
		int[,] Frequency=new int[10,2];

		for(int i=0;i<10;i++){
			Frequency[i, 0]=i;
			Frequency[ i,1]=0;
		}

		for(int i=0;i<Digits.Length;i++){
			Frequency[Digits[i],1]++;
		}
		return Frequency;
	}

	static void Main(){
		Console.WriteLine("Enter  a Number:");
		int Number=int.Parse(Console.ReadLine());
		int DigitCount=CountDigits(Number);
		Console.WriteLine("Digit Count:"+DigitCount);

		int[] Digits=StoreDigits(Number);

		Console.WriteLine("Digits are:");
		for(int i=0;i<Digits.Length;i++){
			Console.WriteLine(Digits[i]);
		}

		int SumOfDigits=FindSumOfDigits(Digits);
		Console.WriteLine("Sum of Digits:"+SumOfDigits);

		double SumOfSquares=FindSumOfSquares(Digits);
		Console.WriteLine("Sum of Squares of Digits:"+SumOfSquares);

		bool Harshad=IsHarshadNumber(Number,Digits);
		if(Harshad){
			Console.WriteLine("Harshad Number");
		}else{
			Console.WriteLine("Not a Harshad Number");
		}

		int[,] Frequency=FindDigitFrequency(Digits);
		Console.WriteLine("Digit Frequency:");
		for(int i=0;i<10;i++){
			if(Frequency[i,1]>0){
				Console.WriteLine("Digit "+Frequency[i,0]+" Frequency "+Frequency[i,1]);
			}
		}
	}
}
