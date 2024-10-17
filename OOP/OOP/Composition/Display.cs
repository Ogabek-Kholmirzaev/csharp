namespace OOP.Composition;

class Display
{
    public Display() //parameter-less constructor
    {
    }

    public void WelcomeMessage() //method to welcome a customer
    {
        Console.WriteLine("Welcome to the vending machine");
    }

    public void DisplayMethod() //method to show the machine menu
    {
        Console.WriteLine(@"
.-----.---------------------.
|Press|       Action        |
|-----|---------------------|
|  1  |    Feed Money       |
|  2  |    Select a Product |
|  3  |    Get Change       |
|  4  |    Quit             |
'-----'---------------------'");
    }
}
