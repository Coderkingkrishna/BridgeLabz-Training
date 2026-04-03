using System;
class ConvertToLowercase{
	static string MyToLower(string str){
		string result="";
		for(int i=0;i<str.Length;i++){
			if(str[i]>='A'&&str[i]<='Z'){
				result+=(char)(str[i]+32);
			}
			else{
				result+=str[i];
			}
		}
		return result;
	}
	static void Main(){
		Console.WriteLine("Enter String :-");
		string str=Console.ReadLine();
		string customLower=MyToLower(str);
		string builtInLower=str.ToLower();
		if(customLower.Equals(builtInLower)){
			Console.WriteLine("Both strings are equal");
		}
		else{
			Console.WriteLine("Strings are not equal");
		}
		Console.WriteLine(customLower);
		Console.WriteLine(builtInLower);
	}
}
