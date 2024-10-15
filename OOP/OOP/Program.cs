// Creating the objects
using OOP.Models;

EDM cardVendy = new CardVendingMachine();  
EDM cashVendy = new CashVendingMachine();
EDM hybridVendy = new HybridVendingMachine();

cardVendy.Dispense();    // Calling methods from CardVendingMachine
cardVendy.Transact();

Console.WriteLine();

cashVendy.Dispense();   // Calling methods from CashVendingMachine
cashVendy.Transact();    

Console.WriteLine();

hybridVendy.Dispense(); // Calling methods from HybridVendingMachine
hybridVendy.Transact();