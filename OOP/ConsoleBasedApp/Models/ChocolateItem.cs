namespace ConsoleBasedApp.Models;

class ChocolateItem : Item
{
    public ChocolateItem(string itemName, int price) : base(itemName, price, "Chocolate")
    {
    }

    public override string DisplayMessage()
    {
        return $"Name: {base.Name} Price: {base.Price}$ Type: {base.Type}";
    }
}
