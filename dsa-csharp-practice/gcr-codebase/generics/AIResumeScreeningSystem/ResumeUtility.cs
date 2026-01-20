using System;
using System.Collections.Generic;

// Utility class with generic method
class ResumeUtility
{
    // Generic method to screen resumes
    public static void ScreenResumes<T>(List<T> resumes)
        where T : JobRole
    {
        Console.WriteLine("Screening Results:");

        foreach (T resume in resumes)
        {
            if (resume.Experience >= 2)
            {
                Console.WriteLine(resume + " -> Shortlisted");
            }
            else
            {
                Console.WriteLine(resume + " -> Rejected");
            }
        }
    }
}
