using System;
using System.Collections.Generic;

class Bank
{
    public string BankName;
    Dictionary<Customer, double> accounts = new Dictionary<Customer, double>();

    public Bank(string name)
    {
        BankName = name;
    }

    public void OpenAccount(Customer customer, double balance)
    {
        accounts[customer] = balance;
        customer.Bank = this;
    }

    public double GetBalance(Customer customer)
    {
        return accounts.ContainsKey(customer) ? accounts[customer] : 0;
    }
}

class Customer
{
    public string Name;
    public Bank Bank;

    public Customer(string name)
    {
        Name = name;
    }

    public void ViewBalance()
    {
        Console.WriteLine($"{Name} Balance: {Bank.GetBalance(this)}");
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank("ABC Bank");

        Customer c1 = new Customer("Ali");
        Customer c2 = new Customer("Sara");

        bank.OpenAccount(c1, 15000);
        bank.OpenAccount(c2, 25000);

        c1.ViewBalance();
        c2.ViewBalance();
    }
}