
// Assignment based course
class AssignmentCourse : CourseType
{
    public AssignmentCourse(string name, int credits)
        : base(name, credits) { }

    public override string GetEvaluationType()
    {
        return "Assignments";
    }
}
