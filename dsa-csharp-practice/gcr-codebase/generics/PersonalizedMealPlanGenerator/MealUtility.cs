
// Utility class with generic method
class MealUtility
{
    // Generic method to generate meal plan
    public static void GenerateMealPlan<T>() where T : IMealPlan, new()
    {
        Meal<T> meal = new Meal<T>();
        meal.DisplayMeal();
    }
}
