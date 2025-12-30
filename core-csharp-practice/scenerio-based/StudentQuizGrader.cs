using System;
class StudentQuizGrader{
	static int CalculateScore(char[] correctAnswers, char[] studentAnswer){
		int score = 0;
		for(int i=0;i<10;i++){
			if(correctAnswers[i] == studentAnswer[i]){
				Console.WriteLine("Q" + (i + 1) + ": CORRECT ANSWER");
				score++;
			}
			else{
				Console.WriteLine("Q" + (i + 1) + ": INCORRECT ANSWER");
			}
		}
		return score;
	}
	static void ShowQuestionInTest(String[ ,] questionWithOption, char[] correctAnswers){
		char[] studentAnswer = new char[10];
		// Display
        for (int i = 0; i < 10; i++){
            Console.WriteLine("Q" + (i + 1) + ": " + questionWithOption[i, 0]);
            Console.WriteLine("A) " + questionWithOption[i, 1]);
            Console.WriteLine("B) " + questionWithOption[i, 2]);
            Console.WriteLine("C) " + questionWithOption[i, 3]);
            Console.WriteLine("D) " + questionWithOption[i, 4]);
            Console.Write("Enter Option : ");
			studentAnswer[i] = char.Parse(Console.ReadLine());
        }
		int correct = CalculateScore(correctAnswers, studentAnswer);
		Console.WriteLine("Your score is :- " + correct);
	}
	static void CreatingGradingSystem(){
        string[,] questionWithOption = new string[10, 5];
		char[] correctAnswers = new char[10]
        {
            'A','A','A','A', 'A'  
            ,'A','A','A','A','A'
        };

        // Q1
        questionWithOption[0,0] = "What is C#?";
        questionWithOption[0,1] = "Programming Language";
        questionWithOption[0,2] = "Database";
        questionWithOption[0,3] = "Operating System";
        questionWithOption[0,4] = "Web Browser";

        // Q2
        questionWithOption[1,0] = "Which company developed C#?";
        questionWithOption[1,1] = "Microsoft";
        questionWithOption[1,2] = "Google";
        questionWithOption[1,3] = "Apple";
        questionWithOption[1,4] = "Amazon";

        // Q3
        questionWithOption[2,0] = "Which keyword defines a class in C#?";
        questionWithOption[2,1] = "class";
        questionWithOption[2,2] = "struct";
        questionWithOption[2,3] = "define";
        questionWithOption[2,4] = "object";

        // Q4
        questionWithOption[3,0] = "Entry point of a C# program?";
        questionWithOption[3,1] = "Main";
        questionWithOption[3,2] = "Start";
        questionWithOption[3,3] = "Run";
        questionWithOption[3,4] = "Init";

        // Q5
        questionWithOption[4,0] = "Which symbol is used for single-line comments?";
        questionWithOption[4,1] = "//";
        questionWithOption[4,2] = "/* */";
        questionWithOption[4,3] = "#";
        questionWithOption[4,4] = "<!-- -->";

        // Q6
        questionWithOption[5,0] = "Which data type stores text?";
        questionWithOption[5,1] = "string";
        questionWithOption[5,2] = "char";
        questionWithOption[5,3] = "int";
        questionWithOption[5,4] = "bool";

        // Q7
        questionWithOption[6,0] = "Which keyword is used for inheritance?";
        questionWithOption[6,1] = ":";
        questionWithOption[6,2] = "extends";
        questionWithOption[6,3] = "implements";
        questionWithOption[6,4] = "inherits";

        // Q8
        questionWithOption[7,0] = "Which loop executes at least once?";
        questionWithOption[7,1] = "do-while";
        questionWithOption[7,2] = "for";
        questionWithOption[7,3] = "while";
        questionWithOption[7,4] = "foreach";

        // Q9
        questionWithOption[8,0] = "Which keyword handles exceptions?";
        questionWithOption[8,1] = "try-catch";
        questionWithOption[8,2] = "throw";
        questionWithOption[8,3] = "error";
        questionWithOption[8,4] = "handle";

        // Q10
        questionWithOption[9,0] = "Which collection stores key-value pairs?";
        questionWithOption[9,1] = "Dictionary";
        questionWithOption[9,2] = "List";
        questionWithOption[9,3] = "Array";
        questionWithOption[9,4] = "Queue";
		
		
		ShowQuestionInTest(questionWithOption, correctAnswers);
        
    }	
	static void Main(){
		CreatingGradingSystem();
	}
}