namespace OOP.Models;

// Derived Class
class Beverage : Product
{ 
    //private fields for refregeration and our profit
    private double _refCost;
    private double _profit;

    //parameterized constructor
    public Beverage(string name, double price) : base(name, price)
    {
        this._refCost = base.GetPurchasePrice() * 0.10; //10% of purchase price
        this._profit = base.GetPurchasePrice() * 0.15; //15% of purchase price
    }

    //public method to get selling price
    public override double GetPrice()
    {
        //calculating selling price, Math.Round is just an ibuilt method to round off the price
        return base.GetPurchasePrice() + (int)Math.Round(this._refCost) + (int)Math.Round(this._profit);
    }

    //public method to call the base method for name and print the selling price from this class
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Selling price: " + this.GetPrice());
    }
}
