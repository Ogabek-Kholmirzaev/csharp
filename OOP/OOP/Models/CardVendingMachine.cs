namespace OOP.Models;

class CardVendingMachine : EDM
{
    public override void Transact()
    {
        Console.WriteLine("I accept cards only!");
    }
}
