namespace OOP.Models;

class Chocolate : Product
{
    private double _profit;

    //parameterized Constructor
    public Chocolate(string name, double price) : base(name, price)
    {
        this._profit = base.GetPurchasePrice() * 0.20; //20% of purchase price
    }

    //public method to get selling price
    public override double GetPrice()
    {
        //calculating selling price, Math.ceiling is just an ibuilt method to round off the price
        return base.GetPurchasePrice() + (int)Math.Round(this._profit);
    }

    //public method to call the base method for name and print the selling price from this class
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Selling price: {0}", this.GetPrice());
    }
}
