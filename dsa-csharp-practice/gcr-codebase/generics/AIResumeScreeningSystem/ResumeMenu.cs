using System;

// Menu driven class for user input
class ResumeMenu
{
    private Resume<SoftwareEngineer> softwareResumes = new Resume<SoftwareEngineer>();
    private Resume<DataScientist> dataScienceResumes = new Resume<DataScientist>();

    public void Run()
    {
        int choice;
        do
        {
            Console.WriteLine();
            Console.WriteLine("AI Driven Resume Screening System");
            Console.WriteLine("1. Add Software Engineer Resume");
            Console.WriteLine("2. Add Data Scientist Resume");
            Console.WriteLine("3. Screen All Resumes");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddSoftwareEngineer();
                    break;
                case 2:
                    AddDataScientist();
                    break;
                case 3:
                    ScreenAll();
                    break;
            }
        } while (choice != 4);
    }

    private void AddSoftwareEngineer()
    {
        Console.Write("Enter candidate name: ");
        string name = Console.ReadLine();

        Console.Write("Enter years of experience: ");
        int exp = Convert.ToInt32(Console.ReadLine());

        softwareResumes.AddResume(new SoftwareEngineer(name, exp));
        Console.WriteLine("Software Engineer resume added.");
    }

    private void AddDataScientist()
    {
        Console.Write("Enter candidate name: ");
        string name = Console.ReadLine();

        Console.Write("Enter years of experience: ");
        int exp = Convert.ToInt32(Console.ReadLine());

        dataScienceResumes.AddResume(new DataScientist(name, exp));
        Console.WriteLine("Data Scientist resume added.");
    }

    private void ScreenAll()
    {
        Console.WriteLine();
        Console.WriteLine("Software Engineer Screening:");
        ResumeUtility.ScreenResumes(softwareResumes.GetResumes());

        Console.WriteLine();
        Console.WriteLine("Data Scientist Screening:");
        ResumeUtility.ScreenResumes(dataScienceResumes.GetResumes());
    }
}
