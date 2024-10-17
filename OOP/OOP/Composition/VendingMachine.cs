namespace OOP.Composition;

class VendingMachine //owner class
{
    //fields of vendingmachine class
    private Display _machineDisplay;
    private KeyPad _machineKeyPad;

    //constructor of vendingmachine class
    public VendingMachine()
    {
        //creating owned objects
        this._machineDisplay = new Display();
        this._machineKeyPad = new KeyPad();
    }

    //the above display nad keypad abjects can be used here
}
