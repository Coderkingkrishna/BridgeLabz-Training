using System;
class InvoiceGenerator{
	public static string[] ParseInvoice(string input){
		return input.Split(',');
	}

	public static int GetTotalAmount(string[] tasks){
		int total=0;
		for(int i=0;i<tasks.Length;i++){
			string[] parts=tasks[i].Split('-');
			string amountPart=parts[1].Trim();
			string[] amountTokens=amountPart.Split(' ');
			int amount=Convert.ToInt32(amountTokens[0]);
			total+=amount;
		}
		return total;
	}
}

class Program{
	static void Main(){
		Console.Write("Enter invoice details: ");
		string input=Console.ReadLine();
		string[] tasks=InvoiceGenerator.ParseInvoice(input);
		Console.WriteLine("Invoice Details:");
		for(int i=0;i<tasks.Length;i++){
			string[] parts=tasks[i].Split('-');
			Console.WriteLine("Task: "+parts[0].Trim()+" Amount: "+parts[1].Trim());
		}
		int total=InvoiceGenerator.GetTotalAmount(tasks);
		Console.WriteLine("Total Invoice Amount: "+total+" INR");
	}
}
