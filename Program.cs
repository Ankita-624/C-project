
using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("John Doe", 1000);
        int choice;

        do
        {
            Console.WriteLine("\n--- Bank Account Menu ---");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    account.ShowBalance();
                    break;
                case 2:
                    Console.Write("Enter amount to deposit: ");
                    double deposit = double.Parse(Console.ReadLine());
                    account.Deposit(deposit);
                    break;
                case 3:
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    account.Withdraw(withdraw);
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 4);
    }
}
