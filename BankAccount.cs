
using System;

public class BankAccount
{
    private string owner;
    private double balance;

    public BankAccount(string owner, double initialBalance)
    {
        this.owner = owner;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }
}
