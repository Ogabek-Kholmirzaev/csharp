namespace ConsoleBasedApp.Models;

class KeyPad
{
    public KeyPad()
    {
    }

    //method to read input
    public int ReadKey()
    {
        string userInput;
        userInput = Console.ReadLine() ?? string.Empty;

        //converts to integer type
        if (int.TryParse(userInput, out int value) && value > 0)
        {
            return value;
        }

        return -1;
    }
}
