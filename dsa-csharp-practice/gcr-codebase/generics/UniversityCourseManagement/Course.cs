
using System.Collections.Generic;

// Generic course manager
class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public List<T> GetCourses()
    {
        return courses;
    }
}
