using System;

class BankAccount
{
    public static string BankName = "State Bank";
    private static int totalAccounts = 0;

    public string AccountHolderName;
    public readonly int AccountNumber;

    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        totalAccounts++;
    }

    public void Display()
    {
        Console.WriteLine("Bank : " + BankName);
        Console.WriteLine("Holder : " + AccountHolderName);
        Console.WriteLine("Account No : " + AccountNumber);
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts : " + totalAccounts);
    }
}

class Program
{
    static void Main()
    {
        BankAccount b1 = new BankAccount("Rahul", 1001);

        if (b1 is BankAccount)
        {
            b1.Display();
        }

        BankAccount.GetTotalAccounts();
    }
}