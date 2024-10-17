namespace OOP.Aggregation;

class Product
{
    private string _name;
    private double _price;

    public Product(string name, double price)
    {
        this._name = name;
        this._price = price;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"[Name: {this._name}, Price: {this._price}]");
    }
}
