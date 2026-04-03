
using System;

// Menu driven class for user guidance
class MealMenu
{
    public void Run()
    {
        int choice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("Personalized Meal Plan Generator");
            Console.WriteLine("1. Vegetarian Meal");
            Console.WriteLine("2. Vegan Meal");
            Console.WriteLine("3. Keto Meal");
            Console.WriteLine("4. High Protein Meal");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    MealUtility.GenerateMealPlan<VegetarianMeal>();
                    break;
                case 2:
                    MealUtility.GenerateMealPlan<VeganMeal>();
                    break;
                case 3:
                    MealUtility.GenerateMealPlan<KetoMeal>();
                    break;
                case 4:
                    MealUtility.GenerateMealPlan<HighProteinMeal>();
                    break;
            }
        }
        while (choice != 5);
    }
}
