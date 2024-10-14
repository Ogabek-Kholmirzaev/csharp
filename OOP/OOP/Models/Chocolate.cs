namespace OOP.Models;

public class Chocolate : Product
{ //inheriting Product
    //specifications of a chocolate
    private bool _isMilky;
    private double _grams;

    //constructor
    public Chocolate(string name, double price, string expiryDate, double grams, bool isMilky)
        : base(name, price, expiryDate) //calling parent class constructor
    {
        _grams = grams; //a chocolate having caffeine will have true
        _isMilky = isMilky; //the weight of chocolate bar
    }

    public void ChocolateDetails()
    {
        PrintDetails();
        Console.WriteLine("Is the {0} milky? {1}", GetName(), _isMilky);
        Console.WriteLine("The {0} bar wieghs: {1}g", GetName(), _grams);
    }
}
