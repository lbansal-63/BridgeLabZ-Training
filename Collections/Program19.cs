using System;
using System.Collections.Generic;

class WithdrawalRequest
{
    public int AccountNumber { get; set; }
    public double Amount { get; set; }
}

class BankingSystem
{
    Dictionary<int, double> accounts =
        new Dictionary<int, double>();

    Queue<WithdrawalRequest> withdrawalQueue =
        new Queue<WithdrawalRequest>();

    public void CreateAccount(
        int accountNumber,
        double balance)
    {
        accounts[accountNumber] = balance;
    }

    public void Deposit(
        int accountNumber,
        double amount)
    {
        if (accounts.ContainsKey(accountNumber))
        {
            accounts[accountNumber] += amount;

            Console.WriteLine(
                "Deposited Rs." + amount +
                " into Account " + accountNumber);
        }
    }

    public void AddWithdrawalRequest(
        int accountNumber,
        double amount)
    {
        withdrawalQueue.Enqueue(
            new WithdrawalRequest
            {
                AccountNumber = accountNumber,
                Amount = amount
            }
        );
    }

    public void ProcessWithdrawals()
    {
        while (withdrawalQueue.Count > 0)
        {
            WithdrawalRequest request =
                withdrawalQueue.Dequeue();

            Withdraw(
                request.AccountNumber,
                request.Amount);
        }
    }

    public void Withdraw(
        int accountNumber,
        double amount)
    {
        if (!accounts.ContainsKey(accountNumber))
        {
            Console.WriteLine(
                "Account not found: " +
                accountNumber);

            return;
        }

        if (accounts[accountNumber] < amount)
        {
            Console.WriteLine(
                "Insufficient balance for Account " +
                accountNumber);

            return;
        }

        accounts[accountNumber] -= amount;

        Console.WriteLine(
            "Withdrawn Rs." + amount +
            " from Account " + accountNumber);
    }

    public void DisplayAccounts()
    {
        Console.WriteLine("\nACCOUNT BALANCES:");

        foreach (var account in accounts)
        {
            Console.WriteLine(
                "Account " + account.Key +
                " = Rs." + account.Value);
        }
    }

    public void DisplaySortedAccounts()
    {
        SortedDictionary<int, double> sortedAccounts =
            new SortedDictionary<int, double>(accounts);

        Console.WriteLine("\nSORTED ACCOUNTS:");

        foreach (var account in sortedAccounts)
        {
            Console.WriteLine(
                "Account " + account.Key +
                " = Rs." + account.Value);
        }
    }
}

class Program
{
    static void Main()
    {
        BankingSystem bank =
            new BankingSystem();

        // Create accounts
        bank.CreateAccount(103, 75000);
        bank.CreateAccount(101, 50000);
        bank.CreateAccount(102, 25000);

        bank.DisplayAccounts();

        // Deposit
        bank.Deposit(101, 10000);

        // Add withdrawal requests
        bank.AddWithdrawalRequest(101, 5000);
        bank.AddWithdrawalRequest(102, 3000);
        bank.AddWithdrawalRequest(103, 10000);

        Console.WriteLine("\nPROCESSING WITHDRAWALS:");
        
        // FIFO order
        bank.ProcessWithdrawals();

        bank.DisplayAccounts();

        bank.DisplaySortedAccounts();
    }
}