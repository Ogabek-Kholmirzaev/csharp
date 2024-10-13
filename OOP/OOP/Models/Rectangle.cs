namespace OOP.Models;

class Rectangle
{
    // Declare Fields Here
    private int length;
    private int width;

    public Rectangle(int length, int width)
    {
        // Write your code here
        this.length = length;
        this.width = width;
    }

    public int GetArea()
    {
        // Write your code here
        return length * width;
    }
}
