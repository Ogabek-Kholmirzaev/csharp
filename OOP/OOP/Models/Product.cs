using System.Runtime.CompilerServices;

namespace OOP.Models;

//base class product
public class Product
{
    //private fields: common attributes of all type of products
    private string _name;
    private double _price;
    private string _expiryDate;

    //parameterized constructor
    public Product(string name, double price, string expiryDate)
    {
        _name = name;
        _price = price;
        _expiryDate = expiryDate;
    }

    //public method to print details
    public void PrintDetails()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Price: " + _price);
        Console.WriteLine("Expiry Date: " + _expiryDate);
    }
}
