using System;
class StudentScoreCard{
	static double[,] GeneratePcmScores(int Count){
		double[,] Scores=new double[Count,3];
		Random Random=new Random();
		for(int i=0;i<Count;i++){
			Scores[i,0] =Random.Next(10,100);
			Scores[i,1]= Random.Next(10, 100);
			Scores[i,2]= Random.Next(10,100);
		}
		return Scores;
	}
	static double[,] CalculateResults(double[,] Scores){
		int Count=Scores.GetLength(0);
		double[,] Result=new double[Count,3];
		for(int i=0;i<Count;i++){
			double Total=Scores[i,0] + Scores[i,1]+ Scores[i,2];
			double Average=Math.Round(Total/3,2);
			double Percentage=Math.Round((Total/300) * 100, 2);
			Result[i,0] =Total;
			Result[i,1] =Average;
			Result[i,2] =Percentage;
		}
		return Result;
	}

	static void DisplayScoreCard (double[,] Scores,double[,] Result){
		int Count=Scores.GetLength(0);
		Console.WriteLine("Physics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
		for(int i=0;i<Count;i++){
			Console.WriteLine(Scores[i,0]+"\t"+Scores[i,1]+"\t\t"+Scores[i,2]+"\t"+Result[i,0]+"\t"+Result[i,1]+"\t"+Result[i,2]);
		}
	}
	static void Main(){
		Console.WriteLine("Enter Number of Students: ");
		int Count=int.Parse(Console.ReadLine());

		double[,] Scores=GeneratePcmScores(Count);
		double[,] Result=CalculateResults(Scores);
		DisplayScoreCard(Scores,Result);
	}
}
