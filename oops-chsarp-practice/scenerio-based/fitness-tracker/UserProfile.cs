public class UserProfile
{
    private int userId;
    private string userName;
    private int age;
    private Workout[] workouts = new Workout[10];
    private int workoutCount = 0;

    public int UserId
    {
        get { return userId; }
        set { userId = value; }
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Workout[] Workouts
    {
        get { return workouts; }
    }

    public int WorkoutCount
    {
        get { return workoutCount; }
        set { workoutCount = value; }
    }

    public override string ToString()
    {
        return "User ID:" + userId + ", Name: " + userName + ", Age: " + age;
    }
}
