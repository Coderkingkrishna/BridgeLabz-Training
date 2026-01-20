interface IExamProctor
{
    void VisitQuestion(int questionId);
    void AnswerQuestion(int questionId, string answer);
    void SubmitExam();
}
