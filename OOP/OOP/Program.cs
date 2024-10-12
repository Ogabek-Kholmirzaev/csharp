using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calc = new Calculator(10, 94);
        Console.WriteLine(calc.Add());
        Console.WriteLine(calc.Subtract());
        Console.WriteLine(calc.Multiply());
        Console.WriteLine(calc.Divide());
    }
}
