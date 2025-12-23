using System;
class TableSixToNine{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int[] Table = new int[4];
		
		for(int i =0;i<Table.Length;i++){
			Table[i] = Number * (i+6);
			Console.WriteLine(Number +" * "+(i+6)+" = "+Table[i]);
		}
	}
}