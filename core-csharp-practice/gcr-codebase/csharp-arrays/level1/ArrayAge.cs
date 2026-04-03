using System;
class ArrayAge{
	static void Main(){
		int[] Age = new int[10];
		for(int i =0;i<Age.Length;i++){
			Age[i] = int.Parse(Console.ReadLine());
			if(Age[i]<0){
				Console.WriteLine("Invalid Age");
			}
			else if(Age[i]<18){
				Console.WriteLine("The student with the age "+Age[i]+" cannot vote");
			}
			else{
				Console.WriteLine("The student with the age "+Age[i]+" can vote");
			}
		}
	}
}