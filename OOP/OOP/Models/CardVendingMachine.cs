namespace OOP.Models;

class CardVendingMachine : EDM
{
    public override void Transact(bool successful)
    {
        Console.WriteLine("I accept cards only!");
    }
}
