using System;
class NullReferenceDemo{
	static void ShowLength(string str){
		Console.WriteLine(str.Length);
	}
	static void Main(){
		string name=null;
		try{
			ShowLength(name);
		}
		catch(NullReferenceException e){
			Console.WriteLine("NullReferenceException Occurred");
		}
	}
}
