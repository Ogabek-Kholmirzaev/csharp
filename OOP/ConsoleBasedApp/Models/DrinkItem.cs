namespace ConsoleBasedApp.Models;

class DrinkItem : Item
{
    public DrinkItem(string name, int price) : base(name, price, "Drink")
    {
    }

    public override string DisplayMessage()
    {
        return $"Name: {base.Name} Price: {base.Price}$ Type: {base.Type}";
    }
}
