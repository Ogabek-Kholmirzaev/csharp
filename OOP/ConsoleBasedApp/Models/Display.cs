namespace ConsoleBasedApp.Models;

class Display
{
    //parameter-less constructor
    public Display()
    {
    }

    //welcome message
    public void WelcomeMessage()
    {
        Console.WriteLine(@"
.------------------------------------------------------------------------------.
| /\   /\___ _ __   __| (_)_ __   __ _    /\/\   __ _  ___| |__ (_)_ __   ___  |
| \ \ / / _ | '_ \ / _` | | '_ \ / _` |  /    \ / _` |/ __| '_ \| | '_ \ / _ \ |
|  \ V |  __| | | | (_| | | | | | (_| | / /\/\ | (_| | (__| | | | | | | |  __/ |
|   \_/ \___|_| |_|\__,_|_|_| |_|\__, | \/    \/\__,_|\___|_| |_|_|_| |_|\___| |
|                                 |___/                                        |
'------------------------------------------------------------------------------'");
    }

    //menu display
    public void DisplayMethod()
    {
        Console.WriteLine(@"
.-----.---------------------.
|Press|       Action        |
|-----|---------------------|
|  1  |    Feed Money       |
|  2  |    Select a Product |
|  3  |    Get Change       |
|  4  |    Quit             |
'-----'---------------------'
");
    }

    //overloaded for products display
    public void DisplayMethod(Item[,] products)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (products[i, j] != null)
                {
                    Console.Write("|{0}{1} : {2} : ${3}| \t", (i + 1), (j + 1), products[i, j].Name, products[i, j].Price);
                }
                else
                { 
                    Console.Write("|------Empty-----|\t");
                }
            }

            Console.WriteLine();
        }
    }

    //overloaded for displaying any passed message
    public void DisplayMethod(string message)
    {
        Console.WriteLine(message);
    }
}
