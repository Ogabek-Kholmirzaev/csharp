using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Student john = new Student("John", 75, 75, 90);
        Console.WriteLine(john.TotalObtained());
        Console.WriteLine(john.Percentage());
        Console.WriteLine(john.PhysicsMarks);
    }
}
