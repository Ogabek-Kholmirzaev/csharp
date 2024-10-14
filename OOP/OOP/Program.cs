using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var cola = new Soda("CocaCola", 0.9, "12/12/2019", 0.35, "Cola", false, true); //creation of Soda Object
        cola.SodaDetails(); //calling method to print details
    }
}
