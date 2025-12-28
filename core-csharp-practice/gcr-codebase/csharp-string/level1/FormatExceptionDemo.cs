using System;
class FormatExceptionDemo{
	static void ConvertToInt(string str){
		int num=int.Parse(str);
		Console.WriteLine(num);
	}
	static void Main(){
		Console.WriteLine("Enter String :-");
		string str=Console.ReadLine();
		try{
			ConvertToInt(str);
		}
		catch(FormatException e){
			Console.WriteLine("FormatException Occurred");
		}
	}
}
