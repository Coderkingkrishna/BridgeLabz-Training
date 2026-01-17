using System;

class FitnessMenu
{
    private IFitness fitnessTracker;
    int choice;

    public void Run()
    {
        fitnessTracker = new FitnessUtility();
        Console.WriteLine("Welcome to Fitness Tracker");
        do
        {
            Console.WriteLine("1. Add Fitness Data");
            Console.WriteLine("2. Display Ranking on Steps");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    fitnessTracker.AddFitnessData();
                    break;
                case 2:
                    fitnessTracker.DisplayRankingOnSteps();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 3);
    }
}
