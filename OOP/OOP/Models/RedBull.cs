using OOP.Interfaces;

namespace OOP.Models;

class RedBull : AbstractBeverage, IEnergyDrink //RedBull class inheriting both
{
    public RedBull(int price) : base("RedBull", price)
    {
    }

    //any energy drink which implements IEnergyDrink will have to implement
    public int CalculatePrice(int price)
    {
        return price + 1;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"The name of the drink is: {base.Name}");
        Console.WriteLine($"The price of the drink is: {CalculatePrice(base.Price)}");
    }
}
