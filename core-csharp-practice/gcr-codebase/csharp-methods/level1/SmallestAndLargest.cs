using System;
class SmallestAndLargest{
	static int[] FindSmallestAndLargest(int Number1,int Number2,int Number3){
		int Smallest=Number1;
		int Largest=Number1;

		if(Number2<Smallest){
			Smallest=Number2;
		}
		if(Number3<Smallest){
			Smallest=Number3;
		}
		if(Number2>Largest){
			Largest=Number2;
		}
		if(Number3>Largest){
			Largest=Number3;
		}

		return new int[]{Smallest,Largest};
	}

	static void Main(){
		Console.WriteLine("Enter 3 Numbers:");
		int Number1=int.Parse(Console.ReadLine());
		int Number2=int.Parse(Console.ReadLine());
		int Number3=int.Parse(Console.ReadLine());

		int[] Result=FindSmallestAndLargest(Number1,Number2,Number3);
		Console.WriteLine("Smallest Number is:"+Result[0]);
		Console.WriteLine("Largest Number is:"+Result[1]);
	}
}
