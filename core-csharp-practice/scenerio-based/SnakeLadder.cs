using System;

class SnakeLadder{
	static bool CheckWin(int Position){
        return Position == 100;
    }
	
	static int ApplySnakeOrLadder(int Position){
        int[] Start = { 4, 9, 17, 20, 28, 40, 51, 54, 62, 64, 87, 93, 95, 99 };
        int[] End = { 14, 31, 7, 38, 84, 59, 67, 34, 19, 60, 36, 73, 75, 78 };

        for (int i = 0; i < Start.Length; i++){
            if (Position == Start[i]){
                if (End[i] > Start[i])
                    Console.WriteLine("Ladder! Climb up!");
                else
                    Console.WriteLine("Snake! Slide down!");

                return End[i];
            }
        }

        return Position;
    }

	static int MovePlayer(int CurrentPosition, int Dice){
        int Tentative = CurrentPosition + Dice;
        return Tentative > 100 ? CurrentPosition : Tentative;
    }
	
	static int RollDice(){
		Random Random = new Random();
        return Random.Next(1, 7);
    }

	static int GetPlayerCount(){
        int Count;
        do{
            Console.Write("Enter number of players (2 to 4): ");
            Count = int.Parse(Console.ReadLine());
        }
        while (Count < 2 || Count > 4);
        return Count;
    }

    static void Main(){
        Console.WriteLine("Welcome to Snake & Ladder Game");

        int PlayerCount = GetPlayerCount();
        string[] Players = new string[PlayerCount];
        int[] Positions = new int[PlayerCount];

        for (int Index = 0; Index < PlayerCount; Index++){
            Console.Write("Enter name of Player " + (Index + 1) + ": ");
            Players[Index] = Console.ReadLine();
            Positions[Index] = 0;
        }

        bool GameOver = false;

        while (!GameOver){
            for (int Index = 0; Index < PlayerCount; Index++){
                Console.WriteLine("\nPress Enter to roll dice for " + Players[Index]);
                Console.ReadLine();

                int Dice = RollDice();
                int OldPosition = Positions[Index];

                Console.WriteLine(Players[Index] + " rolled: " + Dice);

                int NewPosition = MovePlayer(OldPosition, Dice);

                if (NewPosition == OldPosition){
                    Console.WriteLine("Move skipped (exceeds 100)");
                    continue;
                }
                NewPosition = ApplySnakeOrLadder(NewPosition);
                Positions[Index] = NewPosition;
                Console.WriteLine(Players[Index] + ": " + OldPosition + " → " + NewPosition);

                if (CheckWin(NewPosition)){
                    Console.WriteLine("\n" + Players[Index] + " WINS THE GAME!");
                    GameOver = true;
                    break;
                }
            }
        }
        Console.WriteLine("\nGame Over!");
    } 
}
