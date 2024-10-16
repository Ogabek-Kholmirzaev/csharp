namespace OOP.Models;

abstract class Book
{
    private string _name;
    private string _author;
    private string _price;

    protected string Name { get { return this._name; } }
    protected string Author { get { return this._author; } }
    protected string Price { get { return this._price; } }

    public Book(string name, string author, string price)
    {
        this._name = name;
        this._author = author;
        this._price = price;
    }

    public abstract string GetDetails();
}
