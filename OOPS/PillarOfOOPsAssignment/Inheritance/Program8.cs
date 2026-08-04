using System;


class BankAccount
{
    public int AccountNumber;
    public double Balance;


    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }


    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Bank Account");
    }


    public void DisplayDetails()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
    }
}



class SavingsAccount : BankAccount
{
    public double InterestRate;


    public SavingsAccount(
        int accountNumber,
        double balance,
        double interest)
        : base(accountNumber, balance)
    {
        InterestRate = interest;
    }


    public override void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
        DisplayDetails();
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}



class CheckingAccount : BankAccount
{
    public int WithdrawalLimit;


    public CheckingAccount(
        int accountNumber,
        double balance,
        int limit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = limit;
    }


    public override void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
        DisplayDetails();
        Console.WriteLine(
            "Withdrawal Limit: " + WithdrawalLimit);
    }
}



class FixedDepositAccount : BankAccount
{
    public int Duration;


    public FixedDepositAccount(
        int accountNumber,
        double balance,
        int duration)
        : base(accountNumber, balance)
    {
        Duration = duration;
    }


    public override void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
        DisplayDetails();
        Console.WriteLine(
            "Duration: " + Duration + " Years");
    }
}



class Program
{
    static void Main(string[] args)
    {

        BankAccount[] accounts =
        {
            new SavingsAccount(101,50000,5),
            new CheckingAccount(102,30000,10000),
            new FixedDepositAccount(103,100000,3)
        };


        foreach (BankAccount account in accounts)
        {
            account.DisplayAccountType();
            Console.WriteLine();
        }

    }
}