using OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        var vendingMachine = new VendingMachine(); //Object creation

        //Calling the members of the VendingMachine class
        Console.WriteLine("The capacity of the machine is {0}", vendingMachine.Capacity);
        vendingMachine.Display();
    }
}
