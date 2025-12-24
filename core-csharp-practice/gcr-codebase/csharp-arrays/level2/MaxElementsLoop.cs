using System;
class MaxElementsLoop{
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
		int Max = 0, SecMax = 0, k=0;
		while(k<Data.Length){
			if(Data[k] > Max){
				SecMax = Max;
				Max = Data[k];
			}
			else if(Data[k] < Max && Data[k] > SecMax){
				SecMax = Data[k];
			}
			k++;
		}
		Console.WriteLine("Largest : "+Max);
		Console.WriteLine("Second Largest : "+SecMax);
		
	}
}