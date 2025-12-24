using System;
class MaxElements{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int Copy = Number, Count = 0;
		while(Number != 0){
			Count++;
			Number /= 10;
		}
		int[] Data = new int[Count];
		for(int i= 0;i<Data.Length;i++){
			Data[i] = Copy%10;
			Copy /= 10;
		}
		int Max = 0, SecMax = 0;
		for(int i =0;i<Data.Length;i++){
			if(Data[i] > Max){
				SecMax = Max;
				Max = Data[i];
			}
			else if(Data[i] < Max && Data[i] > SecMax){
				SecMax = Data[i];
			}
		}
		Console.WriteLine("Largest : "+Max);
		Console.WriteLine("Second Largest : "+SecMax);
		
	}
}