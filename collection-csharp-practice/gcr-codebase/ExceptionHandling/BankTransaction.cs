using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    private double balance = 1000;

    public void Withdraw(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Invalid amount!");
        if (amount > balance)
            throw new InsufficientFundsException("Insufficient balance!");

        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }
}

class BankTransaction
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        try
        {
            double amt = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(amt);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
