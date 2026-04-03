public class CardioWorkout : Workout
{
    private string cardioType;

    public string CardioType
    {
        get { return cardioType; }
        set { cardioType = value; }
    }

    public override string GetWorkoutType()
    {
        return "Cardio - " + cardioType;
    }
}
