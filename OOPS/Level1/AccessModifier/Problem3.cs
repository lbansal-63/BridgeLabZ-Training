using System;

class BankAccount
{
    public string accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(string accountNumber, string accountHolder)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
    }

    public void SetBalance(double balance)
    {
        this.balance = balance;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder)
        : base(accountNumber, accountHolder)
    {
    }

    public void Display()
    {
        Console.WriteLine(accountNumber);
        Console.WriteLine(accountHolder);
    }
}