class Answer
{
    private int questionId;
    private string answer;

    public Answer(int questionId, string answer)
    {
        this.questionId = questionId;
        this.answer = answer;
    }

    public int QuestionId
    {
        get { return questionId; }
        set { questionId = value; }
    }

    public string StudentAnswer
    {
        get { return answer; }
        set { answer = value; }
    }

    public override string ToString()
    {
        return "Question ID: " + questionId + ", Answer: " + answer;
    }
}
