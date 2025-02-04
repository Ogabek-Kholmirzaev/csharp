using System.Collections;
using static System.Console;

#region while

int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

WriteLine();

#endregion

#region do while

// string? actualPassword = "Pa$$w0rd";
// string? password;
// do
// {
//     Write("Enter your password: ");
//     password = ReadLine();
// } while (password != actualPassword);
// WriteLine("Correct!\n");

#endregion

#region for

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

for (int y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}

WriteLine();

#endregion

#region foreach

List<string> names = [ "Adam", "Barry", "Charlie" ];
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
  string name = (string)e.Current; // Current is read-only!
  WriteLine($"{name} has {name.Length} characters.");
}

WriteLine();

#endregion
