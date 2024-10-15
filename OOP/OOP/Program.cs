using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating saving account object
        Account SAccount = new SavingsAccount(5000);

        SAccount.Deposit(1000);
        SAccount.PrintBalance();

        SAccount.Withdraw(3000);
        SAccount.PrintBalance();

        Console.WriteLine();

        // Creating checking account object
        Account CAccount = new CheckingAccount(5000);
        CAccount.Deposit(1000);
        CAccount.PrintBalance();

        CAccount.Withdraw(3000);
        CAccount.PrintBalance();
    }
}
