using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        //creating and using the Beverage Object
        var cola = new Beverage("RC Cola", 0.9, "12/12/2019", 350, "Cola"); 
        cola.BeverageDetails();

        //creating and using the Chocolate Object
        var crunch = new Chocolate("Crunch", 2.3, "3/9/2019", 43, true);
        crunch.ChocolateDetails();
    }
}
