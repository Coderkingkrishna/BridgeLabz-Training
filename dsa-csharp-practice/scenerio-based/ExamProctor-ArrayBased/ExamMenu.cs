using System;

class ExamMenu
{
    private IExamProctor exam;

    public ExamMenu()
    {
        exam = new ExamUtility();
    }

    public void Run()
    {
        int choice;
        do
        {
            Console.WriteLine("1. Visit Question");
            Console.WriteLine("2. Answer Question");
            Console.WriteLine("3. Submit Exam");
            Console.WriteLine("4. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    exam.VisitQuestion(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    int qid = Convert.ToInt32(Console.ReadLine());
                    string ans = Console.ReadLine();
                    exam.AnswerQuestion(qid, ans);
                    break;
                case 3:
                    exam.SubmitExam();
                    break;
            }
        } while (choice != 4);
    }
}
