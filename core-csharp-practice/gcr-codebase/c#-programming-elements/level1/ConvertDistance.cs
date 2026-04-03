using System;
class ConvertDistance{
	static void Main(){
		double feet = double.Parse(Console.ReadLine());
		double yard = feet / 3;
		double mile = yard / 1760;
		Console.WriteLine("Your distance in feet is "+feet+" while in yard is "+yard+" and mile is "+mile);
	}
}