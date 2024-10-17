namespace ConsoleBasedApp.Models;

class VendingMachine
{
    private Item[,] _shelve; //shelve to store products
    private Display _machineDisplay; //display to display messages
    private Transactor _machineTransactor; //transactor to handle the transactions
    private KeyPad _machineKeyPad; //keypad to read the user inputs
    private int userAmount; //field to keep track of the user's money

    //parameterized constructor
    public VendingMachine(Item[,] items)
    {
        this._shelve = items;
        this._machineDisplay = new Display();
        this._machineTransactor = new Transactor();
        this._machineKeyPad = new KeyPad();
        this.userAmount = 0;
    }

    //the method to start the vending machine
    public void TurnOn()
    {
        //display the welcome message
        this._machineDisplay.WelcomeMessage();

        //variable to store the input
        int input = 0;

        while (true)
        {
            this._machineDisplay.DisplayMethod();
            this._machineDisplay.DisplayMethod("\nPlease Enter Your Selection: ");
            input = this._machineKeyPad.ReadKey();

            //perform corresponding action after reading input
            switch (input)
            {
                //feed money
                case 1:
                    this._machineDisplay.DisplayMethod("Enter a Valid $ Bill: ");
                    int bill = this._machineKeyPad.ReadKey();

                    if (this._machineTransactor.AddAmount(bill))
                    {
                        userAmount += bill;
                        this._machineDisplay.DisplayMethod($"\nYour Current Balance is: $ {this.userAmount}\n");
                    }
                    else
                    {
                        Console.WriteLine("\nYou have Entered an Invalid $ Bill\n");
                        this._machineDisplay.DisplayMethod($"Your Current Balance is ${this.userAmount}\n");
                    }

                    break;

                //select product
                case 2:
                    this._machineDisplay.DisplayMethod(this._shelve);
                    this._machineDisplay.DisplayMethod($"\nYour Current Balance is: {this.userAmount}\n");
                    this._machineDisplay.DisplayMethod("Enter Product Slot #:");
                    int slot = this._machineKeyPad.ReadKey();
                    BuyProduct(slot);

                    break;

                //get change
                case 3:
                    if (this._machineTransactor.GetChange(this.userAmount))
                    {
                        this._machineDisplay.DisplayMethod($"\nPlease Collect Your Change ${this.userAmount} from the Cash Dispenser");
                        this.userAmount = 0;
                    }
                    else
                    {
                        this._machineDisplay.DisplayMethod("\nSorry You don't have any Change\n");
                    }

                    break;

                //quit
                case 4:
                    if (this.userAmount == 0)
                    {
                        this._machineDisplay.DisplayMethod("Thank You from Using the Vendy!\n");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        _machineDisplay.DisplayMethod("OOPS! You Forgot to Collect your change");
                        _machineDisplay.DisplayMethod($"Please Collect Your Change ${this.userAmount} from the Cash Dispenser\n");
                        _machineDisplay.DisplayMethod("Thank You for Using the Vendy!\n");
                        this.userAmount = 0;
                        Thread.Sleep(4000);
                    }

                    Console.Clear();
                    this._machineDisplay.WelcomeMessage();

                    break;

                default:
                    Console.Clear();
                    _machineDisplay.DisplayMethod("Please Make a Valid Selection\n");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

    private void BuyProduct(int slot)
    {

        int column = (slot % 10) - 1;
        int row = (slot / 10) - 1;
        if ((row >= 0 && row <= 2) && (column >= 0 && column <= 3))
        {
            if (this._shelve[row, column] != null)
            {
                if (this._shelve[row, column].Price <= this.userAmount)
                {
                    Console.Clear();
                    this._machineDisplay.DisplayMethod("You've Bought:");
                    this._machineDisplay.DisplayMethod($"{this._shelve[row, column].DisplayMessage()}\n");
                    this._machineDisplay.DisplayMethod($"Please Pick your {this._shelve[row, column].Name} from the Dispenser\n");
                    this.userAmount -= this._shelve[row, column].Price;
                    this._shelve[row, column] = null;

                    Thread.Sleep(1000);
                }
                else
                {
                    _machineDisplay.DisplayMethod($"\nSorry You don't have Enough Balance to buy: {this._shelve[row, column].Name}\n");
                }
            }
            else
            {
                _machineDisplay.DisplayMethod("\nThe Selected Slot # is Empty\n");
            }
        }
        else
        {
            _machineDisplay.DisplayMethod("\nYou've Entered an Invalid Slot Number\n");
        }
    }
}