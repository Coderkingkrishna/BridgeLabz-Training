using System;
class SplitWords{
	static int MyLength(string str){
		int count=0;
		foreach(char c in str){
			count++;
		}
		return count;
	}
	static string[,] SplitAndCount(string str){
		int words=1;
		for(int i=0;i<MyLength(str);i++){
			if(str[i]==' '){
				words++;
			}
		}
		string[,] result=new string[words,2];
		string temp="";
		int index=0;
		for(int i=0;i<MyLength(str);i++){
			if(str[i]!=' '){
				temp+=str[i];
			}
			else{
				result[index,0]=temp;
				result[index,1]=MyLength(temp).ToString();
				index++;
				temp="";
			}
		}
		result[index,0]=temp;
		result[index,1]=MyLength(temp).ToString();
		return result;
	}
	static void Main(){
		Console.WriteLine("Enter String :-");
		string str=Console.ReadLine();
		string[,] data=SplitAndCount(str);
		for(int i=0;i<data.GetLength(0);i++){
			Console.WriteLine(data[i,0]+" "+data[i,1]);
		}
	}
}
