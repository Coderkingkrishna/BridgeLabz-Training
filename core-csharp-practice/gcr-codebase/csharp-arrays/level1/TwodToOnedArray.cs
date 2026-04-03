using System;
class TwodToOnedArray{
	static void Main(){
		int Row = int.Parse(Console.ReadLine());
		int Col = int.Parse(Console.ReadLine());
		int[ , ] Twod = new int[Row, Col];
		for(int i = 0;i<Row;i++){
			for(int j = 0;j<Col;j++){
				Twod[i ,j] = int.Parse(Console.ReadLine());
			}
		}
		int[] Oned = new int[Row*Col];
		int Size = 0;
		for(int i = 0;i<Row;i++){
			for(int j = 0;j<Col;j++){
				Oned[Size++] = Twod[i ,j] = int.Parse(Console.ReadLine());
			}
		}
	}
}