using System.Buffers.Text;
using System.Globalization;
using static System.Console;

#region numbers casting implicitly and explicitly

int a = 10;
double b = a; // An int can be safely cast into a double.
WriteLine($"a is {a}, b is {b}");

/*
double c = 9.8;
int d = c; // Compiler gives an error if you do not explicitly cast.
WriteLine($"c is {c}, d is {d}");
*/

double c = 9.8;
int d = (int)c; // Compiler gives an error if you do not explicitly cast.
WriteLine($"c is {c}, d is {d}"); // d loses the .8 part.

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

WriteLine("{0,12} {1,34}", "Decimal", "Binary");
WriteLine("{0,12} {0,34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
    WriteLine("{0,12} {0,34:B32}", i);
}
WriteLine("{0,12} {0,34:B32}", int.MinValue);

long r = 0b_101000101010001100100111010100101010;
int s = (int) r;
WriteLine($"{r,38:B38} = {r}");
WriteLine($"{s,38:B32} = {s}");

WriteLine();

#endregion

#region System.Convert

double g = 9.81;
int h = Convert.ToInt32(g);
WriteLine($"g is {g}, h is {h}");

double[,] doubles = {
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 } ,
    { -12.49, -12.5, -12.51 },
    { -11.49, -11.5, -11.51 },
    { -10.49, -10.5, -10.51 },
    { -9.49, -9.5, -9.51 }
};

WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Write($"| {doubles[x, y],6} | {Convert.ToInt32(doubles[x, y]),7} ");
    }

    WriteLine("|");
}

foreach (double n in doubles)
{
  WriteLine(
    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
    n,
    Math.Round(n, 0, MidpointRounding.AwayFromZero));
}

WriteLine();

#endregion

#region converting to a string type

int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());

#endregion

#region binary object to string

// Allocate an array of 128 bytes.
byte[] binaryObject = new byte[128];

// Populate the array with random bytes.
Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X2} ");
}
WriteLine();

// Convert the array to Base64 string and output as text.
string encoded = Convert.ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

// Base64 for URLs
string encodedAsBase64 = Base64Url.EncodeToString(binaryObject);
WriteLine($"Binary Object as Base64Url: {encodedAsBase64}");

#endregion

#region strings to numbers or dates and times

// Set the current culture to make sure date parsing works.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 June 1980");

WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

// Avoid exceptions in parsing using TryParse
Write("How many eggs are there? ");
string? input = ReadLine();
if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}

#endregion

#region Try method

// A method that might throw an exception.
int number1 = int.Parse("123");
WriteLine(number1);

// The Try equivalent of the method.
bool success = int.TryParse("123", out int number2);
WriteLine(success + " " + number2);

// Trying to create a Uri for a Web API.
bool success1 = Uri.TryCreate(
    "https://localhost:5000/api/customers",
    UriKind.Absolute,
    out Uri serviceUrl);
WriteLine(success1 + " " + serviceUrl);

#endregion
