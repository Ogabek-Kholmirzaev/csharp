namespace OOP.Models;

public class SavingsAccount : Account
{
    private double _interestRate = 0.8;

    public SavingsAccount(double balance) : base(balance)
    {
    }

    public override bool Withdraw(double amount)
    {
        if (amount <= 0)
        {
            return false;
        }

        double amountWithInterestRate = amount + amount * this._interestRate;

        if (this.Balance >= amountWithInterestRate)
        {
            this.Balance -= amountWithInterestRate;
            return true;
        }

        return false;
    }

    public override bool Deposit(double amount)
    {
        if (this.Balance > 0 && amount > 0)
        {
            this.Balance += amount + amount * this._interestRate;
            return true;
        }

        return false;
    }

    public override void PrintBalance()
    {
        Console.WriteLine($"The saving account balance is: {base.Balance}");
    }
}