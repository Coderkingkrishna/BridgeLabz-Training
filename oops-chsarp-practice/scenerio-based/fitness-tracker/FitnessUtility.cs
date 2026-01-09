using System;

public class FitnessUtility : ITrackable
{
    public void AddWorkout(UserProfile user)
    {
        Console.WriteLine("1. Cardio Workout");
        Console.WriteLine("2. Strength Workout");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            CardioWorkout cw = new CardioWorkout();
            Console.Write("Enter Cardio Type: ");
            cw.CardioType = Console.ReadLine();
            Console.Write("Enter Duration: ");
            cw.Duration = int.Parse(Console.ReadLine());

            user.Workouts[user.WorkoutCount++] = cw;
        }
        else if (choice == 2)
        {
            StrengthWorkout sw = new StrengthWorkout();
            Console.Write("Enter Muscle Group: ");
            sw.MuscleGroup = Console.ReadLine();
            Console.Write("Enter Duration: ");
            sw.Duration = int.Parse(Console.ReadLine());

            user.Workouts[user.WorkoutCount++] = sw;
        }
    }

    public void DisplayWorkouts()
    {
        Console.WriteLine("Workouts displayed via Utility Class");
    }
}
