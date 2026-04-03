using System;

class ExamUtility : IExamProctor
{
    private CustomStack navigationStack;
    private CustomHashMap answerMap;
    private CustomHashMap correctAnswerMap;

    public ExamUtility()
    {
        navigationStack = new CustomStack(50);
        answerMap = new CustomHashMap(50);
        correctAnswerMap = new CustomHashMap(50);

        correctAnswerMap.Put(1, "A");
        correctAnswerMap.Put(2, "B");
        correctAnswerMap.Put(3, "C");
        correctAnswerMap.Put(4, "D");
    }

    public void VisitQuestion(int questionId)
    {
        navigationStack.Push(questionId);
        Console.WriteLine("Visited Question: " + questionId);
    }

    public void AnswerQuestion(int questionId, string answer)
    {
        answerMap.Put(questionId, answer);
        Console.WriteLine("Answer saved.");
    }

    public void SubmitExam()
    {
        int score = CalculateScore();
        Console.WriteLine("Final Score: " + score);

        int lastVisited = navigationStack.Peek();
        Console.WriteLine(
            "Last Visited Question: " + (lastVisited == -1 ? "None" : lastVisited.ToString())
        );
    }

    private int CalculateScore()
    {
        int score = 0;
        Answer[] submitted = answerMap.GetAll();

        for (int i = 0; i < submitted.Length; i++)
        {
            if (submitted[i] != null)
            {
                Answer correct = correctAnswerMap.Get(submitted[i].QuestionId);
                if (correct != null && correct.StudentAnswer.Equals(submitted[i].StudentAnswer))
                {
                    score++;
                }
            }
        }
        return score;
    }
}
