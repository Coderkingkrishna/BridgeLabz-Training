using System;

interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public void SetAccountNumber(string number)
    {
        accountNumber = number;
    }

    public void SetHolderName(string name)
    {
        holderName = name;
    }

    protected void SetBalance(double amount)
    {
        balance = amount;
    }

    public string GetAccountNumber()
    {
        return accountNumber;
    }

    public string GetHolderName()
    {
        return holderName;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance = balance - amount;
        }
    }

    public abstract double CalculateInterest();
}

class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(double initialBalance)
    {
        SetBalance(initialBalance);
    }

    public override double CalculateInterest()
    {
        return GetBalance() * 0.04;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan application submitted for Savings Account");
    }

    public double CalculateLoanEligibility()
    {
        return GetBalance() * 5;
    }
}

class CurrentAccount : BankAccount, ILoanable
{
    public CurrentAccount(double initialBalance)
    {
        SetBalance(initialBalance);
    }

    public override double CalculateInterest()
    {
        return GetBalance() * 0.01;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan application submitted for Current Account");
    }

    public double CalculateLoanEligibility()
    {
        return GetBalance() * 3;
    }
}

class Program
{
    static void ProcessAccounts(BankAccount[] accounts)
    {
        for (int i = 0; i < accounts.Length; i++)
        {
            BankAccount acc = accounts[i];

            Console.WriteLine("Account Number : " + acc.GetAccountNumber());
            Console.WriteLine("Holder Name    : " + acc.GetHolderName());
            Console.WriteLine("Balance        : " + acc.GetBalance());
            Console.WriteLine("Interest       : " + acc.CalculateInterest());

            if (acc is ILoanable)
            {
                ILoanable loanAcc = (ILoanable)acc;
                Console.WriteLine("Loan Eligibility : " + loanAcc.CalculateLoanEligibility());
            }

            Console.WriteLine("-------------------------------");
        }
    }

    static void Main()
    {
        BankAccount[] accounts = new BankAccount[2];

        BankAccount savings = new SavingsAccount(50000);
        savings.SetAccountNumber("SB-101");
        savings.SetHolderName("Rahul");

        BankAccount current = new CurrentAccount(100000);
        current.SetAccountNumber("CA-202");
        current.SetHolderName("Anita");

        accounts[0] = savings;
        accounts[1] = current;

        ProcessAccounts(accounts);

        Console.ReadLine();
    }
}
