namespace OOP.Models;

// VendingMachine class
class VendingMachine
{
    // Private Fields
    private string _count;
    private string _capacity;
    private string _moneyCollected;

    // Default Constructor
    public VendingMachine()
    {
        _count = "";
        _capacity = "";
        _moneyCollected = "";
    }

    // Parameterized Constructor 1
    public VendingMachine(string count, string capacity)
    {
        _count = count;
        _capacity = capacity;
    }

    // Parameterized Constructor 2
    // Write your code to modify the below constructor 
    public VendingMachine(string count, string capacity, string money) : this(count, capacity)
    {
        _moneyCollected = money;
    }

    // Method to return vending machine details
    public string GetDetails()
    {
        return _count + ", " + _capacity + ", " + _moneyCollected;
    }
}
