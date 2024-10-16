namespace OOP.Models;

abstract class EDM
{
    public EDM()
    {
        //parameter-less constructor
    }

    public abstract void Transact(bool successful);
    
    public void Dispense()
    {
        Console.WriteLine($"{this.GetType().Name} is dispensing the product!");
    }
}
