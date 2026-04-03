using System;
class Info{
	static int FindYoungest(int[] Ages){
		int Youngest=Ages[0];
		for(int i=1;i<Ages.Length;i++){
			if(Ages[i]<Youngest){
				Youngest=Ages[i];
			}
		}
		return Youngest;
	}

	static int FindTallest(int[] Heights){
		int Tallest=Heights[0];
		for(int i=1;i<Heights.Length;i++){
			if(Heights[i]>Tallest){
				Tallest=Heights[i];
			}
		}
		return Tallest;
	}

	static void Main(){
		string[] Names={"Amar","Akbar","Anthony"};
		int[] Ages=new int[3];
		int[] Heights=new int[3];

		for(int i=0;i<3;i++){
			Console.WriteLine("Enter Age of "+Names[i]+":");
			Ages[i]=int.Parse(Console.ReadLine());

			Console.WriteLine("Enter Height of "+Names[i]+":");
			Heights[i]=int.Parse(Console.ReadLine());
		}

		int YoungestAge=FindYoungest(Ages);
		int TallestHeight=FindTallest(Heights);

		for(int i=0;i<3;i++){
			if(Ages[i]==YoungestAge){
				Console.WriteLine("Youngest Friend is:"+Names[i]);
			}
			if(Heights[i]==TallestHeight){
				Console.WriteLine("Tallest Friend is:"+Names[i]);
			}
		}
	}
}
