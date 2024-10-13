using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle obj = new Rectangle(2, 2);
        Console.WriteLine(obj.GetArea());
    }
}
