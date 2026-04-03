using System;
using System.Collections.Generic;

// Menu driven class for user interaction
class UniversityMenu
{
    private Course<ExamCourse> examCourses = new Course<ExamCourse>();
    private Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();

    public void Run()
    {
        int choice;
        do
        {
            Console.WriteLine();
            Console.WriteLine("University Course Management System");
            Console.WriteLine("1. Add Exam Course");
            Console.WriteLine("2. Add Assignment Course");
            Console.WriteLine("3. Display All Courses");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddExamCourse();
                    break;
                case 2:
                    AddAssignmentCourse();
                    break;
                case 3:
                    DisplayAllCourses();
                    break;
            }
        } while (choice != 4);
    }

    private void AddExamCourse()
    {
        Console.Write("Enter course name: ");
        string name = Console.ReadLine();

        Console.Write("Enter credits: ");
        int credits = Convert.ToInt32(Console.ReadLine());

        examCourses.AddCourse(new ExamCourse(name, credits));
        Console.WriteLine("Exam course added successfully.");
    }

    private void AddAssignmentCourse()
    {
        Console.Write("Enter course name: ");
        string name = Console.ReadLine();

        Console.Write("Enter credits: ");
        int credits = Convert.ToInt32(Console.ReadLine());

        assignmentCourses.AddCourse(new AssignmentCourse(name, credits));
        Console.WriteLine("Assignment course added successfully.");
    }

    private void DisplayAllCourses()
    {
        Console.WriteLine();
        Console.WriteLine("Exam Based Courses:");
        DisplayCourses(examCourses.GetCourses());

        Console.WriteLine();
        Console.WriteLine("Assignment Based Courses:");
        DisplayCourses(assignmentCourses.GetCourses());
    }

    // Generic display method with constraint
    private void DisplayCourses<T>(List<T> courses)
        where T : CourseType
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("No courses available.");
            return;
        }

        foreach (T course in courses)
        {
            Console.WriteLine(course);
        }
    }
}
