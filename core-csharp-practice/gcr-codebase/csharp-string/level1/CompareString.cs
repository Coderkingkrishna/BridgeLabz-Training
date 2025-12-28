using System;
class CompareString{
	static bool Compare(String Name1, String Name2){
		int i =0, j=0;
		while(i<Name1.Length && j<Name2.Length){
			if(Name1[i] != Name2[j]){
				return false;
			}
			i++;
			j++;
		}
		if(i<Name1.Length || j<Name2.Length){
			return false;
		}
		return true;
	}
	static void Main(){
		String Name1 = Console.ReadLine();
		String Name2 = Console.ReadLine();
		bool IsEqual =  Compare(Name1, Name2);
		if(IsEqual && Name1.Equals(Name2)){
			Console.WriteLine("Both are Equals");
		}
		else{
			Console.WriteLine("Both are not Equals");
		}
	}
}