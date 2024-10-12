using OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        VendingMachine vendy = new VendingMachine("Count: 45", "Capacity: 50", "Money Collected: 440$");

        vendy.GetDetails();
    }
}
