namespace ConsoleBasedApp.Models;

class Transactor
{
    //total amount available in the machine
    private int _amountAvailable;

    public Transactor()
    {
        //initializing to 100
        this._amountAvailable = 100;
    }

    //adding to total
    public bool AddAmount(int bill)
    {
        if (ValidateBill(bill))
        {
            this._amountAvailable += bill;
            return true;
        }

        return false;
    }

    //for getting change
    public bool GetChange(int userAmount)
    {
        if (userAmount > 0)
        {
            SubAmount(userAmount);
            return true;
        }

        return false;
    }

    //check if the bill is valid
    private bool ValidateBill(int bill)
    {
        if (bill is 1 or 2 or 5 or 10 or 20 or 50 or 100)
        {
            return true;
        }

        return false;
    }

    //subtracting the change
    private void SubAmount(int change)
    {
        this._amountAvailable -= change;
    }
}
