using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message)
        : base(message)
    {
    }
}

class BankAccount
{
    private double balance;

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!");
        }

        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }

        balance -= amount;

        Console.WriteLine(
            "Withdrawal successful, new balance: " + balance
        );
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(5000);

        try
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientFundsException)
        {
            Console.WriteLine("Insufficient balance!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid amount!");
        }
    }
}