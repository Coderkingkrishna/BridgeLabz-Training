using System;
class NumberChecker4{
	static int[] FindFactors(int Number){
		int Count=0;
		for(int i=1;i<=Number;i++){
			if(Number%i==0){
				Count++;
			}
		}
		int[] Factors=new int[Count];
		int Index=0;
		for(int i=1;i<=Number;i++){
			if(Number%i==0){
				Factors[Index]=i;
				Index++;
			}
		}
		return Factors;
	}

	static int FindGreatestFactor(int[] Factors){
		int Greatest=Factors[0];
		for(int i=1;i<Factors.Length;i++){
			if(Factors[i]>Greatest){
				Greatest=Factors[i];
			}
		}
		return Greatest;
	}

	static int FindSumOfFactors(int[] Factors){
		int Sum=0;
		for(int i=0;i<Factors.Length;i++){
			Sum+=Factors[i];
		}
		return Sum;
	}

	static long FindProductOfFactors(int[] Factors){
		long Product=1;
		for(int i=0;i<Factors.Length;i++){
			Product*=Factors[i];
		}
		return Product;
	}

	static double FindProductOfCubeOfFactors(int[] Factors){
		double Product=1;
		for(int i=0;i<Factors.Length;i++){
			Product*=Math.Pow(Factors[i],3);
		}
		return Product;
	}

	static bool IsPerfectNumber(int Number,int[] Factors){
		int Sum=0;
		for(int i=0;i<Factors.Length-1;i++){
			Sum+=Factors[i];
		}
		return Sum==Number;
	}

	static void Main(){
		Console.WriteLine("Enter Number:");
		int Number=int.Parse(Console.ReadLine());

		int[] Factors=FindFactors(Number);

		Console.WriteLine("Factors:");
		for(int i=0;i<Factors.Length;i++){
			Console.WriteLine(Factors[i]);
		}

		Console.WriteLine("Greatest Factor: "+FindGreatestFactor(Factors));
		Console.WriteLine("Sum of Factors: "+FindSumOfFactors(Factors));
		Console.WriteLine("Product of Factors: "+FindProductOfFactors(Factors));
		Console.WriteLine("Product of Cube of Factors: "+FindProductOfCubeOfFactors(Factors));

		if(IsPerfectNumber(Number,Factors)){
			Console.WriteLine("Perfect Number");
		}else{
			Console.WriteLine("Not a Perfect Number");
		}
	}
}
