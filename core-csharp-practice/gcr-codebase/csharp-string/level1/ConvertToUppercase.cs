using System;
class ConvertToUppercase{
	static string MyToUpper(string str){
		string result="";
		for(int i=0;i<str.Length;i++){
			if(str[i]>='a'&&str[i]<='z'){
				result+=(char)(str[i]-32);
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
		string customUpper=MyToUpper(str);
		string builtInUpper=str.ToUpper();
		if(customUpper.Equals(builtInUpper)){
			Console.WriteLine("Both strings are equal");
		}
		else{
			Console.WriteLine("Strings are not equal");
		}
		Console.WriteLine(customUpper);
		Console.WriteLine(builtInUpper);
	}
}
