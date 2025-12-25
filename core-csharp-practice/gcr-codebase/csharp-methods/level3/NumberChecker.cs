using System;
class NumberChecker{
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
	static bool IsDuckNumber(int[] Digits){
		for(int i=0;i<Digits.Length;i++){
			if(Digits[i]!=0){
				return true;
			}
		}
		return false;
	}
	static bool IsArmstrongNumber(int Number,int[] Digits){
		int Power=Digits.Length;
		int Sum=0;

		for(int i=0;i<Digits.Length;i++){
			Sum+=(int)Math.Pow(Digits[i],Power);
		}

		if(Sum==Number){
			return true;
		}
		return false;
	}

	static int[] FindLargestAndSecondLargest(int[] Digits){
		int Largest=Int32.MinValue;
		int SecondLargest=Int32.MinValue;

		for(int i=0;i<Digits.Length;i++){
			if(Digits[i]>Largest){
				SecondLargest=Largest;
				Largest=Digits[i];
			}else if(Digits[i]>SecondLargest&&Digits[i]!=Largest){
				SecondLargest=Digits[i];
			}
		}
		return new int[]{Largest,SecondLargest};
	}

	static int[] FindSmallestAndSecondSmallest(int[] Digits){
		int Smallest=Int32.MaxValue;
		int SecondSmallest=Int32.MaxValue;

		for(int i=0;i<Digits.Length;i++){
			if(Digits[i]<Smallest){
				SecondSmallest=Smallest;
				Smallest=Digits[i];
			}else if(Digits[i]<SecondSmallest&&Digits[i]!=Smallest){
				SecondSmallest=Digits[i];
			}
		}
		return new int[]{Smallest,SecondSmallest};
	}
	static void Main(){
		Console.WriteLine("Enter a Number:");
		int Number=int.Parse(Console.ReadLine());

		int DigitCount=CountDigits(Number);
		Console.WriteLine("Digit Count:"+DigitCount);
		int[] Digits=StoreDigits(Number);

		Console.WriteLine("Digits are:");
		for(int i=0;i<Digits.Length;i++){
			Console.WriteLine(Digits[i]);
		}
		bool Duck=IsDuckNumber(Digits);
		if(Duck){
			Console.WriteLine("Duck Number");
		}
		else{
			Console.WriteLine("Not a Duck Number");
		}

		bool Armstrong=IsArmstrongNumber(Number,Digits);
		if(Armstrong){
			Console.WriteLine("Armstrong Number");
		}
		else{
			Console.WriteLine("Not an Armstrong Number");
		}
		int[] Large=FindLargestAndSecondLargest(Digits);
		Console.WriteLine("Largest Digit:"+Large[0]);
		Console.WriteLine("Second Largest Digit:"+Large[1]);
		int[] Small=FindSmallestAndSecondSmallest(Digits);
		Console.WriteLine("Smallest Digit:"+Small[0]);
		Console.WriteLine("Second Smallest Digit:"+Small[1]);
	}
}
