using System;
class LibraryManagement{
	static void WantBook(String[ , ]books , int number){
		Console.Write("ENTER THE TITLE OF THE BOOK YOU WANT :- ");
		String want = Console.ReadLine().ToLower();
		for(int i =0;i<number;i++){
			if((books[i, 0].ToLower()).Equals(want) && books[i,2] == "Available"){
				Console.WriteLine(books[i, 0]+" BOOK IS ISSUED FOR U");
				books[i, 2] = "Issued";
				Console.Write("PRESS 1 FOR BUY ANOTHER OR 2 FOR EXIT OR ANY OTHER FOR SEARCH AGAIN :- ");
				int val = int.Parse(Console.ReadLine());
				if(val ==1){	
					WantBook(books, number);
				}
				else if(val == 2){
					return;
				}
				else{
					getUserInput(books, number);
				}
			}
		}
		Console.WriteLine("NO BOOK AVAIBLE OR ALREADY ISSUE");
		Console.Write("PRESS 1 FOR BUY ANOTHER OR 2 FOR EXIT OR ANY OTHER FOR SEARCH AGAIN :- ");
		int value = int.Parse(Console.ReadLine());
		if(value ==1){	
			WantBook(books, number);
		}
		else if(value == 2){
			return;
		}
		else{
			getUserInput(books, number);
		}
	}
	static void SearchBook(String[ , ]books , int number, String userInput){
		int count = 0;
		Console.WriteLine("AVAIBLE BOOKS");
		Console.WriteLine("{0,-25} {1,-25} {2,-10}", "Title", "Author", "Status");
		Console.WriteLine(new string('-', 65));
		
		for(int i =0;i<number;i++){
			if((books[i, 0].ToLower()).Contains(userInput)){
				count++;
				Console.WriteLine(
					"{0,-25} {1,-25} {2,-10}",
					books[i,0],
					books[i,1],
					books[i,2]);
			}
		}
		if(count == 0){
			Console.WriteLine("NO BOOKS AVAIBLE FOR THE GIVEN SEARCH");
			Console.Write("PRESS 1 FOR SEARCH AGAIN OR ENTER ANY OTHER TO EXIT :- ");
			int enterNumber = int.Parse(Console.ReadLine());
			if(enterNumber == 1) getUserInput(books, number);
			else{
				Console.WriteLine("THANK U FOR VISITING THE LIBRARY COME AGAIN");
				return;
			}
		}
		Console.Write("WANT BOOK PRESS 1 OR FOR EXIT ENTER ANY OTHER:- ");
		int ValueEnter = int.Parse(Console.ReadLine());
		if(ValueEnter != 1){
			getUserInput(books, number);
		}
		else{
			WantBook(books, number);
			return;
		}
		
	}
	static void getUserInput(String[ , ]books , int number){
		Console.Write("Pls enter the title of the book :- ");
		String searchBook = Console.ReadLine().ToLower();
		SearchBook(books, number , searchBook);
		return;
	}
	static void CreatingLibrarySystem(){
		int number = 10;
		String[ , ] books = new String[number , 3];
		books[0, 0] = "Clean Code";          books[0, 1] = "Robert C. Martin";   books[0, 2] = "Available";
        books[1, 0] = "Effective Java";      books[1, 1] = "Joshua Bloch";       books[1, 2] = "Issued";
        books[2, 0] = "The Pragmatic Programmer"; books[2, 1] = "Andrew Hunt"; books[2, 2] = "Available";
        books[3, 0] = "Design Patterns";     books[3, 1] = "Erich Gamma";        books[3, 2] = "Available";
        books[4, 0] = "Refactoring";         books[4, 1] = "Martin Fowler";      books[4, 2] = "Issued";
        books[5, 0] = "Head First Java";     books[5, 1] = "Kathy Sierra";       books[5, 2] = "Available";
        books[6, 0] = "C# in Depth";         books[6, 1] = "Jon Skeet";           books[6, 2] = "Issued";
        books[7, 0] = "Introduction to Algorithms"; books[7, 1] = "CLRS";     books[7, 2] = "Available";
        books[8, 0] = "You Don’t Know JS";   books[8, 1] = "Kyle Simpson";        books[8, 2] = "Available";
        books[9, 0] = "The Mythical Man-Month"; books[9, 1] = "Fred Brooks";   books[9, 2] = "Issued";

        // Display books
        Console.WriteLine("{0,-25} {1,-25} {2,-10}", "Title", "Author", "Status");
		Console.WriteLine(new string('-', 65));

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(
			"{0,-25} {1,-25} {2,-10}",
				books[i,0],
				books[i,1],
				books[i,2]);
        }
		getUserInput(books, number);
	} 
	static void Main(){
		CreatingLibrarySystem();
	}
}