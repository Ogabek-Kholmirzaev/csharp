//creating the objects
using OOP.Models;

EDM cashvendy = new CashVendingMachine();

cashvendy.Dispense(); //calling methods from CashVendingMachine
cashvendy.Transact(true);

Console.WriteLine();

cashvendy.Transact(false);