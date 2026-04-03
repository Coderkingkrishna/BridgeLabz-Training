
// Software Engineer role
class SoftwareEngineer : JobRole
{
    public SoftwareEngineer(string name, int experience)
        : base(name, experience) { }

    public override string GetRoleName()
    {
        return "Software Engineer";
    }
}
