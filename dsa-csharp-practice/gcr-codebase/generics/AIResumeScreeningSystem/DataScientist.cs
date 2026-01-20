// Data Scientist role
class DataScientist : JobRole
{
    public DataScientist(string name, int experience)
        : base(name, experience) { }

    public override string GetRoleName()
    {
        return "Data Scientist";
    }
}
