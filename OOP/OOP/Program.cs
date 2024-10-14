using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Beverage cola= new Beverage("RC Cola", 0.7, "8/12/2025", 0.35, "Cola"); //creation of beverage object
        cola.BeverageDetails(); //calling method to print details
    }
}
