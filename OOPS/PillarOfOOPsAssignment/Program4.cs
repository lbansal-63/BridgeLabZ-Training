using System;
using System.Collections.Generic;

// Interface
interface ILoanable
{
    void ApplyForLoan();
    void CalculateLoanEligibility();
}

// Abstract Class
abstract class BankAccount
{
    // Encapsulation
    private int accountNumber;
    private string holderName;
    private double balance;

    // Properties
    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string HolderName
    {
        get { return holderName; }
        set { holderName = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    // Constructor
    public BankAccount(int accountNumber, string holderName, double balance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = balance;
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Deposited Amount : " + amount);
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn Amount : " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    // Abstract Method
    public abstract double CalculateInterest();

    // Concrete Method
    public void DisplayDetails()
    {
        Console.WriteLine("Account Number : " + AccountNumber);
        Console.WriteLine("Holder Name : " + HolderName);
        Console.WriteLine("Balance : " + Balance);
    }
}

// Savings Account
class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(int accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance)
    {
    }

    public override double CalculateInterest()
    {
        return Balance * 0.05;   // 5% Interest
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan Applied for Savings Account");
    }

    public void CalculateLoanEligibility()
    {
        if (Balance >= 50000)
            Console.WriteLine("Eligible for Loan");
        else
            Console.WriteLine("Not Eligible for Loan");
    }
}

// Current Account
class CurrentAccount : BankAccount, ILoanable
{
    public CurrentAccount(int accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance)
    {
    }

    public override double CalculateInterest()
    {
        return Balance * 0.02;   // 2% Interest
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan Applied for Current Account");
    }

    public void CalculateLoanEligibility()
    {
        if (Balance >= 100000)
            Console.WriteLine("Eligible for Loan");
        else
            Console.WriteLine("Not Eligible for Loan");
    }
}

// Main Class
class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        SavingsAccount acc1 = new SavingsAccount(101, "Rahul", 60000);
        CurrentAccount acc2 = new CurrentAccount(102, "Aman", 80000);

        accounts.Add(acc1);
        accounts.Add(acc2);

        Console.WriteLine("===== Bank Account Details =====\n");

        foreach (BankAccount account in accounts)
        {
            account.DisplayDetails();

            account.Deposit(5000);
            account.Withdraw(2000);

            Console.WriteLine("Interest : " + account.CalculateInterest());

            ILoanable loan = (ILoanable)account;
            loan.ApplyForLoan();
            loan.CalculateLoanEligibility();

            Console.WriteLine("--------------------------------");
        }

        Console.ReadLine();
    }
}