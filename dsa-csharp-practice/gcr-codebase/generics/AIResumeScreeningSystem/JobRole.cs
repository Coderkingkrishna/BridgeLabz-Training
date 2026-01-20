// Abstract base class for all job roles
abstract class JobRole
{
    public string CandidateName { get; set; }
    public int Experience { get; set; }

    protected JobRole(string candidateName, int experience)
    {
        CandidateName = candidateName;
        Experience = experience;
    }

    public abstract string GetRoleName();

    public override string ToString()
    {
        return "Candidate: "
            + CandidateName
            + ", Experience: "
            + Experience
            + " years, Role Applied: "
            + GetRoleName();
    }
}
