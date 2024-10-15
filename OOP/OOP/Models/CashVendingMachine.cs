namespace OOP.Models;

class CashVendingMachine : EDM
{
    public override void Transact()
    {
        Console.WriteLine("I accept cash only!");
    }
}
