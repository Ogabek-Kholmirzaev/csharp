namespace OOP.Models;

class HybridVendingMachine : EDM
{
    public override void Transact()
    {
        Console.WriteLine("I accept both cards and cash!");
    }
}
