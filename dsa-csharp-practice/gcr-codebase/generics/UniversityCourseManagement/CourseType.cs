
// Abstract base class for course evaluation types
abstract class CourseType
{
    public string CourseName { get; set; }
    public int Credits { get; set; }

    protected CourseType(string courseName, int credits)
    {
        CourseName = courseName;
        Credits = credits;
    }

    public abstract string GetEvaluationType();

    public override string ToString()
    {
        return "Course: " + CourseName +
               ", Credits: " + Credits +
               ", Evaluation: " + GetEvaluationType();
    }
}
