using System;
class AvgOfHeight{
	static void Main(){
		double[] Height = new double[11];
		double Mean = 0, Sum = 0;
		for(int i =0;i<Height.Length;i++){
			Height[i] = double.Parse(Console.ReadLine());
			Sum += Height[i];
		}
		Mean = Sum/11;
		Console.WriteLine("Mean of Height: "+Mean);
	}
}