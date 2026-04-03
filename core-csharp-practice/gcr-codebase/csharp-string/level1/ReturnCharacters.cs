using System;
class ReturnCharacters{
	static char[] MyCharArray(string str){
		char[] arr=new char[str.Length];
		for(int i=0;i<str.Length;i++){
			arr[i]=str[i];
		}
		return arr;
	}
	static void Main(){
		Console.WriteLine("Enter String :-");
		string str=Console.ReadLine();
		char[] customArr=MyCharArray(str);
		char[] builtInArr=str.ToCharArray();
		bool isSame=true;
		if(customArr.Length!=builtInArr.Length){
			isSame=false;
		}
		else{
			for(int i=0;i<customArr.Length;i++){
				if(customArr[i]!=builtInArr[i]){
					isSame=false;
					break;
				}
			}
		}
		if(isSame){
			Console.WriteLine("Both character arrays are equal");
		}
		else{
			Console.WriteLine("Character arrays are not equal");
		}
		for(int i=0;i<customArr.Length;i++){
			Console.Write(customArr[i]);
		}
	}
}
