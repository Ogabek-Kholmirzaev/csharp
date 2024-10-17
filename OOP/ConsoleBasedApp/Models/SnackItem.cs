namespace ConsoleBasedApp.Models;

class SnackItem : Item
{
    public SnackItem(string name, int price) : base(name, price, "Snack")
    {
    }

    public override string DisplayMessage()
    {
        return $"Name: {base.Name} Price: {base.Price}$ Type: {base.Type}";
    }
}
