
// Exam based course
class ExamCourse : CourseType
{
    public ExamCourse(string name, int credits)
        : base(name, credits) { }

    public override string GetEvaluationType()
    {
        return "Written Exam";
    }
}
