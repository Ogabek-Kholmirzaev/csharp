using OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        //Uncomment the below to test your implementation
        StudentEncapsulation student = new StudentEncapsulation();
        student.Name = "John";
        student.RollNumber = "20";
        Console.WriteLine(student.Name + " " + student.RollNumber);

        //In an Encapsulated implementation the following should return an error
        // student._name = "John";
        // student._rollNumber = "20";
    }
}
