using System;
class ChocolateDistribution{
	static int[] FindChocolates(int NumberOfChocolates,int NumberOfChildren){
		int EachChildGets=NumberOfChocolates/NumberOfChildren;
		int RemainingChocolates=NumberOfChocolates%NumberOfChildren;
		return new int[]{EachChildGets,RemainingChocolates};
	}

	static void Main(){
		Console.WriteLine("Enter Number Of Chocolates:");
		int NumberOfChocolates=int.Parse(Console.ReadLine());

		Console.WriteLine("Enter Number Of Children:");
		int NumberOfChildren=int.Parse(Console.ReadLine());

		int[] Result=FindChocolates(NumberOfChocolates,NumberOfChildren);
		Console.WriteLine("Each Child Gets:"+Result[0]);
		Console.WriteLine("Remaining Chocolates:"+Result[1]);
	}
}
