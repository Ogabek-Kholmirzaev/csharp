namespace OOP.Models;

class CashVendingMachine : EDM
{
    public override void Transact(bool successful)
    {
        if (successful)
        {
            Console.WriteLine("The transaction was successfully completed!");
            PrintReceipt();
        }
        else
        {
            Console.WriteLine("The transaction was unsuccessful!");
        }
    }

    //implementing the abstract method from ICanPrint
    public void PrintReceipt()
    {
        Console.WriteLine("Printing your receipt...");
    }
}
