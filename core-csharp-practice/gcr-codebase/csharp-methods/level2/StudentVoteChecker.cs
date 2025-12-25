using System;
class StudentVoteChecker{
	static bool CanStudentVote(int Age){
		if(Age<0){
			return false;
		}
		if(Age>=18){
			return true;
		}
		return false;
	}

	static void Main(){
		int[] Ages=new int[10];

		for(int i=0;i<Ages.Length;i++){
			Console.WriteLine("Enter Age of Student "+(i+1)+":");
			Ages[i]=int.Parse(Console.ReadLine());
			bool Result=CanStudentVote(Ages[i]);
			if(Result){
				Console.WriteLine("Student Can Vote");
			}
			else{
				Console.WriteLine("Student Cannot Vote");
			}
		}
	}
}
