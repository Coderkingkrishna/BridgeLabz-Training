using System;
class RandomNumberAnalysis{
	static int[] Generate(int Size){
		int[] Numbers=new int[Size];
		Random Random=new Random();

		for(int i=0;i<Size;i++){
			Numbers[i]=Random.Next(1000,10000);
		}
		return Numbers;
	}

	static double[] FindAverageMinMax(int[] Numbers){
		int Min=Numbers[0];
		int Max=Numbers[0];
		int Sum=0;

		for(int i=0;i<Numbers.Length;i++){
			Sum+=Numbers[i];
			Min=Math.Min(Min,Numbers[i]);
			Max=Math.Max(Max,Numbers[i]);
		}

		double Average=(double)Sum/Numbers.Length;
		return new double[]{Average,Min,Max};
	}

	static void Main(){
		int[] Numbers=Generate(5);

		Console.WriteLine("Generated 4 Digit Numbers:");
		for(int i=0;i<Numbers.Length;i++){
			Console.WriteLine(Numbers[i]);
		}

		double[] Result=FindAverageMinMax(Numbers);
		Console.WriteLine("Average:"+Result[0]);
		Console.WriteLine("Minimum:"+Result[1]);
		Console.WriteLine("Maximum:"+Result[2]);
	}
}
