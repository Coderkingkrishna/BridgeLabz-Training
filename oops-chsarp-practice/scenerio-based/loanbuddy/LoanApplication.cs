using System;

abstract class LoanApplication : IApprovable
{
    protected Applicant applicant;
    protected int term; // months
    protected double interestRate; // annual %
    protected LoanStatus status;

    protected LoanApplication(Applicant applicant, int term, double interestRate)
    {
        this.applicant = applicant;
        this.term = term;
        this.interestRate = interestRate;
        status = LoanStatus.Pending;
    }

    // EMI Formula (shared)
    protected double EmiFormula(double principal)
    {
        double r = interestRate / (12 * 100);
        return (principal * r * Math.Pow(1 + r, term)) / (Math.Pow(1 + r, term) - 1);
    }

    public LoanStatus GetStatus()
    {
        return status;
    }

    public abstract bool ApproveLoan();
    public abstract double CalculateEMI();
}
