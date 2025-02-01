using System.Globalization; // To use CultureInfo.

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

//Interpolated strings
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

// Set current culture to US English so that all readers
// see the same output as shown in the book.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

Console.WriteLine(formatted);

// Three parameter values can use named arguments.
Console.WriteLine("{0} {1} lived in {2}.", arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
// Four or more parameter values cannot use named arguments.
Console.WriteLine(
    "{0} {1} lived in {2} and worked in the {3} team at {4}.",
    "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

Console.WriteLine();
Console.WriteLine(format: "{0,-10} {1,6}", arg0: "Name", arg1: "Count");
Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: applesText, arg1: applesCount);
Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: bananasText, arg1: bananasCount);

decimal value = 0.325M;

Console.WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);
