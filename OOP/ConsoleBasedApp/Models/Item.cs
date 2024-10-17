namespace ConsoleBasedApp.Models;

abstract class Item
{
    //fields
    private string _itemName;
    private int _price;
    private readonly string _type;

    //properties to read values
    public string Name { get { return this._itemName; } }
    public int Price { get { return this._price; } }
    public string Type {  get { return this._type; } }

    //constructor
    protected Item(string itemName, int price, string type)
    {
        this._itemName = itemName;
        this._price = price;
        this._type = type;
    }

    //abstract method
    public abstract string DisplayMessage();
}
