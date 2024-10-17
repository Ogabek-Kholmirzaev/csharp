using System;

namespace OOP.Composition;

public class KeyPad //keypad class
{
    public KeyPad() //paremeter-less constructor
    {
    }

    public int ReadKey() //method to read the user input
    {
        string userInput;
        userInput = Console.ReadLine();

        //convert to integer type as the keypad should only have integer inputs
        if (int.TryParse(userInput, out int value) && value > 0)
        {
            return value;
        }
        else
        {
            return -1;
        }
    }
}
