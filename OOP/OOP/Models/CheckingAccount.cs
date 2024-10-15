namespace OOP.Models;

public class CheckingAccount : Account
{
    public CheckingAccount(double balance) : base(balance)
    {
    }

    public override bool Withdraw(double amount)
    {
        if ( amount > 0 && this.Balance >= amount)
        {
            this.Balance -= amount;
            return true;
        }

        return false;
    }

    public override bool Deposit(double amount)
    {
        if (this.Balance > 0 && amount > 0)
        {
            this.Balance += amount;
            return true;
        }

        return false;
    }

    public override void PrintBalance()
    {
        Console.WriteLine($"The checking account balance is: {this.Balance}");
    }
}