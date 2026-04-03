using System;
class Freq{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int[] Data = new int[10];
		for(int i= 0;Number!=0;i++){
			Data[Number%10]++;
			Number /= 10;
		}
		for(int i =0;i<Data.Length;i++){
			Console.WriteLine("In number "+i+" having frequency : "+Data[i]);
		}
	}
}