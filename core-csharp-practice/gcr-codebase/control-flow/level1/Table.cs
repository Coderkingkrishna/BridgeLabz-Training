using System;
class Table{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		for(int i = 1;i <= 10;i++){
			int Result = i * Number;
			Console.WriteLine(Number  +" * "+ i +" = "+Result);
		}
	}
}