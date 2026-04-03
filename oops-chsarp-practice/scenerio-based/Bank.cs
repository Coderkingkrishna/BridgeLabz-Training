using System;

class BankAccount{
	public string AccountNumber;
	public double Balance;

	public BankAccount(string accNo,double balance){
		AccountNumber=accNo;
		Balance=balance;
	}

	public void Deposit(double amount){
		if(amount<=0){
			Console.WriteLine("Invalid deposit amount");
			return;
		}
		Balance+=amount;
		Console.WriteLine("Amount Deposited: "+amount);
	}

	public void Withdraw(double amount){
		if(amount<=0){
			Console.WriteLine("Invalid withdrawal amount");
			return;
		}
		if(amount>Balance){
			Console.WriteLine("Insufficient balance. Overdraft not allowed");
			return;
		}
		Balance-=amount;
		Console.WriteLine("Amount Withdrawn: "+amount);
	}

	public void CheckBalance(){
		Console.WriteLine("Current Balance: "+Balance);
	}
}

class Bank{
	public void UserActions(BankAccount account){
		Console.WriteLine("User Operations");
		account.Deposit(2000);
		account.Withdraw(1000);
		account.CheckBalance();
	}

	public void ManagerActions(BankAccount account){
		Console.WriteLine("Bank Manager Operations");
		Console.WriteLine("Account Number: "+account.AccountNumber);
		account.CheckBalance();
	}
}

class Program{
	static void Main(){
		BankAccount account=new BankAccount("ACC101",5000);
		Bank bank=new Bank();
		Console.WriteLine("Select Role: 1.User 2.BankManager");
		int choice=Convert.ToInt32(Console.ReadLine());
		if(choice==1){
			bank.UserActions(account);
		}else if(choice==2){
			bank.ManagerActions(account);
		}else{
			Console.WriteLine("Invalid Role");
		}
	}
}
