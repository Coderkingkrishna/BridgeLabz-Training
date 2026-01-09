using System;

public class Menu
{
    private FitnessUtility utility = new FitnessUtility();
    private UserProfile user = new UserProfile();

    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- FitTrack Menu ---");
            Console.WriteLine("1. Enter User Details");
            Console.WriteLine("2. Add Workout");
            Console.WriteLine("3. View User & Workouts");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter User ID: ");
                    user.UserId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    user.UserName = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    user.Age = int.Parse(Console.ReadLine());
                    break;

                case 2:
                    utility.AddWorkout(user);
                    break;

                case 3:
                    Console.WriteLine(user.ToString());
                    for (int i = 0; i < user.WorkoutCount; i++)
                    {
                        Console.WriteLine(user.Workouts[i].ToString());
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting FitTrack...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        } while (choice != 4);
    }
}
