namespace OOP.Models;

class MyBook : Book
{
    public MyBook(string name, string author, string price) : base(name, author, price)
    {
    }

    public override string GetDetails()
    {
        return $"{base.Name}, {base.Author}, {base.Price}";
    }
}
