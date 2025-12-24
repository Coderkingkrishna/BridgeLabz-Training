using System;
class TallYoung{
	static void Main(){
		int[] Age = new int[3];
		double[] Height = new double[3];
		Console.WriteLine("Enter Age Elements");
		for(int i= 0;i<3;i++){
			Age[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter Height Elements");
		for(int i= 0;i<3;i++){
			Height[i] = double.Parse(Console.ReadLine());
		}
		int Young = 0;
		int Tall = 0;
		for(int i=0;i<2;i++){
			if(Age[i]>Age[i+1]){
				Young = i+1;
			}
			if(Height[i]<Height[i+1]){
				Tall = i+1;
			}
		}
		Console.WriteLine("Young : "+Young);
		Console.WriteLine("Tall : "+Tall);
		
	}
}