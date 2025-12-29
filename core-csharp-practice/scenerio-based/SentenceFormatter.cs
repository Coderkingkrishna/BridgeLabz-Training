using System;
class SentenceFormatter{
	static void PrintOutput(String Result){
		Console.WriteLine("String After formatting :- " +Result);
	}
	static String TrimSpace(String Str){
		String Dummy = "";
		bool IsSpace = false;
		if(Str[0] == ' '){
			IsSpace = true;
		}
		for(int i =1;i<Str.Length;i++){
			if(IsSpace && (Str[i] == ' ')){
				continue;
			}
			else if(Str[i] == ' '){
				Dummy += Str[i];
				IsSpace = true;
			} 
			else{
				Dummy += Str[i];
				IsSpace = false;
			}
		}
		if(Dummy[0] >= 'a' && Dummy[0]<='z'){
			String Capt = (char)(Dummy[0] -32) +Dummy.Substring(1, Dummy.Length-1);
			return Capt;
		}
		return Dummy;
	}
	
	static String Capital(String Str){
		String Dummy = "";
		bool IsPunc = false;
		//bool IsFirstChar = true;
		for(int i =0;i<Str.Length;i++){
			if(IsPunc && ((Str[i] >= 'A' && Str[i] <= 'Z') || (Str[i] >= 'a' && Str[i] <= 'z'))){
				if(Str[i] >= 'A' && Str[i] <= 'Z'){
					Dummy += Str[i];
				}
				else{
					Dummy += (char)(Str[i] - 32);
				}
				IsPunc = false;
			}
			else if((Str[i] >= 'A' && Str[i] <= 'Z')){
					Dummy += (char)(Str[i] + 32);
			}
			else if(Str[i] == '.' || Str[i] == '?' || Str[i] == '!' || Str[i] == ','){
				Dummy += Str[i];
				IsPunc = true;
			}
			else{
				Dummy += Str[i];
			}
			
		}
		//Console.WriteLine(Dummy);
		return Dummy;
	}
	
	static String OneSpace(String Str){
		String Dummy = "";
		for(int i =0;i<Str.Length;i++){
			if(Str[i] == '.' || Str[i] == '?' || Str[i] == '!' || Str[i] == ','){
				Dummy += Str[i] +" ";
			}
			else{
				Dummy += Str[i];
			}
		}
		//Console.WriteLine( Dummy);
		return Dummy;
	}
	
	static void Functions(String Str){
		String StrAfterOneSpace = OneSpace(Str);
		String StrAfterCapital = Capital(StrAfterOneSpace);
		String StrAfterTrim = TrimSpace(StrAfterCapital);
		PrintOutput(StrAfterTrim);
	}
	
	static void GetInput(){
		Console.Write("Enter String :- ");
		String Str = Console.ReadLine();
		Functions(Str);
	}
	static void Main(){
		GetInput();
	}
}