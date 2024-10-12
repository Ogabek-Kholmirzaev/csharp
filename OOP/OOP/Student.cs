namespace OOP;

class Student
{
    // Declare the fields and properties here
    private string _name;
    private double _physicsMarks;
    private double _chemistryMarks;
    private double _bioMarks;

    public string Name { get => _name; }
    public double PhysicsMarks { get => _physicsMarks; }
    public double ChemistryMarks { get => _chemistryMarks; }
    public double BioMarks { get => _bioMarks; }

    // Modify the below constructor
    public Student(string name, double phy, double chem, double bio)
    {
        this._name = name;
        this._physicsMarks = phy;
        this._chemistryMarks = chem;
        this._bioMarks = bio;
    }

    public double TotalObtained()
    {
        // Write definition here
        return PhysicsMarks + ChemistryMarks + BioMarks;
    }

    public double Percentage()
    {
        // Write definition here
        return TotalObtained() / 300 * 100;
    }
}
