using System;
class NumberChecker3{
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
	static int[] ReverseDigits(int[] Digits){
		int[] Reversed=new int[Digits.Length];
		int Index=0;
		for(int i=Digits.Length-1;i>=0;i--){
			Reversed[Index]=Digits[i];
			Index++;
		}
		return Reversed;
	}
	static bool CompareArrays(int[] Array1,int[] Array2){
		if(Array1.Length!=Array2.Length){
			return false;
		}
		for(int i=0;i<Array1.Length;i++){
			if(Array1[i]!=Array2[i]){
				return false;
			}
		}
		return true;
	}

	static bool IsPalindrome(int[] Digits){
		int[] Reversed=ReverseDigits(Digits);
		return CompareArrays(Digits,Reversed);
	}

	static bool IsDuckNumber(int[] Digits){
		for(int i=0;i<Digits.Length;i++){
			if(Digits[i]!=0){
				return true;
			}
		}
		return false;
	}

	static void Main(){
		Console.WriteLine("Enter a Number:");
		int Number=int.Parse(Console.ReadLine());

		int DigitCount=CountDigits(Number);
		Console.WriteLine("Digit Count:"+DigitCount);

		int[] Digits=StoreDigits(Number);

		Console.WriteLine("Digits:");
		for(int i=0;i<Digits.Length;i++){
			Console.WriteLine(Digits[i]);
		}

		int[] Reversed=ReverseDigits(Digits);
		Console.WriteLine("Reversed Digits:");
		for(int i=0;i<Reversed.Length;i++){
			Console.WriteLine(Reversed[i]);
		}

		bool Palindrome=IsPalindrome(Digits);
		if(Palindrome){
			Console.WriteLine("Palindrome Number");
		}else{
			Console.WriteLine("Not a Palindrome Number");
		}

		bool Duck=IsDuckNumber(Digits);
		if(Duck){
			Console.WriteLine("Duck Number");
		}else{
			Console.WriteLine("Not a Duck Number");
		}
	}
}
