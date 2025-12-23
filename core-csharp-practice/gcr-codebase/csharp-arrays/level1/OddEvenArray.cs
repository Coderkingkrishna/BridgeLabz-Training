using System;
class OddEvenArray{
	static void Main(){
		int Number = int.Parse(Console.ReadLine());
		int[] Odd = new int[(Number+1)/2];
		int[] Even = new int[(Number+1)/2];
		int E =0, O=0;
		for(int i =1;i<=Number;i++){
			if(i%2 == 0){
				Even[E++] =i;
			}
			else{
				Odd[O++]=i;
			}
		}
		Console.WriteLine("Even Elements");
		for(int i= 0;i<Even.Length;i++){
			Console.WriteLine(Even[i]);
		}
		Console.WriteLine("Odd Elements");
		for(int i= 0;i<Odd.Length;i++){
			Console.WriteLine(Odd[i]);
		}
	}
}