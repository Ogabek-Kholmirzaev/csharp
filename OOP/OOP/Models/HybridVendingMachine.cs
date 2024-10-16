namespace OOP.Models;

class HybridVendingMachine : EDM
{
    public override void Transact(bool successful)
    {
        Console.WriteLine("I accept both cards and cash!");
    }
}
