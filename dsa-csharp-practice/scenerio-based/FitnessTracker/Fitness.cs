class Fitness
{
    private int PersonID;
    private int Steps;

    public Fitness(int personID, int steps)
    {
        PersonID = personID;
        Steps = steps;
    }

    public int StepsProperty
    {
        get { return Steps; }
    }

    public override string ToString()
    {
        return ("Person ID: " + PersonID + ", Steps: " + Steps);
    }
}
