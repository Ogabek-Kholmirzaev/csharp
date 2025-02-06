using static System.Console;

TimesTable(7);
TimesTable(8, 10);

ConfigureConsole("fr-FR");
decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax.");

RunCardinalToOrdinal();

RunFactorial();

RunFibImperative();
