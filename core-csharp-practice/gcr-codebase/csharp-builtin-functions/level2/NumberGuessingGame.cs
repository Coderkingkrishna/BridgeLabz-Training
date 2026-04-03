using System;
class NumberGuessingGame{
	static int GenerateGuess(int min,int max){
		Random r=new Random();
		return r.Next(min,max+1);
	}
	static string GetFeedback(){
		Console.WriteLine("Enter feedback (high/low/correct):");
		return Console.ReadLine();
	}
	static void PlayGame(){
		int min=1,max=100;
		while(true){
			int guess=GenerateGuess(min,max);
			Console.WriteLine("Computer Guess: "+guess);
			string feedback=GetFeedback();
			if(feedback=="correct"){
				Console.WriteLine("Computer guessed correctly");
				break;
			}
			else if(feedback=="high"){
				max=guess-1;
			}
			else if(feedback=="low"){
				min=guess+1;
			}
		}
	}
	static void Main(){
		Console.WriteLine("Think of a number between 1 and 100");
		PlayGame();
	}
}
