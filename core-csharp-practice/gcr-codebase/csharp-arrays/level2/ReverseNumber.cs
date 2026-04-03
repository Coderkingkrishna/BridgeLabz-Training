using System;
class ReverseNumber{
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
		int t = 0, j = 0;
		while(t<j){
			int Temp = Data[t];
			Data[t] = Data[j];
			Data[j] = Temp;
		}
		for(int k =0;k<Count;k++){
			Console.WriteLine(Data[k]);
		}
		
	}
}