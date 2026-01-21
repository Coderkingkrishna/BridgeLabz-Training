using System;

class EduMenu
{
    private Student[] students = new Student[50];
    private int count = 0;
    private IRankGenerator generator;

    public EduMenu()
    {
        generator = new EduUtility();
    }

    public void Run()
    {
        int choice;
        do
        {
            Console.WriteLine("1. Add Student Result");
            Console.WriteLine("2. Generate Rank Sheet");
            Console.WriteLine("3. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    generator.GenerateRankSheet(students, count);
                    break;
            }
        } while (choice != 3);
    }

    private void AddStudent()
    {
        if (count >= students.Length)
        {
            Console.WriteLine("Student storage full.");
            return;
        }

        int roll = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        int marks = Convert.ToInt32(Console.ReadLine());
        string district = Console.ReadLine();

        students[count++] = new Student(roll, name, marks, district);
    }
}
