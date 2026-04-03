using System;
class BankAccount{
    public static string BankName="SBI";
    static int total=0;
    public string Name;
    public readonly int AccountNumber;

    public BankAccount(string Name,int AccountNumber){
        this.Name=Name;
        this.AccountNumber=AccountNumber;
        total++;
    }

    public static void GetTotalAccounts(){
        Console.WriteLine("Total Accounts:"+total);
    }

    public void Display(object obj){
        if(obj is BankAccount)
            Console.WriteLine(BankName+" "+Name+" "+AccountNumber);
    }

    static void Main(){
        Console.Write("Enter Name: "); // input name
        string n=Console.ReadLine();
        Console.Write("Enter Account Number: "); // input account number
        int a=int.Parse(Console.ReadLine());
        BankAccount b=new BankAccount(n,a);
        b.Display(b);
        GetTotalAccounts();
    }
}
