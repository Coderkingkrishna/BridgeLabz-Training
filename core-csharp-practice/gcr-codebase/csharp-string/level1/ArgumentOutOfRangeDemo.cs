using System;
class ArgumentOutOfRangeDemo{
	static void CreateSubstring(string str){
		Console.WriteLine(str.Substring(5,2));
	}
	static void Main(){
		Console.WriteLine("Enter String :-");
		string str=Console.ReadLine();
		try{
			CreateSubstring(str);
		}
		catch(ArgumentOutOfRangeException e){
			Console.WriteLine("ArgumentOutOfRangeException Occurred");
		}
	}
}
