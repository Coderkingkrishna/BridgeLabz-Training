using System;
class CreateSubstring{
	static string MySubstring(string str,int start,int end){
		string result="";
		for(int i=start;i<end;i++){
			result+=str[i];
		}
		return result;
	}
	static void Main(){
		Console.WriteLine("Enter String :");
		string str=Console.ReadLine();
		int start=int.Parse(Console.ReadLine());
		int end=int.Parse(Console.ReadLine());
		string customSub=MySubstring(str,start,end);
		string builtInSub=str.Substring(start,end-start);
		if(customSub.Equals(builtInSub)){
			Console.WriteLine("Both substrings are equal");
		}
		else{
			Console.WriteLine("Substrings are not equal");
		}
		Console.WriteLine(customSub);
		Console.WriteLine(builtInSub);
	}
}
