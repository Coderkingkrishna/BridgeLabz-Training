public abstract class Workout
{
    private int duration;

    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    public abstract string GetWorkoutType();

    public override string ToString()
    {
        return "Workout Type: " + GetWorkoutType() + ", Duration: " + duration + " mins";
    }
}
