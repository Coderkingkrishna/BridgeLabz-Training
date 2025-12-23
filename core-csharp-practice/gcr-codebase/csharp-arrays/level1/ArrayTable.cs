using System;
class ArrayTable{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int[] Table = new int[10];
		
		for(int i =0;i<Table.Length;i++){
			Table[i] = Number * (i+1);
			Console.WriteLine(Number +" * "+(i+1)+" = "+Table[i]);
		}
	}
}