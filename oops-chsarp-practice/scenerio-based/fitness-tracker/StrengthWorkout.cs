public class StrengthWorkout : Workout
{
    private string muscleGroup;

    public string MuscleGroup
    {
        get { return muscleGroup; }
        set { muscleGroup = value; }
    }

    public override string GetWorkoutType()
    {
        return "Strength - " + muscleGroup;
    }
}
