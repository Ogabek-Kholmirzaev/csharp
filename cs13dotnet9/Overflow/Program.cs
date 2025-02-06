using static System.Console;

#region overflow

/*
Once it gets above its maximum value,
it overflows to its minimum value and continues incrementing from there.
*/

int x = int.MaxValue - 1;
WriteLine($"Initial value: {x}");

x++;
WriteLine($"After incrementing: {x}");

x++;
WriteLine($"After incrementing: {x}");

x++;
WriteLine($"After incrementing: {x}");

WriteLine();

#endregion

#region checked

/*
If overflow happens, the exception is thrown (OverflowException)
*/

checked
{
    x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");

    x++;
    WriteLine($"After incrementing: {x}");

    x++;
    WriteLine($"After incrementing: {x}");

    x++;
    WriteLine($"After incrementing: {x}");
}

try
{
  // previous code goes here
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}

WriteLine();

#endregion

#region unchecked

// used to disable compile-time overflow check
unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    
    y--;
    WriteLine($"After decrementing: {y}");
    
    y--;
    WriteLine($"After decrementing: {y}");

    WriteLine();
}

#endregion

#region loops and overflow

int max = 500;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}

#endregion
