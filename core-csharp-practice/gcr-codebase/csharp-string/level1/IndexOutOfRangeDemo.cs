using System;
class IndexOutOfRangeDemo{
	static void AccessChar(string str){
		Console.WriteLine(str[10]);
	}
	static void Main(){
		string str=Console.ReadLine();
		try{
			AccessChar(str);
		}
		catch(IndexOutOfRangeException e){
			Console.WriteLine("IndexOutOfRangeException Occurred");
		}
	}
}
