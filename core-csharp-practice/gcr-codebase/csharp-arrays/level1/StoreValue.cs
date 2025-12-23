using System;
class StoreValue{
	static void Main(){
		double[] Array = new double[10];
		int count = 0;
		double Sum = 0;
		while(true){
			double Value = double.Parse(Console.ReadLine());
			if(count == 10 || Value == 0){
				break;
			}
			Array[count++] = Value;
			Sum += Value;
		}
		Console.WriteLine(Sum);
	}
}