using System.Reflection;

#region working with referenced assemblies

Assembly? app = Assembly.GetEntryAssembly();

if (app is null)
{
    return;
}

foreach (AssemblyName assemblyName in app.GetReferencedAssemblies())
{
    Assembly assembly = Assembly.Load(assemblyName);
    int methodCount = 0;

    foreach (TypeInfo typeInfo in assembly.DefinedTypes)
    {
        methodCount += typeInfo.GetMethods().Length;
    }

    Console.WriteLine("{0} types with {1} methods in {2} assembly.",
        assembly.DefinedTypes.Count(),
        methodCount,
        assemblyName.Name);
}

Console.WriteLine();

#endregion

#region character (Char) and string (String)

// Assigning literal characters.
char letter = 'A';
char digit = '1';
char symbol = '$';

Console.WriteLine($"Letter = {letter}, Digit = {digit}, Symbol = {symbol}.");

string firstName = "Bob"; // Assigning literal strings.
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";

// Assigning a string returned from the string class constructor.
string horizontalLine = new('-', count: 17); // 17 hyphens.

// Assigning an emoji by converting from Unicode.
string grinningEmoji = char.ConvertFromUtf32(0x1F600);

Console.WriteLine($"FirstName = {firstName}, LastName = {lastName}, PhoneNumber = {phoneNumber}");
Console.WriteLine($"Emoji = {grinningEmoji}, HorizontalLine = {horizontalLine}");

string filePath = @"C:\televisions\sony\bravia.txt";
string xml = """
            <person age="50">
                <first_name>Mark</first_name>
            </person>
            """;

Console.WriteLine(filePath);
Console.WriteLine(xml);

var person = new { FirstName = "Alice", Age = 56 };
string json = $$"""
                {
                    "first_name": "{{person.FirstName}}",
                    "age": {{person.Age}},
                    "calculation": "{{ 1 + 2 }}"
                }
                """;

Console.WriteLine(json);
Console.WriteLine();

#endregion

#region numbers

// An unsigned integer is a positive whole number or 0.
uint naturalNumber = 23;

// An integer is a negative or positive whole number or 0.
int integerNumber = -23;

// A float is a single-precision floating-point number.
// The F or f suffix makes the value a float literal.
// The suffix is required to compile.
float realNumber = 2.3f;

// A double is a double-precision floating-point number.
// double is the default for a number value with a decimal point.
double anotherRealNumber = 2.3; // A double literal value.

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// Check the three variables have the same value.
Console.WriteLine($"{decimalNotation == binaryNotation}, {decimalNotation == hexadecimalNotation}");

// Output the variable values in decimal.
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");

// Output the variable values in hexadecimal.
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}");
Console.WriteLine();

#endregion

#region exploring type sizes

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
unsafe
{
  Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}.");
  Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}

Console.WriteLine();

#endregion

#region double (8 bytes) vs decimal (16 bytes)

double a = 0.1, b = 0.2;
float c = 0.1f, d = 0.2f;
decimal e = 0.1m, f = 0.2m;

Console.WriteLine("Using doubles: {0}", a + b == 0.3);
Console.WriteLine("Using floates: {0}", c + d == 0.3f);
Console.WriteLine("Using decimals: {0}", e + f == 0.3m);
Console.WriteLine();

#endregion

#region object

object height = 1.88; // Storing a double in an object.
object name = "Amir"; // Storing a string in an object.

Console.WriteLine($"{name} is {height} metres tall.");

int length = ((string)name).Length; // Cast name to a string.

Console.WriteLine($"{name} has {length} characters.");
Console.WriteLine();

#endregion

#region dynamic

dynamic something;

// Storing an array of int values in a dynamic object.
// An array of any type has a Length property.
something = new[] { 3, 5, 7 };

Console.WriteLine(string.Join(' ', something));
Console.WriteLine(something.GetType());

// Storing an int in a dynamic object.
// int does not have a Length property.
something = 12;

Console.WriteLine(something);
Console.WriteLine(something.GetType());

// Storing a string in a dynamic object.
// string has a Length property.
something = "Ahmed";

// This compiles but might throw an exception at run-time.
Console.WriteLine($"The length of something is {something.Length}");

// Output the type of the something variable.
Console.WriteLine($"something is a {something.GetType()}");
Console.WriteLine();

#endregion
