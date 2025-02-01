using static System.Console;

#region Reading Console Inputs

// Console.Write("Type your first name and press ENTER: ");
// string? firstName = Console.ReadLine();

// Console.Write("Type your age and press ENTER: ");
// string age = Console.ReadLine()!;

// Console.WriteLine($"Hello {firstName}, you look good for {age}.");

#endregion

#region Reading Key

// Write("Press any key combination: ");
// ConsoleKeyInfo key = ReadKey();
// WriteLine();
// WriteLine(
//     "Key: {0}, Char: {1}, Modifiers: {2}",
//     arg0: key.Key,
//     arg1: key.KeyChar,
//     arg2: key.Modifiers);

#endregion

#region Arguments (args)

WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // Stop running.
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true);

CursorSize = int.Parse(args[2]);

#endregion
