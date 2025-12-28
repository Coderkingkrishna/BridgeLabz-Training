using System;
class DateFormatting{
	static void ShowFormats(){
		DateTime now=DateTime.Now;
		Console.WriteLine(now.ToString("dd/MM/yyyy"));
		Console.WriteLine(now.ToString("yyyy-MM-dd"));
		Console.WriteLine(now.ToString("ddd, MMM dd, yyyy"));
	}
	static void Main(){
		ShowFormats();
	}
}
