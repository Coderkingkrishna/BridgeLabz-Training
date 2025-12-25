using System;
class FootballTeamHeight{
	static int[] GenerateHeights(){
		int[] Heights=new int[11];
		Random Random=new Random();
		for(int i=0;i<Heights.Length;i++){
			Heights[i]=Random.Next(150,251);
		}
		return Heights;
	}
	static int FindSum(int[] Heights){
		int Sum= 0;
		for(int  i=0;i<Heights.Length ;i++){
			Sum+=Heights[i];
		}
		return Sum;
	}
	static double FindMean(int[] Heights){
		int Sum=FindSum(Heights);
		double Mean=(double)Sum/ Heights.Length;
		return Mean;
	}

	static int FindShortest(int[] Heights){
		int Shortest=Heights[0];
		for(int i=1;i<Heights.Length;i++){
			if(Heights[i] <Shortest){
				Shortest = Heights[i];
			}
		}
		return Shortest;
	}

	static int FindTallest(int[] Heights){
		int Tallest= Heights[0];
		for(int i=1; i<Heights.Length;i++){
			if(Heights[i]> Tallest){
				Tallest=Heights[i];
			}
		}
		return Tallest;
	}

	static void Main(){
		int[] Heights=GenerateHeights();
		Console.WriteLine("Player Heights:");
		for(int i=0;i<Heights.Length;i++){
			Console.WriteLine(Heights[i]);
		}
		int Sum=FindSum(Heights);
		double Mean=FindMean(Heights);
		int Shortest=FindShortest(Heights);
		int Tallest=FindTallest(Heights);
		Console.WriteLine("Sum of Heights: "+Sum);
		Console.WriteLine("Mean Height: "+Mean);
		Console.WriteLine("Shortest Height: "+Shortest);
		Console.WriteLine("Tallest Height: "+Tallest);
	}
}
