using ConsoleBasedApp.Models;

// 3 x 4 array of Items
Item[,] products = new Item[3, 4];

products[0, 0] = new SnackItem("Munchy", 7);
products[0, 1] = new SnackItem("Chetoo", 5);
products[0, 2] = new SnackItem("Dorito", 3);
products[0, 3] = new SnackItem("Fritos", 5);

products[1, 0] = new ChocolateItem("KitKat", 5);
products[1, 1] = new ChocolateItem("Bounty", 6);
products[1, 2] = new ChocolateItem("Snicks", 8);
products[1, 3] = new ChocolateItem("Chocly", 7);

products[2, 0] = new DrinkItem("CoCola", 10);
products[2, 1] = new DrinkItem("Fantay", 3);
products[2, 2] = new DrinkItem("Sprite", 4);
products[2, 3] = new DrinkItem("Stingy", 4);


//passing the products array to the vending machine
//aggregation relationship
VendingMachine myvendy = new VendingMachine(products);

//turning on the vending machine
myvendy.TurnOn();
