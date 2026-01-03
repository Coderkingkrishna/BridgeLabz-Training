using System;
class BankAccount{
    public int accountNumber;
    protected string accountHolder;
    private double balance;
    public void SetBalance(double b){balance=b;}
    public double GetBalance(){return balance;}
}
class SavingsAccount:BankAccount{
    public void SetDetails(int n,string h){
        accountNumber=n;accountHolder=h;
    }
    public void Display(){
        Console.WriteLine(accountNumber+" "+accountHolder);
    }
}
class Test{
    static void Main(){
        SavingsAccount s=new SavingsAccount();
        Console.Write("Account Number: "); // input account number
        int n=int.Parse(Console.ReadLine());
        Console.Write("Account Holder: "); // input holder
        string h=Console.ReadLine();
        Console.Write("Balance: "); // input balance
        double b=double.Parse(Console.ReadLine());
        s.SetDetails(n,h);
        s.SetBalance(b);
        s.Display();
        Console.WriteLine("Balance:"+s.GetBalance());
    }
}
