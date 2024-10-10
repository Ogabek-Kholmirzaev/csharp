namespace OOP;

class VendingMachine
{
    //Class fields
    public int Count = 30;
    public int Capacity = 100;
    public int MoneyCollected = 300;
    public string Manufacturer = "Vendy Inc.";


    //Class Methods
    public void Display()
    {
        Console.WriteLine("I am the Display method for displaying the menu!");
    }

    public void DispenseProducts()
    {
        Console.WriteLine("I am the DispenseProducts method for dispensing the products!");
    }

    public void Refill()
    {
        Console.WriteLine("I am the Refill method for refilling the products!");
    }
}
