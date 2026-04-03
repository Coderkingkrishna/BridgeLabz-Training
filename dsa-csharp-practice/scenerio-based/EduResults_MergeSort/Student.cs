
class Student
{
    private int rollNo;
    private string name;
    private int marks;
    private string district;

    public Student(int rollNo, string name, int marks, string district)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.marks = marks;
        this.district = district;
    }

    public int RollNo
    {
        get { return rollNo; }
        set { rollNo = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Marks
    {
        get { return marks; }
        set { marks = value; }
    }

    public string District
    {
        get { return district; }
        set { district = value; }
    }

    public override string ToString()
    {
        return "RollNo: " + rollNo +
               ", Name: " + name +
               ", Marks: " + marks +
               ", District: " + district;
    }
}
