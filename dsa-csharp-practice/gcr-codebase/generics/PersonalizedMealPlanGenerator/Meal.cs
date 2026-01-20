
// Generic Meal class with constraint
class Meal<T> where T : IMealPlan, new()
{
    private T mealPlan;

    public Meal()
    {
        mealPlan = new T();
    }

    public void DisplayMeal()
    {
        System.Console.WriteLine("Meal Type: " + mealPlan.GetMealType());
        System.Console.WriteLine("Recommended Calories: " + mealPlan.GetCalories());
    }
}
