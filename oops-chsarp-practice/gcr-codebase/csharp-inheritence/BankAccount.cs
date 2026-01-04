using System;
class BankAccount{
    protected int AccountNumber;
    protected double Balance;
}
class SavingsAccount:BankAccount{
    double interestRate;
    public SavingsAccount(int a,double b,double i){
        AccountNumber=a;Balance=b;interestRate=i;
    }
    public void DisplayAccountType(){
        Console.WriteLine("Savings Account");
    }
}
class CheckingAccount:BankAccount{
    double withdrawalLimit;
    public CheckingAccount(int a,double b,double w){
        AccountNumber=a;Balance=b;withdrawalLimit=w;
    }
    public void DisplayAccountType(){
        Console.WriteLine("Checking Account");
    }
}
class FixedDepositAccount:BankAccount{
    int years;
    public FixedDepositAccount(int a,double b,int y){
        AccountNumber=a;Balance=b;years=y;
    }
    public void DisplayAccountType(){
        Console.WriteLine("Fixed Deposit Account");
    }
}
class Test{
    static void Main(){
        SavingsAccount s=new SavingsAccount(1,50000,4.5);
        CheckingAccount c=new CheckingAccount(2,30000,10000);
        FixedDepositAccount f=new FixedDepositAccount(3,100000,5);
        s.DisplayAccountType();
        c.DisplayAccountType();
        f.DisplayAccountType();
    }
}
