using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Beverage cola = new Beverage();
        cola.Liters = 1;
        Console.WriteLine(cola.GetDetails());
    }
}
