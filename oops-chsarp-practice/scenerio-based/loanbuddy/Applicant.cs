class Applicant
{
    public string Name { get; private set; }
    private int creditScore;
    private double income;
    private double loanAmount;

    public Applicant(string name, int creditScore, double income, double loanAmount)
    {
        Name = name;
        this.creditScore = creditScore;
        this.income = income;
        this.loanAmount = loanAmount;
    }

    // Encapsulation
    public int CreditScore => creditScore;
    public double Income => income;
    public double LoanAmount => loanAmount;
}
