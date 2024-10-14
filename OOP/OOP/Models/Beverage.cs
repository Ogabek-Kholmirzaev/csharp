namespace OOP.Models;

// Derived Class
class Beverage : Product
{ 
    public int Liters { get; set; } //  Liters of a Beverage

    // This function calls the Base class getters and prepends the values to the Litres
    public string GetDetails()
    { 
        string details = $"{GetName(Liters)}, {GetPrice(Liters)}, {Liters}";
        // write your code here
        // Return format should be "name, price, liters"

        return details;
    }
}
