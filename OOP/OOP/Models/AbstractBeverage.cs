namespace OOP.Models;

abstract class AbstractBeverage //base abstract method AbstractBeverage
{
    private string _name;
    private int _price;

    public AbstractBeverage(string name, int price)
    {
        this._name = name;
        this._price = price;
    }

    public string Name { get { return this._name; } }
    public int Price { get { return this._price; } }
}
