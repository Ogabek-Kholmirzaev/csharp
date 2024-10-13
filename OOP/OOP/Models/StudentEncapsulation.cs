namespace OOP.Models;

public class StudentEncapsulation
{
    private string _name;
    private string _rollNumber;

    public string Name 
    {
        get { return this._name; } 
        set { this._name = value; }
    }

    public string RollNumber
    {
        get { return this._rollNumber; }
        set { this._rollNumber = value; }
    }
}
