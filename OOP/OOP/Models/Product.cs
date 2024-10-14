namespace OOP.Models;

class Product
{
    private string _name;
    private double _purchasePrice;
    
    //parameterized Constructor
    public Product(string name, double purchasePrice)
    {
        this._name = name;
        this._purchasePrice = purchasePrice;
    }

    //getter to access the name of product
    public string GetName()
    {
        return this._name;
    }

    //getter to access the purchase price of products
    public double GetPurchasePrice()
    {
        return this._purchasePrice;
    }

    //method GetPrice() to be re-implemented in the derived classes
    public virtual double GetPrice()
    {
        return this._purchasePrice;
    }

    //method to print name and to be re-implemented in the derived classes for selling price
    public virtual void PrintDetails()
    {
        Console.WriteLine("Selected Product's Name: " + this._name);
    }
}