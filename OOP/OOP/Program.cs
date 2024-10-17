using OOP.Aggregation;

//creating vending machine
VendingMachine myVendy = new VendingMachine();

//creating products
Product snack = new Product("Rango Tango", 0.5);
Product drink = new Product("Mineral Water", 0.7);
Product chocolate = new Product("Crunchy", 1);
Product energyDrink = new Product("Red Bull", 3);
Product popcorn = new Product("Caramel pop", 0.5);

//inserting products into machine
myVendy.InsertProdcut(snack);
myVendy.InsertProdcut(drink);
myVendy.InsertProdcut(chocolate);
myVendy.InsertProdcut(energyDrink);
myVendy.InsertProdcut(popcorn);

//printing the product in vending machine
myVendy.PrintProducts();

//now if we null the myVend
myVendy = null;

//the products still exist and are still usable
Console.WriteLine("\nThe Products still exist!\n");

snack.PrintDetails();
drink.PrintDetails();
chocolate.PrintDetails();
energyDrink.PrintDetails();
popcorn.PrintDetails();