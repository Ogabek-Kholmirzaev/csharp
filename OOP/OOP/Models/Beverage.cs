namespace OOP.Models;

//dirived class beverage
public class Beverage : Product
{
    //private fields: fields specific to the derived class
    private double _litres;
    private string _flavor;

    //parameterized constructor
    public Beverage(string name, double price, string expiryDate, double litres, string flavor)
        : base(name, price, expiryDate) //calling parent class constructor
    {
        _litres = litres;
        _flavor = flavor;
    }

    public void BeverageDetails()
    {//details of beverage
        PrintDetails(); //calling inherited method from product class
        //printing fields of this class 
        Console.WriteLine("Litres: " + _litres);
        Console.WriteLine("Flavor: " + _flavor);
    }
}
