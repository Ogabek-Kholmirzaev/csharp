using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // Placing the products in an array
        Product[] products =
        [
            new Beverage("Cola", 9),
            new Chocolate("Crunch", 15),
            new Chocolate("Kit-kat", 20),
            new Beverage("Fanta", 8),
        ];

        // name and price of respective  product is displayed
        foreach (Product product in products)
        product.PrintDetails();
    }
}
