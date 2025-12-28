using System;
class PalindromeChecker{
	static string GetInput(){
		return Console.ReadLine();
	}
	static bool IsPalindrome(string str){
		int i=0,j=str.Length-1;
		while(i<j){
			if(str[i]!=str[j]){
				return false;
			}
			i++;
			j--;
		}
		return true;
	}
	static void ShowResult(bool result){
		if(result){
			Console.WriteLine("String is Palindrome");
		}
		else{
			Console.WriteLine("String is Not Palindrome");
		}
	}
	static void Main(){
		Console.WriteLine("Enter a string:");
		string str=GetInput();
		bool result=IsPalindrome(str);
		ShowResult(result);
	}
}
