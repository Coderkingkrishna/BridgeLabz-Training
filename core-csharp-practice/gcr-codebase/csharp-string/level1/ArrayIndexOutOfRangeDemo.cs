using System;
class ArrayIndexOutOfRangeDemo{
	static void AccessElement(int[] arr){
		Console.WriteLine(arr[5]);
	}
	static void Main(){
		int[] arr={10,20,30};
		try{
			AccessElement(arr);
		}
		catch(IndexOutOfRangeException e){
			Console.WriteLine("IndexOutOfRangeException Occurred");
		}
	}
}
